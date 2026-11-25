using Aufgabe_DTO.Anschrift;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_WinForm.Services.IServices
{
    internal interface IAnschriftenService
    {
        Task<T?> GetAnschriftenByPersonID<T>(int personID);
        Task<T?> CreateAnschrift<T>(AnschriftCreateDTO anschriftCreateDTO);
        Task<T?> DeleteAnschrift<T>(int id);
    }
}
