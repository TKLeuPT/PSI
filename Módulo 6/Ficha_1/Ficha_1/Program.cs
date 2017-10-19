/*
 * Created by SharpDevelop.
 * User: leona
 * Date: 18/10/2017
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ficha_1
{
	class Program
	{
	#region structs
	struct aviao
	{
	public string nome,companhia,tipo;
	public int numero;
	
	public aviao(string nome,int numero,string companhia,string tipo)
		{
			this.nome=nome;
			this.numero=numero;
			this.companhia=companhia;
			this.tipo=tipo;
		}
	}
	#endregion
	
		public static void Main(string[] args)
		{
			
			
			#region aviões
			aviao aviao1 = new aviao();
			
			aviao1.nome="Airbus";
			aviao1.numero = 545;
			aviao1.companhia ="TAP";
			aviao1.tipo = "Avião";
			
			aviao aviao2 = new aviao();
			
			aviao2.nome="Airbus";
			aviao2.numero = 676;
			aviao2.companhia ="EasyJet";
			aviao2.tipo = "Avião";
			
			aviao aviao3 = new aviao();
			
			aviao3.nome="Dash ";
			aviao3.numero = 400;
			aviao3.companhia ="Sata";
			aviao3.tipo = "Avioneta";
			
			aviao aviao4 = new aviao();
			
			aviao4.nome="Dash";
			aviao4.numero = 200;
			aviao4.companhia ="Sata";
			aviao4.tipo = "Avioneta";
			#endregion
			
			Queue<aviao> fila = new Queue<aviao>();
			
			fila.Enqueue (aviao1);
			fila.Enqueue (aviao2);
			fila.Enqueue (aviao3);
			fila.Enqueue (aviao4);
		Menu:
			Console.WriteLine("");
			Console.WriteLine("1.Listar nº de aviões em espera.");
			Console.WriteLine("2.Autorizar descolagem do 1º avião.");
			Console.WriteLine("3.Adicionar avião à fila.");
			Console.WriteLine("4.Listar todos os aviões em espera.");
			Console.WriteLine("5.Listar caracteristicas do 1º avião.");
			Console.WriteLine("6.Sair.");
			
			 int caseSwitch = int.Parse(Console.ReadLine());
			switch (caseSwitch)
      {
				
          case 1:
              Console.WriteLine("Listar nº de aviões em espera.");
              Console.WriteLine("Estão na fila "+fila.Count+" aviões.");
              break;
          case 2:
              fila.Dequeue();
              Console.WriteLine("Descolagem autorizada.");
              Console.WriteLine("Estão agora na fila "+fila.Count+" aviões.");
              break;
          case 3:
              Console.Write("Insira o número de aviões a inserir: ");
               int numavioes = int.Parse(Console.ReadLine());
              aviao[] avioes = new aviao[numavioes];
              for (int i = 0; i < numavioes; i++) {
              
              Console.WriteLine("Insira o nome do avião.");
              avioes[i].nome = Console.ReadLine();
              Console.WriteLine("Insira o numero do avião.");
              avioes[i].numero = int.Parse(Console.ReadLine());
              Console.WriteLine("Insira a companhia do avião.");
              avioes[i].companhia = Console.ReadLine();
              Console.WriteLine("Insira o tipo do avião.");
              avioes[i].tipo = Console.ReadLine();
              fila.Enqueue(avioes[i]);
              Console.WriteLine(avioes[i].tipo+" "+avioes[i].nome+ " " + avioes[i].numero +" da Companhia "+ avioes[i].companhia +" adicionado à fila.\n");
              }
              
              break;
          case 4:
              Console.WriteLine("Todos os aviões em espera:\n");
              foreach (var aviao in fila) {
              	
              	Console.WriteLine(aviao.tipo+" "+aviao.nome+ " " + aviao.numero +" "+ aviao.companhia+"\n");
              }
              break;
          case 5:
              Console.WriteLine("Caracteristicas do 1º avião.");
              Console.WriteLine("Compania: "+ fila.Peek().companhia);
              Console.WriteLine("Tipo de avião: " + fila.Peek().tipo);
              break;
          case 6:
              Environment.Exit(0);
             
              break;
      }
			goto Menu;
			
			
			
		}
	}
}