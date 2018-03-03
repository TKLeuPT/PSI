using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_6
{
    //Escreve um algoritmo que leia os dados de “N” pessoas: nome, sexo, idade e saúde(boa, má) 
    //e informe se está apta ou não para cumprir o serviço militar obrigatório(>18 e saúde boa). Informe os totais e percentagens de aptos.
    class Program
    {
        struct Pessoas
        {
            public string nome, sexo, saude;
            public int idade;
           

            public Pessoas(string nome, int idade, string sexo, string saude)
            {
                this.nome = nome;
                this.idade = idade;
                this.sexo = sexo;
                this.saude = saude;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
