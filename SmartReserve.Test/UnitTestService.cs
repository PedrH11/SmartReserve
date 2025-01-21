using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartReserve.Domain.Base;
using SmartReserve.Domain.Entities;
using SmartReserve.Repository.Context;
using SmartReserve.Repository.Mapping;
using SmartReserve.Repository.Repository;
using SmartReserve.Services.Services;
using SmartReserve.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartReserve.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "127.0.0.1";
                var port = "3306";
                var database = "SmartReserve";
                var username = "root";
                var password = "Tiao1108@";
                var strCon = $"Server={server}; Port={port}; Database = {database};" +
                    $"Uid={username}; Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<CategoriaAula>, BaseRepository<CategoriaAula>>();
            services.AddScoped<IBaseService<CategoriaAula>, BaseService<CategoriaAula>>();

            services.AddScoped<IBaseRepository<Instrutores>, BaseRepository<Instrutores>>();
            services.AddScoped<IBaseService<Instrutores>, BaseService<Instrutores>>();

            services.AddScoped<IBaseRepository<Alunos>, BaseRepository<Alunos>>();
            services.AddScoped<IBaseService<Alunos>, BaseService<Alunos>>();

            services.AddScoped<IBaseRepository<Aulas>, BaseRepository<Aulas>>();
            services.AddScoped<IBaseService<Aulas>, BaseService<Aulas>>();

            services.AddScoped<IBaseRepository<Reservas>, BaseRepository<Reservas>>();
            services.AddScoped<IBaseService<Reservas>, BaseService<Reservas>>();

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriaAula, CategoriaAula>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Instrutores, Instrutores>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Alunos, Alunos>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Alunos, Alunos>();
            }).CreateMapper());

            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Reservas, Reservas>();
            }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertCategoriaAula()
        {
            var sp = ConfigureServices();
            var categoriaAulaService = sp.GetService<IBaseService<CategoriaAula>>();
            var categoriaAula = new CategoriaAula
            {
                nome = "Spinning",
            };

            var result = categoriaAulaService.Add<CategoriaAula, CategoriaAula, CategoriaAulaValidator>(categoriaAula);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCategoriaAula()
        {
            var sp = ConfigureServices();
            var categoriaAulaService = sp.GetService<IBaseService<CategoriaAula>>();

            var result = categoriaAulaService.Get<CategoriaAula>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertInstrutores()
        {
            var sp = ConfigureServices();
            var instutoresService = sp.GetService<IBaseService<Instrutores>>();
            var instrutores = new Instrutores
            {
                nome = "Spinning",
                especialidade = "Spinning",
                CPF = "123123123"
            };

            var result = instutoresService.Add<Instrutores, Instrutores, InstrutoresValidator>(instrutores);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectInstrutores()
        {
            var sp = ConfigureServices();
            var instrutoresService = sp.GetService<IBaseService<Instrutores>>();

            var result = instrutoresService.Get<Instrutores>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertAlunos()
        {
            var sp = ConfigureServices();
            var alunosService = sp.GetService<IBaseService<Alunos>>();
            var alunos = new Alunos
            {
                Nome = "Spinning",
                Datanasc = DateOnly.Parse("2004-02-01"),
                CPF = "123123123",
                Telefone = "1299323323",
            };

            var result = alunosService.Add<Alunos, Alunos, AlunosValidator>(alunos);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectAlunos()
        {
            var sp = ConfigureServices();
            var alunosService = sp.GetService<IBaseService<Alunos>>();

            var result = alunosService.Get<Alunos>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertAulas()
        {
            var sp = ConfigureServices();
            var instrutoresService = sp.GetService<IBaseService<Instrutores>>();
            var instrutores = instrutoresService.Get<Instrutores>().FirstOrDefault(i=>i.Id==1);

            var categoriaAulaService = sp.GetService<IBaseService<CategoriaAula>>();
            var categoriaAula = categoriaAulaService.Get<CategoriaAula>().FirstOrDefault(i => i.Id == 1);

            var aulasService = sp.GetService<IBaseService<Aulas>>();
            var aulas = new Aulas
            {
                Descricao = "Spinning",
                Capacidade = 20,
                Horario = DateTime.Parse("12:00:00 2025-02-11"),
                Instrutores = instrutores,
                CategoriaAula = categoriaAula,
            };

            var result = aulasService.Add<Aulas, Aulas, AulasValidator>(aulas);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectAulas()
        {
            var sp = ConfigureServices();
            var aulasService = sp.GetService<IBaseService<Aulas>>();

            var result = aulasService.Get<Aulas>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertReservas()
        {
            var sp = ConfigureServices();
            var aulasService = sp.GetService<IBaseService<Aulas>>();
            var aulas = aulasService.Get<Aulas>().FirstOrDefault(a => a.Id == 1);

            var alunosService = sp.GetService<IBaseService<Alunos>>();
            var alunos = alunosService.Get<Alunos>().FirstOrDefault(al => al.Id == 1);

            var reservasService = sp.GetService<IBaseService<Reservas>>();
            var reservas = new Reservas
            {
                HoraReserva = DateTime.Parse("11:00:00 2025-02-11"),
                Alunos = alunos,
                Aulas = aulas,
            };

            var result = reservasService.Add<Reservas, Reservas, ReservasValidator>(reservas);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectReservas()
        {
            var sp = ConfigureServices();
            var reservasService = sp.GetService<IBaseService<Reservas>>();

            var result = reservasService.Get<Reservas>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
