using Aufgabe_API.Data;
using Aufgabe_API.Model;
using Aufgabe_DTO.Anschrift;
using Aufgabe_DTO.TelefonVerbindung;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aufgabe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TelefonverbindungController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;

        public TelefonverbindungController(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("{personID:int}")]
        [ProducesResponseType(typeof(IEnumerable<TelefonverbindungDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<TelefonverbindungDTO>>> GetTelefonverbindungenByPersonID(int personID)
        {
            try
            {
                if (personID <= 0)
                {
                    return BadRequest("PersonID must be greater than 0");
                }

                var telefonverbindungen = await _dbContext.Telefonverbindungen.Where(x => x.PersonID == personID).ToListAsync();
                var dtoResponse = _mapper.Map<List<TelefonverbindungDTO>>(telefonverbindungen);

                return Ok(dtoResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("{personID:int}")]
        [ProducesResponseType(typeof(TelefonverbindungDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(object), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<TelefonverbindungDTO>> CreateTelefonverbindung(int personID, TelefonverbindungCreateDTO telefonverbindungCreateDTO)
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

                Telefonverbindung telefonverbindung = _mapper.Map<Telefonverbindung>(telefonverbindungCreateDTO);
                await _dbContext.Telefonverbindungen.AddAsync(telefonverbindung);
                await _dbContext.SaveChangesAsync();

                var telefonVerbindungDTO = _mapper.Map<TelefonverbindungDTO>(telefonverbindung);

                return Ok(telefonVerbindungDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<object>> DeleteTelefonverbindung(int id)
        {
            try
            {
                var telefonverbindung = await _dbContext.Telefonverbindungen.FirstOrDefaultAsync(x => x.AnschriftID == id);

                if (telefonverbindung == null)
                {
                    return NotFound($"No Telefonverbindung found with ID {id}");
                }

                _dbContext.Telefonverbindungen.Remove(telefonverbindung);
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
