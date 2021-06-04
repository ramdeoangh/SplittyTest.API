using System.Threading.Tasks;

namespace SplittyTest.API.Repositories.Interface
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}