using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Services.IServices;

namespace Aufgabe_WinForm.Controller
{
    internal class PersonenAPIController
    {
        private readonly IPersonenService _personenService;

        public PersonenAPIController(IPersonenService personenService)
        {
            _personenService = personenService;
        }

        public async Task<List<PersonPartialDTO>> GetPersonenAsync()
        {
            try
            {
                return await _personenService.GetPersonenAsync<List<PersonPartialDTO>>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<List<PersonPartialDTO>> GetPersonenByNameAsync(string name)
        {
            try
            {
                return await _personenService.GetPersonenByNameAsync<List<PersonPartialDTO>>(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<PersonCompleteDTO> GetPersonByIdAsync(int id)
        {
            try
            {
                return await _personenService.GetPersonByIdAsync<PersonCompleteDTO>(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<PersonCompleteDTO> UpdatePersonNameAsync(PersonUpdateNameDTO personUpdateNameDTO)
        {
            try
            {
                return await _personenService.UpdatePersonNameAsync<PersonCompleteDTO>(personUpdateNameDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }
    }
}
