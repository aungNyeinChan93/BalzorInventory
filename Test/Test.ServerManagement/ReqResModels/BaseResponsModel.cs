namespace Test.ServerManagement.ReqResModels
{
    public class BaseResponsModel<T>
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; } =string.Empty;
        public bool ResponseStatus { get; set; }

        public T? Data { get; set; } 
    }
}
