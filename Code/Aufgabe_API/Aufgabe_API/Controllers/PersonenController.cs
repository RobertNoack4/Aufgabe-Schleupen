using Aufgabe_API.Data;
using Aufgabe_DTO.Person;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aufgabe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonenController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;

        public PersonenController(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PersonPartialDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PersonPartialDTO>>> GetPersonen()
        {
            try
            {
                var personen = await _dbContext.Personen.ToListAsync();
                var dtoResponse = _mapper.Map<List<PersonPartialDTO>>(personen);
                return Ok(dtoResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{name:alpha}")]
        [ProducesResponseType(typeof(IEnumerable<PersonPartialDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PersonPartialDTO>>> GetPersonenByName(string name)
        {
            try
            {
                var personen = await _dbContext.Personen.Where(x => x.Name_Groß.Contains(name)).ToListAsync();
                var dtoResponse = _mapper.Map<List<PersonPartialDTO>>(personen);
                return Ok(dtoResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(PersonCompleteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PersonCompleteDTO>> GetPersonById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("ID must be greater than 0");
                }

                var person = await _dbContext.Personen.FirstOrDefaultAsync(x => x.PersonID == id);
                if (person == null)
                {
                    return NotFound($"No Person found with ID {id}");
                }

                var dtoResponse = _mapper.Map<PersonCompleteDTO>(person);
                return Ok(dtoResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(PersonCompleteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PersonCompleteDTO>> UpdatePersonName(int id, PersonUpdateNameDTO personUpdateNameDTO)
        {
            try
            {
                if(personUpdateNameDTO == null)
                {
                    return BadRequest("New Person Data is required");
                }

                if(personUpdateNameDTO.PersonID != id)
                {
                    return BadRequest("PersonID in URL and PersonID in Data need to match");
                }

                var person = _dbContext.Personen.FirstOrDefault(x => x.PersonID == id);

                if(person == null)
                {
                    return NotFound($"No Person with PersonID {id} has been found");
                }

                person.Name = personUpdateNameDTO.Name;
                person.Vorname = personUpdateNameDTO.Vorname;

                await _dbContext.SaveChangesAsync();
                return Ok(person);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
