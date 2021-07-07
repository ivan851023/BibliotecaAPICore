using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPICore.DAL
{
    public class LibroMap : IEntityTypeConfiguration<Libros>
    {
        public void Configure(EntityTypeBuilder<Libros> entity)
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("LIBROS");
            entity.HasIndex(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Titulo).HasColumnName("TITULO");
            entity.Property(e => e.Anio).HasColumnName("AÑO");
            entity.Property(e => e.Genero).HasColumnName("GENERO");
            entity.Property(e => e.NumeroPaginas).HasColumnName("NUMERO_PAGINAS");
            entity.Property(e => e.IdAutor).HasColumnName("ID_AUTOR");
            entity.HasAlternateKey(e => e.IdAutor);
        }

    }
}
