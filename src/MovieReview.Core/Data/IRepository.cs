using MovieReview.Core.DomainObjects;
using System;

namespace MovieReview.Core.Data
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
    }
}
