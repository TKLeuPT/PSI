/*
 * Created by SharpDevelop.
 * User: leona
 * Date: 18/10/2017
 * Time: 09:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Queue<string> fila = new Queue<string>();
			fila.Enqueue("Joana");
			fila.Enqueue("Carlos");
			fila.Enqueue("Rui");
			fila.Enqueue("António");
			fila.Enqueue("João");
			fila.Enqueue("Sónia");
			
			Console.WriteLine("Pessoas na fila: ");
			
			foreach (var pessoa in fila) 
			{
				Console.WriteLine(pessoa);
			}
			
			Console.WriteLine("\nPróxima pessoa a entrar: "+fila.Peek()+"\n");
			fila.Dequeue();
			
			if (fila.Contains("Rui")) 
			{
				Console.WriteLine("Encontrei o Rui!\n");
			}
			
			int i=Array.IndexOf(fila.ToArray(),"Sónia");
			
			Console.WriteLine("A Sónia está na posição {0}",i+1);
			
			Console.WriteLine("Faltam {0} pessoas para o Rui entrar",i-1);
			Console.WriteLine("Entrou "+fila.Peek());
			fila.Dequeue();
			Console.WriteLine("\nEstão na fila {0} pessoas",fila.Count);
			fila.Clear();
			Console.WriteLine("\nEstão na fila {0} pessoas",fila.Count);
			
			Console.ReadKey(true);
		}
	}
}