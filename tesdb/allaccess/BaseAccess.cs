using Autofac;
using WebApplication1;

namespace tesdb.allaccess
{
    public class BaseAccess
    {
        private readonly ILifetimeScope serviceProvider;

        public BaseAccess(ILifetimeScope serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IAccessUpdate<User> GetUserAccess()
        {
            return new UserAccess<User>(serviceProvider.Resolve<IRepository<User>>());
        }

        public IAccess<Other> GetOtherAccess()
        {
            return new OtherAccess<Other>(serviceProvider.Resolve<IRepository<Other>>());
        }
    }
}