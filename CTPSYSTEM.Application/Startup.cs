using CTPSYSTEM.Domain.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace CTPSYSTEM.Application
{
    public static class Startup
    {
        public static IServiceCollection AdicionaDependencia(this IServiceCollection services)
        {
            return services.AddScoped<IEmpresaService, EmpresaService>()
                           .AddScoped<IFuncionarioService, FuncionarioService>()
                           .AddScoped<IFuncionarioGovernoService, FuncionarioGovernoService>()
                           .AddScoped<IHashService, HashService>();
        }
    }
}