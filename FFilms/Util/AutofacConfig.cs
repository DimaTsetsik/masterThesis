﻿using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using FFilms.Controllers;
using FFilms.Services.Abstractions;
using FFilms.Services;

namespace FFilms.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<HomeController>().InstancePerRequest();
            builder.RegisterType<AccountController>().InstancePerRequest();

            builder.RegisterType<SmtpMailClient>()
                   .As<IMailClient>()
                   .InstancePerRequest();

            builder.RegisterType<MailService>()
                   .As<IMailService>()
                   .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}