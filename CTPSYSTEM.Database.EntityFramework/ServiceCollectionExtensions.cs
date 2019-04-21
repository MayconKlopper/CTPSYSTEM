using CTPSYSTEM.Database.EntityFramework.Persistence;
using CTPSYSTEM.Database.EntityFramework.Persistencia;
using CTPSYSTEM.Domain.Dados;
using Microsoft.Extensions.DependencyInjection;

namespace CTPSYSTEM.Database.EntityFramework
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection IncludeDatabaseServices(this IServiceCollection services)
        {
            return services.AddScoped<EmpresaContext>()
                            .AddScoped<IEmpresaStorage>(provider => provider.GetService<EmpresaContext>())
                            .AddScoped<IEmpresaReadOnlyStorage>(provider => provider.GetService<EmpresaContext>())
                           .AddScoped<FuncionarioGovernoContext>()
                            .AddScoped<IFuncionarioGovernoStorage>(provider => provider.GetService<FuncionarioGovernoContext>())
                            .AddScoped<IFuncionarioGovernoReadOnlyStorage>(provider => provider.GetService<FuncionarioGovernoContext>())
                           .AddScoped<IFuncionarioReadOnlyStorage, FuncionarioContext>()
                           .AddScoped<IHashStorage, HashContext>();
        }
    }
}