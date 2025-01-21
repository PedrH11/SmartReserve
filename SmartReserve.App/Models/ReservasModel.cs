using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.App.Models
{
    public class ReservasModel
    {
        public int Id { get; set; }
        public bool StatusReserva { get; set; }
        public DateTime HoraReserva     { get; set; }
        public int idAlunos { get; set; }
        public string alunos {  get; set; }
        public int idAulas { get; set; }
        public string aulas { get; set; }
    }
}
