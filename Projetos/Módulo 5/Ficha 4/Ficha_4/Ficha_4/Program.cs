using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    class Program
    {
        struct Pessoas
        {
            public string nome;
            public double altura;

            public Pessoas(string nome, double altura)
            {
                this.nome = nome;
                this.altura = altura;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Insira o nº de pessoas a registar: ");
            int numpessoas = int.Parse(Console.ReadLine());


            Pessoas[] registo = new Pessoas[numpessoas];

            for (int i = 0; i < numpessoas; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine());



                Pessoas novoregisto = new Pessoas(nome, altura);
                registo[i] = novoregisto;
            }

            foreach (Pessoas reg in registo)
            {
                if (reg.altura <= 1.50)
                {
                    Console.WriteLine("Pessoas com altura menor ou igual a 1,50cm:");
                    Console.WriteLine("Nome: {0} \nAltura: {1}", reg.nome, reg.altura);
                }
                if (reg.altura > 1.50)
                {
                    Console.WriteLine("Pessoas com altura maior que 1,50cm:");
                    Console.WriteLine("Nome: {0} \nAltura: {1}", reg.nome, reg.altura);
                }
                if (reg.altura > 1.50 && reg.altura > 2.00)
                {
                    Console.WriteLine("Pessoas com altura maior que 1,50cm e menor que 2m:");
                    Console.WriteLine("Nome: {0} \nAltura: {1}", reg.nome, reg.altura);
                }


            }

            
            for (int i = 0; i < registo.Length; i++)
            {          
                Console.WriteLine("Nome: " + registo[i].nome + " \nAltura: " + registo[i].altura);
            }

           
            double total = 0;
            double media = 0;
            for (int i = 0; i < registo.Length; i++)

            {

                total += registo[i].altura;

            }
           
            media = total / registo.Length;
            Console.WriteLine("Media das alturas: " + media);



            Console.ReadKey();
        }
    }
}
