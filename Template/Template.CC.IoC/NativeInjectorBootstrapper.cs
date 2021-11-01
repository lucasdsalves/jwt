using Microsoft.Extensions.DependencyInjection;
using Template.Application.Interfaces;
using Template.Application.Services;
using Template.Domain.Interfaces;
using Template.Infra.Data.Repositories;

namespace Template.CC.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<IAuthenticationAppService, AuthenticationAppService>();

            //Repository
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
