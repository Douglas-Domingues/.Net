using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades___Metodos___Construtores.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal valor)
        {
            Id = id;
            Produto = produto;
            Valor = valor;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
    }
}
