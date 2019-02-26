using CTPSYSTEM.Application;
using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Database.EntityFramework.Persistence;
using CTPSYSTEM.Database.EntityFramework.Persistencia;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Views.WebAPI.Data;
using CTPSYSTEM.Views.WebAPI.Models;
using CTPSYSTEM.Views.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CTPSYSTEM.Views.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Conexao>()
                .AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>()

                .AddScoped<EmpresaContext>()
                            .AddScoped<IEmpresaStorage>(provider => provider.GetService<EmpresaContext>())
                            .AddScoped<IEmpresaReadOnlyStorage>(provider => provider.GetService<EmpresaContext>())
                           .AddScoped<FuncionarioGovernoContext>()
                            .AddScoped<IFuncionarioGovernoStorage>(provider => provider.GetService<FuncionarioGovernoContext>())
                            .AddScoped<IFuncionarioGovernoReadOnlyStorage>(provider => provider.GetService<FuncionarioGovernoContext>())
                           .AddScoped<IFuncionarioReadOnlyStorage, FuncionarioContext>()
                           .AddScoped<IHashStorage, HashContext>()

                           .AddScoped<IEmpresaService, EmpresaService>()
                           .AddScoped<IFuncionarioService, FuncionarioService>()
                           .AddScoped<IFuncionarioGovernoService, FuncionarioGovernoService>()
                           .AddScoped<IHashService, HashService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}