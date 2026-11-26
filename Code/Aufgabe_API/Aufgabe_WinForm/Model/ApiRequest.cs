namespace Aufgabe_WinForm.Model
{
    internal class ApiRequest
    {
        public ApiType.ApiTypeEnum ApiType { get; set; } = Model.ApiType.ApiTypeEnum.GET;
        public string? Url { get; set; }
        public object? Data { get; set; }
    }
}
