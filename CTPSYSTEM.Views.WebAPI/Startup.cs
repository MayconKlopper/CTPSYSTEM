using CTPSYSTEM.Application;
using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Database.EntityFramework.Persistence;
using CTPSYSTEM.Database.EntityFramework.Persistencia;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Views.WebAPI.Data;
using CTPSYSTEM.Views.WebAPI.Models;
using CTPSYSTEM.Views.WebAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace CTPSYSTEM.Views.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string configuracaoOrigens = "configuracaoOrigens";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(configuracaoOrigens,
                builder =>
                {
                    builder.WithOrigins("http://localhost:3001")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            services.AddDbContext<Conexao>()
                .AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            var signingConfiguration = new SigningConfiguration();
            services.AddSingleton(signingConfiguration);

            var tokenConfiguration = new TokenConfiguration();
            new ConfigureFromConfigurationOptions<TokenConfiguration>(
                Configuration.GetSection("TokenConfiguration"))
                    .Configure(tokenConfiguration);
            services.AddSingleton(tokenConfiguration);


            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signingConfiguration.Key;
                paramsValidation.ValidAudience = tokenConfiguration.Audience;
                paramsValidation.ValidIssuer = tokenConfiguration.Issuer;

                // Valida a assinatura de um token recebido
                paramsValidation.ValidateIssuerSigningKey = true;

                // Verifica se um token recebido ainda é válido
                paramsValidation.ValidateLifetime = true;

                // Tempo de tolerância para a expiração de um token (utilizado
                // caso haja problemas de sincronismo de horário entre diferentes
                // computadores envolvidos no processo de comunicação)
                paramsValidation.ClockSkew = TimeSpan.Zero;
            });

            // Ativa o uso do token como forma de autorizar o acesso
            // a recursos deste projeto
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
            });

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

            app.UseCors(configuracaoOrigens);
            app.UseMvc();
        }
    }
}