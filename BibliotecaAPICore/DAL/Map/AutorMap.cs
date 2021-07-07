using BBibliotecaAPICore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPICore.DAL
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> entity)
        {
            entity.HasKey(e => e.Id);
            entity.ToTable("AUTOR");
            entity.HasIndex(e => e.Id);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombres).HasColumnName("NOMBRES");
            entity.Property(e => e.FechaNacimiento).HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.Ciudad).HasColumnName("CIUDAD");
            entity.Property(e => e.Correo).HasColumnName("EMAIL");
            
        }

    }
}
