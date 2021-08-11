using CotizacionEnLinea.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionEnLinea.Server.Data
{
  
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options,IOptions<OperationalStoreOptions> operationalStoreOptions) 
            : base(options, operationalStoreOptions){
        }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Licitacion> Licitaciones { get; set; }

        public DbSet<LinsxLicit> LinsxLicits { get; set; }

        public DbSet<LinsxCotiz> LinsxCotizs { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
