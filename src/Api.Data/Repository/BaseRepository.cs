using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRespository<T> where T : BaseEntity
    {
        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
