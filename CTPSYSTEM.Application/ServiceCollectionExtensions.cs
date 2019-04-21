using CTPSYSTEM.Domain.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace CTPSYSTEM.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection IncludeApplicationServices(this IServiceCollection serviceCollection) 
            => serviceCollection
                .AddScoped<IHashService, HashService>()
                .AddScoped<IEmpresaService, EmpresaService>()
                .AddScoped<IFuncionarioService, FuncionarioService>()
                .AddScoped<IFuncionarioGovernoService, FuncionarioGovernoService>();
    }
}