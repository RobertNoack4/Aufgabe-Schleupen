using Aufgabe_DTO.TelefonVerbindung;
using Aufgabe_WinForm.Controller.API_Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_WinForm.Controller.View_Controller
{
    internal class CreateTelefonverbindungViewController
    {
        private readonly TelefonverbindungAPIController _telefonverbindungAPIController;
        private readonly int _personID;

        public CreateTelefonverbindungViewController(TelefonverbindungAPIController telefonverbindungAPIController, int personID)
        {
            _telefonverbindungAPIController = telefonverbindungAPIController;
            _personID = personID;
        }

        public async Task<TelefonverbindungDTO> CreateTelefonverbindungAsync(string nummer)
        {
            var createTelefonverbindungDTO = new TelefonverbindungCreateDTO
            {
                Nummer = nummer,
                PersonID = _personID,
            };

            return await _telefonverbindungAPIController.CreateTelefonverbindungAsync(createTelefonverbindungDTO);
        }
    }
}
