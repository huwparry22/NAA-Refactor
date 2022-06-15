namespace Deloitte.NAA.Core.Interfaces
{
    public interface IMapper<TObjOne, TObjTwo>
        where TObjOne : class, new()
        where TObjTwo : class, new()
    {
        TObjTwo MapTo(TObjOne objOne);

        TObjOne MapTo(TObjTwo objTwo);
    }
}
