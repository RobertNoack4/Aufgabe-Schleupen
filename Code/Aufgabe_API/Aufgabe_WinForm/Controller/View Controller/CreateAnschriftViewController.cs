using Aufgabe_DTO.Anschrift;
using Aufgabe_WinForm.Controller.API_Controller;

namespace Aufgabe_WinForm.Controller.View_Controller
{
    internal class CreateAnschriftViewController
    {
        private readonly AnschriftenAPIController _anschriftenAPIController;
        private readonly int _personID;

        public CreateAnschriftViewController(AnschriftenAPIController anschriftenAPIController, int personID)
        {
            _anschriftenAPIController = anschriftenAPIController;
            _personID = personID;
        }

        public async Task<AnschriftDTO> CreateAnschriftAsync(string postleitzahl, string ort, string strasse, string hausnummer)
        {
            var createAnschriftDTO = new AnschriftCreateDTO
            {
                Postleitzahl = postleitzahl,
                Ort = ort,
                Straße = strasse,
                Hausnummer = hausnummer,
                PersonID = _personID
            };

            return await _anschriftenAPIController.CreateAnschriftAsync(createAnschriftDTO);
        }
    }
}
