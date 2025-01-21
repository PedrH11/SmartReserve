using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using SmartReserve.App.Cadastros;
using SmartReserve.App.Models;
using SmartReserve.App.Outros;
using SmartReserve.Domain.Base;
using SmartReserve.Domain.Entities;
using SmartReserve.Repository.Context;
using SmartReserve.Repository.Repository;
using SmartReserve.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static IServiceProvider? ServiceProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            #region Banco de dados
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(100);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion
            #region Repositórios
            Services.AddScoped<IBaseRepository<CategoriaAula>, BaseRepository<CategoriaAula>>();
            Services.AddScoped<IBaseRepository<Instrutores>, BaseRepository<Instrutores>>();
            Services.AddScoped<IBaseRepository<Alunos>, BaseRepository<Alunos>>();
            Services.AddScoped<IBaseRepository<Aulas>, BaseRepository<Aulas>>();
            Services.AddScoped<IBaseRepository<Reservas>, BaseRepository<Reservas>>();
            #endregion
            #region Serviços 
            Services.AddScoped<IBaseService<CategoriaAula>, BaseService<CategoriaAula>>();
            Services.AddScoped<IBaseService<Instrutores>, BaseService<Instrutores>>();
            Services.AddScoped<IBaseService<Alunos>, BaseService<Alunos>>();
            Services.AddScoped<IBaseService<Aulas>, BaseService<Aulas>>();
            Services.AddScoped<IBaseService<Reservas>, BaseService<Reservas>>();
            #endregion
            #region Formularios 
            Services.AddTransient<CadastroCategoriaAula, CadastroCategoriaAula>();
            Services.AddTransient<CadastroInstrutores, CadastroInstrutores>();
            Services.AddTransient<CadastroAlunos, CadastroAlunos>();
            Services.AddTransient<CadastroAulas, CadastroAulas>();
            Services.AddTransient<CadastroReservas, CadastroReservas>();
            Services.AddTransient<RelatorioReservas, RelatorioReservas>();
            Services.AddTransient<RelatorioAulasDisp, RelatorioAulasDisp>();
            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<CategoriaAula, CategoriaAulaModel>();

                config.CreateMap<Instrutores, InstrutoresModel>();

                config.CreateMap<Alunos, AlunosModel>();

                config.CreateMap<Aulas, AulasModel>()
                .ForMember(a => a.CategoriaAula, a => a.MapFrom(x => $"{x.CategoriaAula!.nome}"))
                .ForMember(a => a.idCategoriaAula, a => a.MapFrom(x => $"{x.CategoriaAula!.Id}"))
                .ForMember(a => a.Instrutores, a => a.MapFrom(x => $"{x.Instrutores!.nome}"))
                .ForMember(a => a.idInstrutores, a => a.MapFrom(x => $"{x.Instrutores!.Id}"));

                config.CreateMap<Reservas, ReservasModel>()
                .ForMember(a => a.alunos, a => a.MapFrom(x => $"{x.Alunos!.Nome}"))
                .ForMember(a => a.idAlunos, a => a.MapFrom(x => $"{x.Alunos!.Id}"))
                .ForMember(a => a.aulas, a => a.MapFrom(x => $"{x.Aulas!.Descricao}"))
                .ForMember(a => a.idAulas, a => a.MapFrom(x => $"{x.Aulas!.Id}"));
            }).CreateMapper());
            #endregion
            ServiceProvider = Services.BuildServiceProvider();

        }
    }
}
