using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Mod_7
{
    class Venda
    {
        
        public string Pizza { get; set; }
        public DateTime DataVenda { get; set; }
        public int Qtd { get; set; }
        public Venda(string Pizza, int Qtd, DateTime DataVenda)
        {
            this.Pizza = Pizza;
            this.Qtd = Qtd;
            this.DataVenda = DataVenda;       
        }
    }
}
