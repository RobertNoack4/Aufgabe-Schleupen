using Aufgabe_DTO.Anschrift;
using Aufgabe_DTO.Person;
using Aufgabe_DTO.TelefonVerbindung;
using Aufgabe_WinForm.Controller.API_Controller;
using Aufgabe_WinForm.Views;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Aufgabe_WinForm.Controller.View_Controller
{
    internal class PersonDetailViewController
    {
        private readonly PersonenAPIController _personenAPIController;
        private readonly AnschriftenAPIController _anschriftenAPIController;
        private readonly TelefonverbindungAPIController _tefonverbindungAPIController;
        private readonly int _personID;

        public PersonDetailViewController(PersonenAPIController personenAPIController, AnschriftenAPIController anschriftenAPIController, TelefonverbindungAPIController telefonverbindungAPIController, int personID)
        {
            _personenAPIController = personenAPIController;
            _anschriftenAPIController = anschriftenAPIController;
            _tefonverbindungAPIController = telefonverbindungAPIController;
            _personID = personID;
        }

        internal async Task<PersonCompleteDTO> GetPersonByIdAsync()
        {
            return await _personenAPIController.GetPersonByIdAsync(_personID);
        }

        internal async Task<List<AnschriftDTO>> GetAnschriftenByPersonIDAsync()
        {
            return await _anschriftenAPIController.GetAnschriftenByPersonIDAsync(_personID);
        }

        internal async Task<List<TelefonverbindungDTO>> GetTelefonverbindungByPersonIDAsync()
        {
            return await _tefonverbindungAPIController.GetTelefonverbindungByPersonIDAsync(_personID);
        }

        internal async Task<object> DeleteAnschriftAsync(int id)
        {
            if (OpenMessageBox("Anschrift"))
            {
                return await _anschriftenAPIController.DeleteAnschriftAsync(id);
            }

            return null;
        }

        internal async Task<object> DeleteTelefonverbindungAsync(int id)
        {
            if(OpenMessageBox("Telefonverbindung"))
            {
                return await _tefonverbindungAPIController.DeleteTelefonverbindungAsync(id);
            }

            return null;
        }

        internal async void OpenChangeNameView(PersonCompleteDTO personCompleteDTO)
        {
            var changeNameViewController = new ChangeNameViewController(_personenAPIController, _personID);
            var changeNameView = new ChangeName(changeNameViewController, personCompleteDTO);

            changeNameView.ShowDialog();
        }

        internal async void OpenCreateAnschriftView()
        {
            var createAnschriftViewController = new CreateAnschriftViewController(_anschriftenAPIController, _personID);
            var createAnschriftView = new CreateAnschrift(createAnschriftViewController);

            createAnschriftView.ShowDialog();
        }

        internal async void OpenCreateTelefonverbindungView()
        {
            var createTelefonverbindungViewController = new CreateTelefonverbindungViewController(_tefonverbindungAPIController, _personID);
            var createTelefonverbindungView = new CreateTelefonverbindung(createTelefonverbindungViewController);

            createTelefonverbindungView.ShowDialog();
        }

        private bool OpenMessageBox(string name)
        {
            DialogResult result = MessageBox.Show($"Bist du sicher dass du diese {name} löschen willst?", "Löschen",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
