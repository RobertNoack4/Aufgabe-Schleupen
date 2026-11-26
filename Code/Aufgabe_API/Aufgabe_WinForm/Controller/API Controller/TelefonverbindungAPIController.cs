using Aufgabe_DTO.Anschrift;
using Aufgabe_DTO.TelefonVerbindung;
using Aufgabe_WinForm.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_WinForm.Controller.API_Controller
{
    internal class TelefonverbindungAPIController
    {
        private readonly ITelefonverbindungsService _telefonverbindungsService;

        public TelefonverbindungAPIController(ITelefonverbindungsService telefonverbindungsService)
        {
            _telefonverbindungsService = telefonverbindungsService;
        }

        public async Task<List<TelefonverbindungDTO>> GetTelefonverbindungByPersonIDAsync(int personID)
        {
            try
            {
                return await _telefonverbindungsService.GetTelefonverbindungenByPersonID<List<TelefonverbindungDTO>>(personID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<TelefonverbindungDTO> CreateTelefonverbindungAsync(TelefonverbindungCreateDTO telefonverbindungCreateDTO)
        {
            try
            {
                return await _telefonverbindungsService.CreateTelefonverbindung<TelefonverbindungDTO>(telefonverbindungCreateDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }

        public async Task<object> DeleteTelefonverbindungAsync(int id)
        {
            try
            {
                return await _telefonverbindungsService.DeleteTelefonverbindung<object>(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
                return null;
            }
        }
    }
}
