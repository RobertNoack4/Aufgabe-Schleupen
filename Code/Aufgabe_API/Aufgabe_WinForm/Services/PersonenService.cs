using Aufgabe_WinForm.Model;
using Aufgabe_WinForm.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_WinForm.Services
{
    internal class PersonenService : BaseService, IPersonenService
    {
        private const string endpoint = "api/personen";

        public Task<T?> GetPersonenAsync<T>()
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.GET,
                Url = endpoint,
            });
        }

        public Task<T?> GetPersonenByNameAsync<T>(string name)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.GET,
                Url = $"{endpoint}/by-name/{name}"
            });
        }
    }
}
