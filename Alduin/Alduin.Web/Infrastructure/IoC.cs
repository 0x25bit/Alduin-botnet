using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using Alduin.DataAccess.SessionBuilder;
using Alduin.Logic.Identity;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Managers;
using Alduin.Logic.Repositories;
using Alduin.Logic.UnitOfWork;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;
using Alduin.Web.Models;
using Alduin.Web.Services;
using Alduin.Web.Validators;

namespace Alduin.Web.Infrastructure
{
    public static class IoC
    {
        public static void Setup(IServiceCollection services, IConfiguration configuration)
        {
            SetupSingletons(services, configuration);
            SetupScoped(services);
            SetupTransient(services);
        }

        private static void SetupSingletons(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(SessionFactory.BuildConfiguration(configuration.GetConnectionString("ConnectDataBase"))
                .BuildSessionFactory());
            services.AddSingleton<LocalizationService>();
        }

        private static void SetupScoped(IServiceCollection services)
        {
            services.AddScoped(x => x.GetService<ISessionFactory>().OpenSession());
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Identity
            services.AddScoped<AppIdentityUserManager, AppIdentityUserManager>();
            services.AddScoped<AppSignInManager, AppSignInManager>();
            services.AddScoped<AppIdentityErrorDescriber, AppIdentityErrorDescriber>();

            // Managers

            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IUserClaimManager, UserClaimManager>();
            services.AddScoped<IBotManager, BotManager>();
            services.AddScoped<IInvitationManager, InvitationManager>();
            services.AddScoped<IBotInfoManager, BotInfoManager>();
            // Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserClaimRepository, UserClaimRepository>();
            services.AddScoped<IBotRepository, BotRepository>();
            services.AddScoped<IInvitationRepository, InvitationRepository>();
            services.AddScoped<IBotInfoRepository, BotInfoRepository>();
        }
        private static void SetupTransient(IServiceCollection services)
        {
            // Validators
            services.AddTransient<IValidator<UserDTO>, UserDTOValidator>();
            services.AddTransient<IValidator<LoginModel>, LoginModelValidator>();
            services.AddTransient<IValidator<RegisterModel>, RegisterModelValidator>();
            services.AddTransient<IValidator<ChangePasswordModel>, ChangePasswordModelValidator>();
        }
    }
}
