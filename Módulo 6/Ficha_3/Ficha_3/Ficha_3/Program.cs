using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_3
{
    class Program
    {
        public struct Cidades
        {
            public string nome;
            public int[] temperatura;

            public Cidades(string nome, int[] temperatura)
            {
                this.nome = nome;
                this.temperatura = temperatura;
            }
        }



         public static void Inserir(Queue<Cidades> fila)
        {
            Console.Write("Insira o número de cidades a inserir: ");
            int numcidades = int.Parse(Console.ReadLine());
            Cidades[] cid = new Cidades[numcidades];
            int[] temperatura = new int[12];
            for (int i = 0; i < numcidades; i++)
            {
                Inserircidade:
                Console.WriteLine("Insira o nome da Cidade.");
                cid[i].nome = Console.ReadLine();
                if (cid[i].nome.Length > 20)
                {
                    Console.WriteLine("O nome da cidade no máximo tem 20 Caracteres");
                    goto Inserircidade;
                }
                for (int u = 0; u < 12; u++)
                {
                    Console.WriteLine("Insira a Temperatura da Cidade.");
                    temperatura[u] = int.Parse(Console.ReadLine());
                    cid[i] = new Cidades(cid[i].nome, cid[i].temperatura);

                }
                fila.Enqueue(cid[i]);
                Console.WriteLine("Cidade: " + cid[i].nome + " Temperatura: " + cid[i].temperatura);
            }
        }

        
        public static void Main(string[] args)
        {
            
            Queue<Cidades> fila = new Queue<Cidades>();

            Menu:
            Console.WriteLine();
            Console.WriteLine("1.Verificar se existem Cidades.");
            Console.WriteLine("2.Adicionar Cidade.");
            Console.WriteLine("3.Remover uma Cidade.");
            Console.WriteLine("4.Verificar temperatura de uma cidade.");
            Console.WriteLine("5.Sair");

            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {

                case 1:
                    if (fila.Count <= 0)
                    {
                        Console.WriteLine("A fila está vazia!");
                    }
                    else Console.WriteLine("A fila contém " + fila.Count + " registos.");

                    break;
                case 2:
                    Inserir(fila);
                    break;
                case 3:
                    fila.Dequeue();
                    Console.WriteLine("A primeira cidade foi removida.");
                    break;
                case 4:
                    foreach (var registo in fila)
                    {
                       
                        Console.WriteLine(registo.nome);
                        if (registo.temperatura == null)
                        {
                            Console.Write("N/A");
                        }
                        //foreach (var item in )
                        //{

                        //}
                    }
                    break;
            }

            goto Menu;
        }
    }
}
