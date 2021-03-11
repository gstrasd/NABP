using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Domain;
using Autofac;
using Infrastructure.Domain;
using Infrastructure.Modules;
using Microsoft.Extensions.Configuration;

namespace Application.Modules
{
    public class ApplicationModule :  Module
    {
        private readonly IConfiguration _configuration;

        public ApplicationModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new InfrastructureModule(_configuration));

            builder.Register(c => new OrderService(c.Resolve<IOrderRepository>()))
                .As<IOrderService>()
                .InstancePerLifetimeScope();
        }
    }
}
