using Aufgabe_DTO.Anschrift;
using Aufgabe_WinForm.Services.IServices;

namespace Aufgabe_WinForm.Controller.API_Controller
{
    internal class AnschriftenAPIController
    {
        private readonly IAnschriftenService _anschriftenService;

        public AnschriftenAPIController(IAnschriftenService anschriftenService)
        {
            _anschriftenService = anschriftenService;
        }

        public async Task<List<AnschriftDTO>> GetAnschriftenByPersonIDAsync(int personID)
        {
            try
            {
                return await _anschriftenService.GetAnschriftenByPersonID<List<AnschriftDTO>>(personID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<AnschriftDTO> CreateAnschriftAsync(AnschriftCreateDTO anschriftCreateDTO)
        {
            try
            {
                return await _anschriftenService.CreateAnschrift<AnschriftDTO>(anschriftCreateDTO);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<object> DeleteAnschriftAsync(int id)
        {
            try
            {
                return await _anschriftenService.DeleteAnschrift<object>(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }
    }
}
