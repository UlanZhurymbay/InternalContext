using WebApplication1;

namespace tesdb.allaccess
{
    internal class OtherAccess<T> : IAccess<T> where T : Other
    {
        private readonly IRepository<T> _repository;

        public OtherAccess(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<T> FirstAsync()
        {
            return _repository.GetUserAsync();
        }
    }
}