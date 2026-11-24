using Aufgabe_DTO.Person;

namespace Aufgabe_WinForm.Services.IServices
{
    public interface IPersonenService
    {
        Task<T?> GetPersonenAsync<T>();
        Task<T?> GetPersonenByNameAsync<T>(string name);
    }
}
