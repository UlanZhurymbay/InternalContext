using Autofac;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly ILifetimeScope serviceProvider;
        private DbSet<T> Values { get; set; }

        public Repository(ILifetimeScope serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            GetEntity();
        }

        public Task<T> GetUserAsync()
        {
            return Values.FirstAsync();
        }

        public void GetEntity()
        {
            var serivces = serviceProvider.Resolve<DataContext>();
            Values = serivces.Set<T>();
        }
    }
}
