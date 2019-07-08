using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CTPSYSTEM.Views.WebAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace CTPSYSTEM.Views.WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static PasswordHasher<ApplicationUser> _passwordHasher = new PasswordHasher<ApplicationUser>();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var funcionarioRole = new IdentityRole() { Name = "funcionario", NormalizedName = "FUNCIONARIO", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() };

            builder.Entity<IdentityRole>().HasData(
                    funcionarioRole,
                    new IdentityRole() { Name = "usuario", NormalizedName = "USUARIO", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                    new IdentityRole() { Name = "empresa", NormalizedName = "EMPRESA", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() }
                );

            var defaultAdminUser = new ApplicationUser()
            {
                AccessFailedCount = 0,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Email = "mayconklopper@gov.br",
                EmailConfirmed = false,
                Id = Guid.NewGuid().ToString(),
                LockoutEnabled = true,
                NormalizedEmail = "MAYCONKLOPPER@GOV.BR",
                NormalizedUserName = "MAYCONKLOPPER",
                PhoneNumber = "21970298364",
                PhoneNumberConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                TwoFactorEnabled = false,
                UserName = "mayconklopper"
            };

            defaultAdminUser.PasswordHash = _passwordHasher.HashPassword(defaultAdminUser, "Naovaientrar88@");

            builder.Entity<ApplicationUser>().HasData(defaultAdminUser);

            builder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = defaultAdminUser.Id,
                        RoleId = funcionarioRole.Id
                    }
                );

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
