namespace Deloitte.NAA.API.Interfaces
{
    public interface IApiProcessFactory
    {
        IApiProcess<TRequest, TResponse> GetApiProcess<TRequest, TResponse>()
            where TRequest : class
            where TResponse : class;
    }
}
