using BibliotecaAPICore.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPICore.DAL
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext()
        {

        }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
              : base(options)
        {
        }

       
        public DbSet<Libros> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LibroMap());
            modelBuilder.ApplyConfiguration(new AutorMap());

        }

    }
}
