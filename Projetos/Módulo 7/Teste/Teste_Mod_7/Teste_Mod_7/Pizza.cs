using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Mod_7
{
    class Pizza
    {
        public string Nome { get; set; }
        public string Ingrediente1 { get; set; }
        public string Ingrediente2 { get; set; }
        public string Ingrediente3 { get; set; }
        public string Ingrediente4 { get; set; }
        public string Ingrediente5 { get; set; }
        public string Foto { get; set; }

        public Pizza(string Nome, string Ingrediente1, string Ingrediente2, string Ingrediente3, string Ingrediente4, string Ingrediente5,string Foto)
        {
            this.Nome = Nome;
            this.Ingrediente1 = Ingrediente1;
            this.Ingrediente2 = Ingrediente2;
            this.Ingrediente3 = Ingrediente3;
            this.Ingrediente4 = Ingrediente4;
            this.Ingrediente5 = Ingrediente5;
            this.Foto = Foto;
        }
    }
}
