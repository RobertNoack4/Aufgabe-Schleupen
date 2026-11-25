using Aufgabe_DTO.Anschrift;
using Aufgabe_WinForm.Model;
using Aufgabe_WinForm.Services.IServices;

namespace Aufgabe_WinForm.Services
{
    internal class AnschriftenService : BaseService, IAnschriftenService
    {
        private const string endpoint = "api/anschriften";

        public Task<T?> GetAnschriftenByPersonID<T>(int personID)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.GET,
                Url = $"{endpoint}/{personID}"
            });
        }

        public Task<T?> CreateAnschrift<T>(AnschriftCreateDTO anschriftCreateDTO)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.POST,
                Data = anschriftCreateDTO,
                Url = $"{endpoint}/{anschriftCreateDTO.PersonID}"
            });
        }

        public Task<T?> DeleteAnschrift<T>(int id)
        {
            return SendAsync<T>(new ApiRequest
            {
                ApiType = ApiType.ApiTypeEnum.DELETE,
                Url = $"{endpoint}/{id}"
            });
        }
    }
}
