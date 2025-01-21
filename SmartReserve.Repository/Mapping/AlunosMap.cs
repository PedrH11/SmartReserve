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
    public class AlunosMap : IEntityTypeConfiguration<Alunos>
    {
        public void Configure(EntityTypeBuilder<Alunos> builder)
        {
            builder.ToTable("Alunos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Datanasc).IsRequired().HasColumnType("DATE");
            builder.Property(x => x.Telefone).IsRequired().HasColumnType("varchar(30)");
            builder.Property(x => x.StatusAluno).IsRequired().HasColumnType("BINARY");
            builder.Property(x => x.CPF).IsRequired().HasColumnType("varchar(20)");
        }
    }
}
