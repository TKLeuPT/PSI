using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> fPalin = new Queue<char>();
            Stack<char> pPalin = new Stack<char>();
            Menu:
            Console.WriteLine("\n1.Inserir Palavras");
            Console.WriteLine("2.Sair");
            int switch_on = int.Parse(Console.ReadLine());
            switch (switch_on)
            {
                case 1:
                    Console.WriteLine("Palavra: ");
                    string palavra = Console.ReadLine();
                    foreach (var item in palavra)
                    {
                        fPalin.Enqueue(item);
                        pPalin.Push(item);
                    }
                    int i = 0;
                    foreach (var item in palavra)
                    {
                        if (pPalin.Peek() != fPalin.Peek())
                        {
                            i++;
                            pPalin.Pop();
                            fPalin.Dequeue();
                        }
                        else
                        {
                            pPalin.Pop();
                            fPalin.Dequeue();
                        }
                    }
                    if (i != 0)
                    {
                        Console.Write("Não é Palindoromo");
                        i = 0;
                    }
                    else
                    {
                        Console.Write("É Palindoromo");
                    }
                    break;
                case 2:
                    Environment.Exit(switch_on);
                    break;
            }
            goto Menu;
        }
    }
}
