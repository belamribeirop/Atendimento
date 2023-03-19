using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infra.Contexts;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions;
public static class DependencyInjection
{
    public static void ConfigureDependencyService(IServiceCollection servicesCollection, ConfigurationManager configurationManager)
    {
        servicesCollection.AddDbContext<AppDbContext>();
        servicesCollection.AddScoped<IPatientRepository, PatientRepository>();

        servicesCollection.AddScoped<IPatientService, PatientService>();
    }
}