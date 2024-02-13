using WebApplication1;

namespace tesdb.allaccess
{
    public interface IAccess<T> where T : class
    {
        Task<T> FirstAsync();
    }
    public interface IAccessUpdate<T> : IAccess<T> where T : class
    {
        Task<T> UpdateAsync();
    }


    internal class UserAccess<T> : IAccessUpdate<T> where T : User
    {
        private readonly IRepository<T> _repository;

        public UserAccess(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<T> FirstAsync()
        {
            return _repository.GetUserAsync();
        }

        public Task<T> UpdateAsync()
        {
            return _repository.GetUserAsync();
        }
    }
}