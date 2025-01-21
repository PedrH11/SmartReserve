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
    public class ReservasMap : IEntityTypeConfiguration<Reservas>
    {
        public void Configure(EntityTypeBuilder<Reservas> builder)
        {
            builder.ToTable("Reservas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StatusReserva).IsRequired().HasColumnType("BINARY");
            builder.Property(x => x.HoraReserva).IsRequired().HasColumnType("DATETIME");
            builder.HasOne(prop => prop.Aulas).WithMany().OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(prop => prop.Alunos).WithMany().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
