using Aufgabe_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_WinForm.Services.IServices
{
    internal interface IBaseService
    {
        Task<T> SendAsync<T>(ApiRequest request);
    }
}
