using Aufgabe_DTO.Person;

namespace Aufgabe_WinForm.Controller.View_Controller
{
    internal class OverviewController
    {
        private readonly PersonenAPIController _personenAPIController;

        public OverviewController(PersonenAPIController personenController)
        {
            _personenAPIController = personenController;
        }

        internal async Task<List<PersonPartialDTO>> GetPersonenAsync()
        {
            return await _personenAPIController.GetPersonenAsync();
        }

        internal async Task<List<PersonPartialDTO>> GetPersonenByNameAsync(string name)
        {
            return await _personenAPIController.GetPersonenByNameAsync(name);
        }
    }
}
