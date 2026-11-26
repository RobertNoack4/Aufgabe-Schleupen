using Aufgabe_DTO.Anschrift;

namespace Aufgabe_WinForm.Services.IServices
{
    internal interface IAnschriftenService
    {
        Task<T?> GetAnschriftenByPersonID<T>(int personID);
        Task<T?> CreateAnschrift<T>(AnschriftCreateDTO anschriftCreateDTO);
        Task<T?> DeleteAnschrift<T>(int id);
    }
}
