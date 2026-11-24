using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Aufgabe_WinForm.Model
{
    internal class ApiRequest
    {
        public ApiType.ApiTypeEnum ApiType { get; set; } = Model.ApiType.ApiTypeEnum.GET;
        public string? Url { get; set; }
        public object? Data { get; set; }
    }
}
