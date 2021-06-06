using System.Threading.Tasks;

namespace MovieReview.Core.Data
{
    public interface IUnitOfWork
    {
        Task Commit();
        void Dispose();
    }
}
