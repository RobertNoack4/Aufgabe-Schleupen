using Aufgabe_DTO.Person;
using Aufgabe_WinForm.Model;
using Aufgabe_WinForm.Services.IServices;

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

        public Task<T?> GetPersonByIdAsync<T>(int id)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType= ApiType.ApiTypeEnum.GET,
                Url = $"{endpoint}/{id}"
            });
        }

        public Task<T?> UpdatePersonNameAsync<T>(PersonUpdateNameDTO personUpdateNameDTO)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.PUT,
                Data = personUpdateNameDTO,
                Url = $"{endpoint}/{personUpdateNameDTO.PersonID}"
            });
        }
    }
}
