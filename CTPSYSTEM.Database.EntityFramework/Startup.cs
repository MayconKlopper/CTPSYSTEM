using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Database.EntityFramework.Persistence;
using CTPSYSTEM.Database.EntityFramework.Persistencia;

namespace CTPSYSTEM.Database.EntityFramework
{
    public static class Startup
    {
        public static IServiceCollection AdicionaDependencia(this IServiceCollection services)
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
