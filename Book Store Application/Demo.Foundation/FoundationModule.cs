using Autofac;
using Demo.Foundation.Repositories;
using Demo.Foundation.Contexts;
using Demo.Foundation.Services;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation
{
    public class FoundationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoundationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookStoreContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            
            builder.RegisterType<AddingService>().As<IAddingService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<GetService>().As<IGetService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<BookStoreUnitOfWork>().As<IBookStoreUnitOfWork>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
