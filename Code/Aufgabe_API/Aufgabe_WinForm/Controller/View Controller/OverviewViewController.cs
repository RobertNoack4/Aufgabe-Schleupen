using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Controller.API_Controller;
using Aufgabe_WinForm.Services;

namespace Aufgabe_WinForm.Controller.View_Controller
{
    internal class OverviewViewController
    {
        private readonly PersonenAPIController _personenAPIController;
        private readonly AnschriftenAPIController _anschriftenAPIController;
        private readonly TelefonverbindungAPIController _telefonverbindungAPIController;

        public OverviewViewController(PersonenAPIController personenController, AnschriftenAPIController anschriftenAPIController,
            TelefonverbindungAPIController telefonverbindungAPIController)
        {
            _personenAPIController = personenController;
            _anschriftenAPIController = anschriftenAPIController;
            _telefonverbindungAPIController = telefonverbindungAPIController;
        }

        internal async Task<List<PersonPartialDTO>> GetPersonenAsync()
        {
            return await _personenAPIController.GetPersonenAsync();
        }

        internal async Task<List<PersonPartialDTO>> GetPersonenByNameAsync(string name)
        {
            return await _personenAPIController.GetPersonenByNameAsync(name);
        }

        internal void CreatePersonDetailView(int personID)
        {

            var personDetailController = new PersonDetailViewController(_personenAPIController, _anschriftenAPIController, 
                _telefonverbindungAPIController, personID);
            var personDetailView = new PersonDetail(personDetailController);

            personDetailView.ShowDialog();
        }
    }
}
