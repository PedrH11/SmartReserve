using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartReserve.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCategoriaAula()
        {
            CategoriaAula categoriaAula = new CategoriaAula(1, "Spinning");

            Debug.WriteLine(JsonSerializer.Serialize(categoriaAula));

            Assert.AreEqual(categoriaAula.nome, "Spinning");
        }

        [TestMethod]
        public void TestInstutores()
        {
            Instrutores instrutores = new Instrutores(1, "Carlos", "Musculação", "123123132");

            Debug.WriteLine(JsonSerializer.Serialize(instrutores));

            Assert.AreEqual(instrutores.nome, "Carlos");
            Assert.AreEqual(instrutores.especialidade, "Musculação");
        }

        [TestMethod]
        public void TestAlunos()
        {
            Alunos alunos = new Alunos(1, "Pedro", DateOnly.Parse("2025-01-08"), "18997850800", "123123132", true);

            Debug.WriteLine(JsonSerializer.Serialize(alunos));

            Assert.AreEqual(alunos.Nome, "Pedro");
            Assert.AreEqual(alunos.Datanasc, DateOnly.Parse("2025-01-08"));
            Assert.AreEqual(alunos.Telefone, "18997850800");
            Assert.AreEqual(alunos.StatusAluno, true);
        }

        [TestMethod]
        public void TestAulas()
        {
            Instrutores instrutores = new Instrutores(1, "Carlos", "Musculação", "123123132");
            CategoriaAula categoriaAula = new CategoriaAula(1, "Spinning");
            Aulas aulas = new Aulas(1, "Spinning", 20, DateTime.Parse("11:00:00 2025-01-08"), true, categoriaAula, instrutores);

            Debug.WriteLine(JsonSerializer.Serialize(aulas));

            Assert.AreEqual(aulas.Descricao, "Spinning");
            Assert.AreEqual(aulas.Capacidade, 20);
            Assert.AreEqual(aulas.Horario, DateTime.Parse("11:00:00 2025-01-08"));
            Assert.AreEqual(aulas.StatusAula, true);
            Assert.AreEqual(aulas.CategoriaAula, categoriaAula);
            Assert.AreEqual(aulas.Instrutores, instrutores);
        }

        [TestMethod]
        public void TestReservas()
        {
            Alunos alunos = new Alunos(1, "Pedro", DateOnly.Parse("2025-01-08"), "18997850800", "123123132", true, "pedro1", "pedro1");
            Instrutores instrutores = new Instrutores(1, "Carlos", "Musculação", "123123132");
            CategoriaAula categoriaAula = new CategoriaAula(1, "Spinning");
            Aulas aulas = new Aulas(1, "Spinning", 20, DateTime.Parse("11:00:00 2025-01-08"), true, categoriaAula, instrutores);
            Reservas reservas = new Reservas(1, true, DateTime.Parse("10:30:00 2025-01-08"), aulas, alunos);

            Debug.WriteLine(JsonSerializer.Serialize(reservas));

            Assert.AreEqual(reservas.StatusReserva, true);
            Assert.AreEqual(reservas.HoraReserva, DateTime.Parse("10:30:00 2025-01-08"));
            Assert.AreEqual(reservas.Aulas,aulas);
            Assert.AreEqual(reservas.Alunos, alunos);
        }
    }
}
