using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Controllers;
using Application.Domain;
using Application.Modules;
using Autofac;
using Microsoft.Extensions.Configuration;

namespace Api.Modules
{
    public class ApiModule : Module
    {
        private readonly IConfiguration _configuration;

        public ApiModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new ApplicationModule(_configuration));

            builder.Register(c => new OrderController(c.Resolve<IOrderService>()))
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}
