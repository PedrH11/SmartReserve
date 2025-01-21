using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.App.Models
{
    public class AulasModel
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int capacidade { get; set; }
        public DateTime horario { get; set; }
        public bool StatusAula {  get; set; }
        public int? idInstrutores { get; set; }
        public string? Instrutores {  get; set; }
        public int? idCategoriaAula { get; set; }
        public string? CategoriaAula { get; set; }
    }
}
