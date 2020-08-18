using Autofac;
using DASHRealty.Application.Interfaces;
using DASHRealty.Application.Services;
using DASHRealty.Domain.Core.Interfaces.Repositories;
using DASHRealty.Domain.Core.Interfaces.Services;
using DASHRealty.Domain.Entities;
using DASHRealty.Domain.Services.Services;
using DASHRealty.Domain.Validators;
using DASHRealty.Infra.Data.Repositories;
using FluentValidation;

namespace DASHRealty.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PropertyApplicationService>().As<IPropertyApplicationService>();
            builder.RegisterType<UserApplicationService>().As<IUserApplicationService>();
            builder.RegisterType<TokenApplicationService>().As<ITokenApplicationService>();

            builder.RegisterType<PropertyService>().As<IPropertyService>();
            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<PropertyRepository>().As<IPropertyRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            builder.RegisterType<PropertyValidator>().As<IValidator<Property>>();
        }
    }
}
