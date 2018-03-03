using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    class Program
    {
        struct Contacto
        {
            public string nome, morada, telefone;

            public Contacto(string nome, string morada, string telefone)
            {
                this.nome = nome;
                this.morada = morada;
                this.telefone = telefone;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Insira o nº de contactos da agenda: ");
            int numcontactos = int.Parse(Console.ReadLine());

            Contacto[] agenda = new Contacto[numcontactos];

            for (int i = 0; i < numcontactos; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Morada: ");
                string morada = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Contacto novocontacto = new Contacto(nome, morada, telefone);
                agenda[i] = novocontacto;
            }

            foreach (Contacto cont in agenda)
            {
                Console.WriteLine("Nome: {0} Morada: {1} Telefone: {2}", cont.nome, cont.morada, cont.telefone);
            }

            Console.Write("Insira o nome a procurar: ");
            string procurarNome = Console.ReadLine();
            for (int i = 0; i < agenda.Length; i++)
            {
                if (procurarNome == agenda[i].nome)
                {
                    Console.WriteLine("Nome: {0} Morada: {1} Telefone: {2}", agenda[i].nome, agenda[i].morada, agenda[i].telefone);
                }
               

            }
            Console.WriteLine("Agenda Ordenada: ");
            agenda.OrderBy(x => x.nome);
            foreach (Contacto cont in agenda)
            {
                Console.WriteLine("Nome: {0} Morada: {1} Telefone: {2}", cont.nome, cont.morada, cont.telefone);
            }

            Console.ReadKey();
        }
    }
}
