using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Infrastructure.Domain;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Modules
{
    public class InfrastructureModule : Module
    {
        private readonly IConfiguration _configuration;

        public InfrastructureModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new OrderRepository())
                .As<IOrderRepository>()
                .InstancePerLifetimeScope();
        }
    }
}
