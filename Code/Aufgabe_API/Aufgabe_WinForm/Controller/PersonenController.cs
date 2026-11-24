using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Services;
using Aufgabe_WinForm.Services.IServices;

namespace Aufgabe_WinForm.Controller
{
    public static class PersonenController
    {
        private static readonly IPersonenService _personenService = new PersonenService();

        public static async Task<List<PersonPartialDTO>> GetPersonen()
        {
            try
            {
                var response = await _personenService.GetPersonenAsync<List<PersonPartialDTO>>();
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public static async Task<List<PersonPartialDTO>> GetPersonenByNameAsync(string name)
        {
            try
            {
                var response = await _personenService.GetPersonenByNameAsync<List<PersonPartialDTO>>(name);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }  
    }
}
