namespace Deloitte.NAA.API.Models.Requests
{
    public class Request<T> where T : class
    {
        public T RequestData { get; set; }
    }
}
