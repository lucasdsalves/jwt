using Microsoft.Extensions.DependencyInjection;
using System;
using Template.Application.AutoMapper;

namespace Template.Configuration
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection service)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));

            service.AddAutoMapper(typeof(ViewModelToDomainMappingProfile));
        }
    }
}
