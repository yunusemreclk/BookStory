using Autofac;
using Layer.Caching;
using Layer.Core.IUnitOfWork;
using Layer.Core.Repositories;
using Layer.Core.Services;
using Layer.Core.Servicies;
using Layer.Repository;
using Layer.Repository.Repositories;
using Layer.Repository.UnitOfWork;
using Layer.Service.Mapping;
using Layer.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace Layer.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(BookDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, serviceAssembly, repoAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, serviceAssembly, repoAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<BookServiceWithCaching>().As<IBookService>();

        }
    }
}
