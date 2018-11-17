﻿using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using FFilms.Controllers;
using FFilms.Services.Abstractions;
using FFilms.Services;
using FFilms.Enumerations;
using FFParser.Services.Abstractions;
using FFParser.Services;
using FFilms.Repositories;
using FFilms.Repositories.Abstractions;

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
            builder.RegisterType<BooksController>().InstancePerRequest();

            builder.RegisterType<SmtpMailClient>()
                   .As<IMailClient>()
                   .InstancePerRequest();

            builder.RegisterType<MailService>()
                   .As<IMailService>()
                   .InstancePerRequest();

            builder.RegisterType<Enumeration>()
                  .As<IEnumeration>()
                  .InstancePerRequest();

            builder.RegisterType<GoogleBookService>()
                  .As<IGoogleBookService>()
                  .InstancePerRequest();

            builder.RegisterType<BooksService>()
                   .As<IBooksService>()
                   .InstancePerRequest();

            builder.RegisterType<Moonwalk>()
                   .As<IMoonwalk>()
                   .InstancePerRequest();

            builder.RegisterType<MoonwalkService>()
                   .As<IMoonwalkService>()
                   .InstancePerRequest();

            builder.RegisterType<GenresBooksRepo>()
                   .As<IGenresBooksRepo>()
                   .InstancePerRequest();

            builder.RegisterType<GenresFilmsRepo>()
                   .As<IGenresFilmsRepo>()
                   .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}