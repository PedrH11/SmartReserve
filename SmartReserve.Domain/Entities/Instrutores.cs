using SmartReserve.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Domain.Entities
{
    public class Instrutores : BaseEntity<int>
    {
        public Instrutores() { }
        public Instrutores(int id, string nome, string especialidade, string CPF)
        {
            this.Id = id;
            this.nome = nome;
            this.especialidade = especialidade;
            this.CPF = CPF;
        }

        public string nome { get; set; }
        public string especialidade { get; set; }
        public string CPF { get; set; } 
    }
}
