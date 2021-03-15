using Microsoft.EntityFrameworkCore;
using ProductBacklog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBacklog.Web.Data
{
    public class ProductBackLogContext : DbContext
    {
        public DbSet<HistoriaUsuario> HistoriasUsuarios { get; set; }

        public ProductBackLogContext(DbContextOptions options) : base(options)
        {

        }
    }
}
