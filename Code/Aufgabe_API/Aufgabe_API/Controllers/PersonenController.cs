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
        [ProducesResponseType(typeof(IEnumerable<PersonDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> GetPersonen()
        {
            var personen = await _dbContext.Personen.ToListAsync();
            var dtoResponse = _mapper.Map<List<PersonDTO>>(personen);
            return Ok(dtoResponse);
        }

        [HttpGet("{name:alpha}")]
        [ProducesResponseType(typeof(IEnumerable<PersonDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> GetPersonenByName(string name)
        {
            var personen = await _dbContext.Personen.Where(x => x.Name_Groß.Contains(name)).ToListAsync();
            if(personen == null || personen.Count == 0)
            {
                return NotFound();
            }

            var dtoResponse = _mapper.Map<List<PersonDTO>>(personen);
            return Ok(dtoResponse);
        }
    }
}
