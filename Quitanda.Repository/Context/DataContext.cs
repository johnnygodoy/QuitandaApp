using Microsoft.EntityFrameworkCore;
using Quitanda.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.Repository.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Fruta> Fruta { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=laptop\\SQLEXPRESS;Database=Quitanda;Trusted_Connection=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
