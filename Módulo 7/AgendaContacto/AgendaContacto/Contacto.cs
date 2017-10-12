using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContacto
{
    class Contacto
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public string Telemovel { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public Contacto (string Nome,string Morada,string Email,string Telemovel,DateTime DataNascimento,string Foto)
        {
            this.Nome = Nome;
            this.Morada = Morada;
            this.Email = Email;
            this.Telemovel = Telemovel;
            this.DataNascimento = DataNascimento;
            this.Foto = Foto;
        }

       
    }
}
