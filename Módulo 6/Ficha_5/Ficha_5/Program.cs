using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Editor de Listas");
            Console.WriteLine("1 - Exibir Lista");
            Console.WriteLine("2 - Inserir");
            Console.WriteLine("3 - Remover");
            Console.WriteLine("4 - Exibir Elemento");
            Console.WriteLine("5 - Exibir Posição");
            Console.WriteLine("6 - Esvaziar");
            Console.WriteLine("ESC - Sair");
            int switch_on = int.Parse(Console.ReadLine());
            switch (switch_on)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
        static void Main(string[] args)
        {
            Menu();
            if (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
