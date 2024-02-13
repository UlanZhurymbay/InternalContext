using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using tesdb.allaccess;
using WebApplication1;

namespace tesdb
{
    public class DBModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>().AsSelf()
                .WithParameter(new TypedParameter(typeof(string), "connection"));
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<BaseAccess>().AsSelf();
        }
    }
}
