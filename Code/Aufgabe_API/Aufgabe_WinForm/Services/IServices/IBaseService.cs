using Aufgabe_WinForm.Model;

namespace Aufgabe_WinForm.Services.IServices
{
    internal interface IBaseService
    {
        Task<T> SendAsync<T>(ApiRequest request);
    }
}
