using Microsoft.EntityFrameworkCore;
using System;

namespace BibliotecaDAL
{
    public class dbCTX : DbContext
    {
        public dbCTX(DbContextOptions<dbCTX> options) : base(options)
        {
        }

        public DbSet<Libros> Libros { get; set; }


        public DbSet<Autor> Autor { get; set; }

    }
}
