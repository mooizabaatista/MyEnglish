using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyEnglish.Application.AutoMapper;
using MyEnglish.Application.Interfaces;
using MyEnglish.Application.Services;
using MyEnglish.Helper.Constants;
using MyEnglish.Infra.Context;
using MyEnglish.Infra.Interfaces;
using MyEnglish.Infra.Repositories;

namespace MyEnglish.IoC;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApps(this IServiceCollection services)
    {
        // Repositories
        services.AddScoped<IPalavraRepository, PalavraRepository>();

        // Services
        services.AddScoped<IPalavraService, PalavraService>();

        // Context
        services.AddDbContext<MyEnglishContext>(x => x.UseSqlServer(SharedConstants.connectionString));

        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));

        return services;
    }
}