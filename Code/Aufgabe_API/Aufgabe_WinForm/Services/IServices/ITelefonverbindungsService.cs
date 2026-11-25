using Aufgabe_DTO.TelefonVerbindung;

namespace Aufgabe_WinForm.Services.IServices
{
    internal interface ITelefonverbindungsService
    {
        Task<T?> GetTelefonverbindungenByPersonID<T>(int personID);
        Task<T?> CreateTelefonverbindung<T>(TelefonverbindungCreateDTO telefonverbindungCreateDTO);
        Task<T?> DeleteTelefonverbindung<T>(int id);

    }
}
