using SmartReserve.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Domain.Entities
{
    public class Reservas: BaseEntity<int>
    {
        public Reservas() { }
        public Reservas(int id, bool StatusReserva, DateTime HoraReserva, Aulas? aulas, Alunos? alunos)
        {
            this.Id = id;
            this.StatusReserva = StatusReserva;
            this.HoraReserva = HoraReserva;
            this.Aulas = aulas;
            this.Alunos = alunos;
        }
        public bool StatusReserva { get; set; }
        public DateTime HoraReserva { get; set; }
        public Aulas? Aulas { get; set; }
        public Alunos? Alunos { get; set; }
    }
}
