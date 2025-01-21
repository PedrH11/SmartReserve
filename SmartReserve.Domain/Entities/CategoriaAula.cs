using SmartReserve.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Domain.Entities
{
    public class CategoriaAula : BaseEntity<int>
    {
        public CategoriaAula()
        {

        }

        public CategoriaAula(int id, string nome)
        {
            this.Id = id; 
            this.nome = nome;
        }

        public string? nome { get; set; }
    }
}
