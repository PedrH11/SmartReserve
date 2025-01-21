using Microsoft.EntityFrameworkCore;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartReserve.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class myDbContext : DbContext
        {
            public DbSet<CategoriaAula> categoriaAula { get; set; }
            public DbSet<Instrutores> instrutores { get; set; }
            public DbSet<Alunos> alunos { get; set; }
            public DbSet<Aulas> aulas { get; set; }
            public DbSet<Reservas> reservas { get; set; }

            public myDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "SmartReserve";
                var username = "root";
                var password = "Tiao1108@";
                var strCon = $"Server={server}; Port={port}; Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertCategoriaAula()
        {
            using (var context = new myDbContext())
            {
                var CategoriaAula = new CategoriaAula
                {
                    nome = "Spinning",
                };

                context.categoriaAula.Add(CategoriaAula);

                CategoriaAula = new CategoriaAula
                {
                    nome = "Muay Thai",
                };
                context.categoriaAula.Add(CategoriaAula);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCategoriaAula()
        {
            using (var context = new myDbContext())
            {
                foreach (var CategoriaAula in context.categoriaAula)
                {
                    Console.WriteLine(JsonSerializer.Serialize(CategoriaAula));
                }
            }
        }

        [TestMethod]
        public void TestInsertInstrutores()
        {
            using (var context = new myDbContext())
            {
                var Instrutores = new Instrutores
                {
                    nome = "Spinning",
                    especialidade = "Musculação",
                    CPF = "123123123"
                };

                context.instrutores.Add(Instrutores);

                Instrutores = new Instrutores
                {
                    nome = "Muay Thai",
                    especialidade = "Spinning",
                    CPF = "123123123"
                };
                context.instrutores.Add(Instrutores);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListInstutores()
        {
            using (var context = new myDbContext())
            {
                foreach (var Instrutores in context.instrutores)
                {
                    Console.WriteLine(JsonSerializer.Serialize(Instrutores));
                }
            }
        }

        [TestMethod]
        public void TestInsertAlunos()
        {
            using (var context = new myDbContext())
            {
                var Alunos = new Alunos
                {
                    Nome = "Pedro",
                    Datanasc = DateOnly.Parse("2005-04-21"),
                    Telefone= "18991232321",
                    StatusAluno = true,
                    CPF = "123123123"
                };

                context.alunos.Add(Alunos);

                Alunos = new Alunos
                {
                    Nome = "Julia",
                    Datanasc = DateOnly.Parse("2003-02-22"),
                    Telefone = "18991232321",
                    StatusAluno = true,
                    CPF = "123123124"
                };
                context.alunos.Add(Alunos);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAlunos()
        {
            using (var context = new myDbContext())
            {
                foreach (var Alunos in context.alunos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(Alunos));
                }
            }
        }

        [TestMethod]
        public void TestInsertAulas()
        {
            using (var context = new myDbContext())
            {
                var instrutores = context.instrutores.FirstOrDefault(i=>i.Id == 1);
                var categoriaAula = context.categoriaAula.FirstOrDefault(c => c.Id == 1);
                var Aulas = new Aulas
                {
                    Descricao = "Pedro",
                    Capacidade = 15,
                    Horario = DateTime.Parse("11:00:00 2025-03-04"),
                    StatusAula = true,
                    CategoriaAula = categoriaAula,
                    Instrutores = instrutores,
                };

                context.aulas.Add(Aulas);

                instrutores = context.instrutores.FirstOrDefault(i => i.Id == 2);
                categoriaAula = context.categoriaAula.FirstOrDefault(c => c.Id == 2);
                Aulas = new Aulas
                {
                    Descricao = "Pedro",
                    Capacidade = 15,
                    Horario = DateTime.Parse("11:00:00 2025-03-04"),
                    StatusAula = true,
                    CategoriaAula = categoriaAula,
                    Instrutores = instrutores,
                };
                context.aulas.Add(Aulas);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAulas()
        {
            using (var context = new myDbContext())
            {
                foreach (var Aulas in context.aulas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(Aulas));
                }
            }
        }

        [TestMethod]
        public void TestInsertReservas()
        {
            using (var context = new myDbContext())
            {
                var aulas = context.aulas.FirstOrDefault(i => i.Id == 1);
                var alunos = context.alunos.FirstOrDefault(c => c.Id == 1);
                var reservas = new Reservas
                {
                    StatusReserva = true,
                    HoraReserva = DateTime.Parse("11:00:00 2025-03-04"),
                    Aulas = aulas,
                    Alunos = alunos,
                };

                context.reservas.Add(reservas);

                aulas = context.aulas.FirstOrDefault(i => i.Id == 2);
                alunos = context.alunos.FirstOrDefault(c => c.Id == 2);
                reservas = new Reservas
                {
                    StatusReserva = true,
                    HoraReserva = DateTime.Parse("10:00:00 2025-03-04"),
                    Aulas = aulas,
                    Alunos = alunos,
                };
                context.reservas.Add(reservas);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListReservas()
        {
            using (var context = new myDbContext())
            {
                foreach (var reservas in context.aulas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(reservas));
                }
            }
        }
    }
}
