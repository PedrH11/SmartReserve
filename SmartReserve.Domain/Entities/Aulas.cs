using SmartReserve.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Domain.Entities
{
    public class Aulas: BaseEntity<int>
    {
        public Aulas() { }
        public Aulas(int id, string descricao, int capacidade, DateTime horario, bool StatusAula, CategoriaAula? CategoriaAula,  Instrutores? Instrutores) 
        { 
            this.Id = id;
            this.Descricao = descricao;
            this.Capacidade = capacidade;
            this.Horario = horario;
            this.StatusAula = StatusAula;
            this.CategoriaAula = CategoriaAula;
            this.Instrutores = Instrutores;
        }

        public string Descricao { get; set; }
        public int Capacidade { get; set; }
        public DateTime Horario { get; set; }
        public CategoriaAula? CategoriaAula { get; set; }
        public Instrutores? Instrutores { get; set; }
        public bool StatusAula { get; set; }
    }
}
