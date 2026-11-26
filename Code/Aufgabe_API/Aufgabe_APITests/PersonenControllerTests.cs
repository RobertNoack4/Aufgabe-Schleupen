using Aufgabe_API.Controllers;
using Aufgabe_API.Data;
using Aufgabe_API.Model;
using Aufgabe_DTO.Person;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace Aufgabe_APITests
{
    public class PersonenControllerTests : IDisposable
    {
        private readonly SqliteConnection _connection;
        private readonly ApplicationDBContext _dbContext;
        private readonly PersonenController _controller;
        private readonly IMapper _mapper;

        public PersonenControllerTests()
        {
            _connection = new SqliteConnection("Data Source=:memory:");
            _connection.Open();

            var options = new DbContextOptionsBuilder<ApplicationDBContext>().UseSqlite(_connection).Options;

            _dbContext = new ApplicationDBContext(options);
            _dbContext.Database.EnsureCreated();

            _mapper = Substitute.For<IMapper>();

            _controller = new PersonenController(_dbContext, _mapper);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            _connection.Dispose();
        }

        [Fact]
        public async Task UpdatePersonName_NullDTO_ReturnsBadRequest()
        {
            int personID = 1;

            var result = await _controller.UpdatePersonName(personID, null);

            var badRequest = Assert.IsType<BadRequestObjectResult>(result.Result);

            Assert.Equal("New Person Data is required", badRequest.Value);
        }

        [Fact]
        public async Task UpdatePersonName_IdNotMatch_ReturnsBadRequest()
        {
            int personID = 1;

            var dto = new PersonUpdateNameDTO
            {
                PersonID = 2,
                Name = "Müller",
                Vorname = "Merlin"
            };

            var result = await _controller.UpdatePersonName(personID, dto);

            var badRequest = Assert.IsType<BadRequestObjectResult>(result.Result);

            Assert.Equal("PersonID in URL and PersonID in Data need to match", badRequest.Value);
        }

        [Fact]
        public async Task UpdatePersonName_PersonNotFound_ReturnsNotFound()
        {
            int personID = 1;

            var dto = new PersonUpdateNameDTO
            {
                PersonID = 1,
                Name = "Müller",
                Vorname = "Merlin"
            };

            var result = await _controller.UpdatePersonName(personID, dto);

            var notFound = Assert.IsType<NotFoundObjectResult>(result.Result);

            Assert.Equal($"No Person with PersonID {personID} has been found", notFound.Value);
        }

        [Fact]
        public async Task UpdatePersonName_DatabaseError_ReturnsInternalError()
        {
            int personID = 1;

            var dto = new PersonUpdateNameDTO
            {
                PersonID = 1,
                Name = "Müller",
                Vorname = "Merlin"
            };

            await _connection.CloseAsync();

            var result = await _controller.UpdatePersonName(personID, dto);

            var internalError = Assert.IsType<ObjectResult>(result.Result);

            Assert.Equal(500, internalError.StatusCode);
        }

        [Fact]
        public async Task UpdatePersonName_NormalRequest_UpdatesPerson()
        {
            int personID = 1;

            var newPerson = new Person
            {
                PersonID = 1,
                Name = "Max",
                Vorname = "Musterman",
                Name_Groß = "MAX MUSTERMAN"
            };

            _dbContext.Add(newPerson);
            await _dbContext.SaveChangesAsync();

            var dto = new PersonUpdateNameDTO
            {
                PersonID = 1,
                Name = "Müller",
                Vorname = "Merlin"
            };

            var result = await _controller.UpdatePersonName(personID, dto);

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            
            Assert.Equal(200, okResult.StatusCode);

            var changedPerson = await _dbContext.Personen.FirstOrDefaultAsync(x => x.PersonID == personID);

            Assert.Equal("Müller", newPerson.Name);
            Assert.Equal("Merlin", newPerson.Vorname);
            Assert.Equal("MÜLLER MERLIN", newPerson.Name_Groß);
        }
    }
}
