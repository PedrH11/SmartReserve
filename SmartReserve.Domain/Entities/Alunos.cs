using SmartReserve.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Domain.Entities
{
    public class Alunos : BaseEntity<int>
    {
        public Alunos() { }
        public Alunos(int id, string nome, DateOnly datanasc, string telefone, string CPF, bool StatusAluno)
        {
            this.Id = id; 
            this.Nome = nome;
            this.Datanasc = datanasc;
            this.Telefone = telefone;
            this.StatusAluno = StatusAluno;
            this.CPF = CPF;
        }

        public string Nome { get; set; }
        public DateOnly Datanasc { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public bool StatusAluno { get; set; }
    }
}
