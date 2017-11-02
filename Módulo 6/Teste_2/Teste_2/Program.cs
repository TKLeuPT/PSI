using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_2
{

    public class Sapato
    {
        string cod, nome, estacao;
        int preco, ano, tamanho;

        public Sapato(string cod, string nome, string estacao, int preco, int ano, int tamanho)
        {
            this.cod = cod;
            this.nome = nome;
            this.estacao = estacao;
            this.preco = preco;
            this.ano = ano;
            this.tamanho = tamanho;
        }
        public static void MostrarSapato(List<Sapato> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Sapato: {0} Código: {1} Estação: {2} Tamanho: {3} Ano de Fabrico: {4} Preço: {5}", item.nome, item.cod, item.estacao, item.tamanho, item.ano, item.preco);
            }
        }
        public static void InserirSapato(List<Sapato> list)
        {
            Console.WriteLine("Modelo do Sapato");
            string nome = Console.ReadLine();
            Console.WriteLine("Código do Sapato");
            string cod = Console.ReadLine();
            Console.WriteLine("Estação do Sapato");
            string estacao = Console.ReadLine();
            Console.WriteLine("Tamanho do Sapato");
            int tamanho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano do Sapato");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do Sapato");
            int preco = int.Parse(Console.ReadLine());
            Sapato sapato = new Sapato(cod, nome, estacao, preco, ano, tamanho);
            list.Add(sapato);

        }
        public static void MostrarSapatosEstacao(List<Sapato> list)
        {
            Console.WriteLine("Inverno: " + list.Count(x => x.estacao == "Inverno"));
            Console.WriteLine("Verão: "+ list.Count(x => x.estacao == "Verão"));
            Console.WriteLine("Outono: "+list.Count(x => x.estacao == "Outono"));
            Console.WriteLine("Primavera: " + list.Count(x => x.estacao == "Primavera"));
           

        }
        public static void MostrarSapatosN36(List<Sapato> list)
        {
            Console.WriteLine("Existem "+list.Count(x => x.tamanho == 36)+"Sapatos com o nº 36");
            

        }
        public static void MostrarSapatospreco(List<Sapato> list)
        {

            foreach (var item in list.OrderBy(x => x.preco))
            {
                Console.WriteLine("Sapato: {0} Código: {1} Estação: {2} Tamanho: {3} Ano de Fabrico: {4} Preço: {5}", item.nome, item.cod, item.estacao, item.tamanho, item.ano, item.preco);
            }

        }

        public static void MostrarSapatosm10(List<Sapato> list)
        {

            foreach (var item in list.Where(x =>x.preco < 10))
            {
                Console.WriteLine("Sapato: {0} Código: {1} Estação: {2} Tamanho: {3} Ano de Fabrico: {4} Preço: {5}", item.nome, item.cod, item.estacao, item.tamanho, item.ano, item.preco);
            }

        }

        public static void MostrarDescricaoCod(List<Sapato> list)
        {
            Console.WriteLine("Insira o Código do sapato");
            string cod = Console.ReadLine();
            foreach (var item in list.Where(x => x.cod == cod))
            {
                Console.WriteLine("Sapato: {0} Código: {1} Estação: {2} Tamanho: {3} Ano de Fabrico: {4} Preço: {5}", item.nome, item.cod, item.estacao, item.tamanho, item.ano, item.preco);
            }

        }

        public static void RemoverDescricaoCod(List<Sapato> list)
        {
            Console.WriteLine("Insira o Código do sapato");
            string cod = Console.ReadLine();
            foreach (var item in list.Where(x => x.cod == cod))
            {
                list.Remove(item);
            }

        }

        public static void Descontos(List<Sapato> list)
        {
           
            foreach (var item in list.Where(x => x.ano < 2014))
            {
               
                double precocdesconto = item.preco + (item.preco * 0.3);
                Console.WriteLine("Sapato: {0} Código: {1} Estação: {2} Tamanho: {3} Ano de Fabrico: {4} Preço: {5}", item.nome, item.cod, item.estacao, item.tamanho, item.ano, precocdesconto);
                    }

        }

    }

    class Program
    {
        public static List<Sapato> lista = new List<Sapato>();

        static void Menu()
        {

            Console.WriteLine("1.Mostrar todos os sapatos");
            Console.WriteLine("2.Mostrar nº de Sapatos de cada estação");
            Console.WriteLine("3.Mostrar nº de sapatos com o nº36");
            Console.WriteLine("4.Mostrar lista ordenada por preço");
            Console.WriteLine("5.Mostrar sapatos a menos de 10€");
            Console.WriteLine("6.Inserir sapato");
            Console.WriteLine("7.Mostrar descrição do sapato por código");
            Console.WriteLine("8.Remover sapato por código");
            Console.WriteLine("9.Mostrar lista com descontos");
            Console.WriteLine("10.Sair");

            int switch_on = int.Parse(Console.ReadLine());
            switch (switch_on)
            {
                case 1:

                    Sapato.MostrarSapato(lista);
                    break;
                case 2:
                    Sapato.MostrarSapatosEstacao(lista);
                    break;
                case 3:
                    Sapato.MostrarSapatosN36(lista);
                    break;
                case 4:
                    Sapato.MostrarSapatospreco(lista);
                    break;
                case 5:
                    Sapato.MostrarSapatosm10(lista);
                    break;
                case 6:
                    Sapato.InserirSapato(lista);
                    break;
                case 7:
                    Sapato.MostrarDescricaoCod(lista);
                    break;
                case 8:
                    Sapato.RemoverDescricaoCod(lista);
                    break;
                case 9:
                    Sapato.Descontos(lista);
                    break;
                case 10:
                    Environment.Exit(0);
                    break;


            }

        }
        static void Main(string[] args)
        {


            MainMenu:
            Menu();
            goto MainMenu;
        }

    }
}
