using Microsoft.EntityFrameworkCore;
using SmartReserve.Domain.Entities;
using SmartReserve.Repository.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<CategoriaAula> CategoriaAula { get; set; }
        public DbSet<Instrutores> Instrutores { get; set; }
        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Aulas> Aulas { get; set; }
        public DbSet<Reservas> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoriaAula>(new CategoriaAulaMap().Configure);
            modelBuilder.Entity<Instrutores>(new InstrutoresMap().Configure);
            modelBuilder.Entity<Alunos>(new AlunosMap().Configure);
            modelBuilder.Entity<Aulas>(new AulasMap().Configure);
            modelBuilder.Entity<Reservas>(new ReservasMap().Configure);
        }

    }
}
