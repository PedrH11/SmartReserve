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
    public class CategoriaAulaMap : IEntityTypeConfiguration<CategoriaAula>
    {
        public void Configure(EntityTypeBuilder<CategoriaAula> builder)
        {
            builder.ToTable("CategoriaAula");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop =>prop.nome).IsRequired().HasMaxLength(45);
        }
    }
}
