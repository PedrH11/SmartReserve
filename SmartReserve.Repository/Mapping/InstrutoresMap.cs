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
    public class InstrutoresMap : IEntityTypeConfiguration<Instrutores>
    {
        public void Configure(EntityTypeBuilder<Instrutores> builder)
        {
            builder.ToTable("Instrutores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.especialidade).IsRequired().HasColumnType("varchar(45)");
            builder.Property(x => x.CPF).IsRequired().HasColumnType("varchar(20)");
        }
    }
}
