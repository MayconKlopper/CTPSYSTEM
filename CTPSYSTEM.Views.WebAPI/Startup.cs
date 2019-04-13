using CTPSYSTEM.Application;
using CTPSYSTEM.Database.EntityFramework;
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
using Swashbuckle.AspNetCore.Swagger;
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

            services.AddDbContext<Conexao>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"))
                       .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll))
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
                    .RequireRole(new string[] { "funcionario", "usuario", "empresa" })
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
            });

            // Add application services.
            services.IncludeApplicationServices();
            services.IncludeDatabaseServices();
            services.AddTransient<IEmailSender, EmailSender>()
                    .AddScoped<IUtilsReadOnlyStorage, UtilsContext>();

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "CTPSYSTEM API",
                    Description = "ASP.NET Core Web API About CLT (Brasil Job Contract Model)",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Maycon Klopper de Carvalho", Email = "mayconklopper@gmail.com", Url = "https://ctpsystem.azurewebsites.net" }
                });
            });
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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}