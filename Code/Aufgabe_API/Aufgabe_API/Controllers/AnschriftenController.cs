using Aufgabe_API.Data;
using Aufgabe_API.Model;
using Aufgabe_DTO.Anschrift;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aufgabe_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AnschriftenController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;

        public AnschriftenController(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("{personID:int}")]
        [ProducesResponseType(typeof(IEnumerable<AnschriftDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<AnschriftDTO>>> GetAnschriftenByPersonID(int personID)
        {
            try
            {
                if (personID <= 0)
                {
                    return BadRequest("PersonID must be greater than 0");
                }

                var anschriften = await _dbContext.Anschrift.Where(x => x.PersonID == personID).ToListAsync();
                var dtoResponse = _mapper.Map<List<AnschriftDTO>>(anschriften);

                return Ok(dtoResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("{personID:int}")]
        [ProducesResponseType(typeof(AnschriftDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AnschriftDTO>> CreateAnschrift(int personID, AnschriftCreateDTO anschriftCreateDTO)
        {
            try
            {
                if (personID <= 0)
                {
                    return BadRequest("ID must be greater than 0");
                }

                var person = await _dbContext.Personen.FirstOrDefaultAsync(x => x.PersonID == personID);
                if (person == null)
                {
                    return NotFound($"No Person found with ID {personID}");
                }

                Anschrift anschrift = _mapper.Map<Anschrift>(anschriftCreateDTO);
                await _dbContext.Anschrift.AddAsync(anschrift);
                await _dbContext.SaveChangesAsync();

                var anschriftDTO = _mapper.Map<AnschriftDTO>(anschrift);

                return Ok(anschriftDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<object>> DeleteAnschrift(int id)
        {
            try
            {
                var anschrift = await _dbContext.Anschrift.FirstOrDefaultAsync(x => x.AnschriftID == id);

                if (anschrift == null)
                {
                    return NotFound($"No Anschrift found with ID {id}");
                }

                _dbContext.Anschrift.Remove(anschrift);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
