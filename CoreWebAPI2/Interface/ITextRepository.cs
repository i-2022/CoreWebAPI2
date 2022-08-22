
namespace CoreWebAPI2.Interface
{
    public interface ITextRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(long id);
    }
}