using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Repository.Mapping
{
    public class AulasMap : IEntityTypeConfiguration<Aulas>
    {
        public void Configure(EntityTypeBuilder<Aulas> builder)
        {
            builder.ToTable("Aulas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Capacidade).IsRequired().HasColumnType("int");
            builder.Property(x => x.Horario).IsRequired().HasColumnType("DATETIME");
            builder.Property(x => x.StatusAula).IsRequired().HasColumnType("BINARY");
            builder.HasOne(prop => prop.CategoriaAula).WithMany().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Instrutores).WithMany().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
