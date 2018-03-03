using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> lego = new Stack<string>();

            lego.Push("Lego de 6 Verde");
            lego.Push("Lego de 4 Azul");
            lego.Push("Lego de 4 Preto");
            lego.Push("Lego de 3 Amarelo");
            lego.Push("Lego de 2 Azul");

            Console.WriteLine("Nº de legos na pilha:"+lego.Count+"\n");

            foreach (var l in lego)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();
            Console.WriteLine("No topo da pilha temos o "+lego.Peek());
           
            lego.Pop();
            Console.WriteLine();
            Console.WriteLine("No topo da pilha temos o " + lego.Peek());

            if (lego.Contains("Lego de 4 Vermelho"))
            {
                
            }else Console.WriteLine("\nNão existe nenhum lego de 4 Vermelho");

            Console.ReadKey();
        }
    }
}
