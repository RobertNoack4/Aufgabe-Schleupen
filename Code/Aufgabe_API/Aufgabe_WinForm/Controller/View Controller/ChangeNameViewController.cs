using Aufgabe_DTO.Person;

namespace Aufgabe_WinForm.Controller.View_Controller
{
    internal class ChangeNameViewController
    {
        private readonly PersonenAPIController _personenAPIController;
        private readonly int _personID;

        public ChangeNameViewController(PersonenAPIController personenAPIController, int personID)
        {
            _personenAPIController = personenAPIController;
            _personID = personID;
        }

        public async Task<PersonCompleteDTO> UpdatePersonNameAsync(string name, string vorname)
        {
            var personUpdateNameDTO = new PersonUpdateNameDTO
            {
                PersonID = _personID,
                Name = name,
                Vorname = vorname
            };

            return await _personenAPIController.UpdatePersonNameAsync(personUpdateNameDTO);
        }
    }
}
