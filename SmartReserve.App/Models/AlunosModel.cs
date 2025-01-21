using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.App.Models
{
    public class AlunosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateOnly datanasc { get; set; }

        public string telefone { get; set; }
        public bool Ativo {  get; set; }
        public string cpf { get; set; }

    }
}
