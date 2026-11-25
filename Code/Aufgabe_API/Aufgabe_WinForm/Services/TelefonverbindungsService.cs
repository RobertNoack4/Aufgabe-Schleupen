using Aufgabe_DTO.TelefonVerbindung;
using Aufgabe_WinForm.Model;
using Aufgabe_WinForm.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_WinForm.Services
{
    internal class TelefonverbindungsService : BaseService, ITelefonverbindungsService
    {
        private const string endpoint = "api/telefonverbindung";
        
        public Task<T?> GetTelefonverbindungenByPersonID<T>(int personID)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.GET,
                Url = $"{endpoint}/{personID}"
            });
        }

        public Task<T?> CreateTelefonverbindung<T>(TelefonverbindungCreateDTO telefonverbindungCreateDTO)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.POST,
                Data = telefonverbindungCreateDTO,
                Url = $"{endpoint}/{telefonverbindungCreateDTO.PersonID}"
            });
        }

        public Task<T?> DeleteTelefonverbindung<T>(int id)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.DELETE,
                Url = $"{endpoint}/{id}"
            });
        }
    }
}
