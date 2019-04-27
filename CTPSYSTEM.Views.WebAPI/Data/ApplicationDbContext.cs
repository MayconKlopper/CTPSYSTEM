﻿using System;
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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                    new IdentityRole() { Name = "funcionario", NormalizedName = "FUNCIONARIO", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                    new IdentityRole() { Name = "usuario", NormalizedName = "USUARIO", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() },
                    new IdentityRole() { Name = "empresa", NormalizedName = "EMPRESA", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() }
                );

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
