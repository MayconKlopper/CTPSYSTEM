using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

using CTPSYSTEM.Domain.Servicos;

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
