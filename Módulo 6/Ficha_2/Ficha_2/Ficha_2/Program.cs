using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    class Program
    {
        struct registo
        {
            public string nome;
            public int classificacao, anoDisc;

            public registo(string nome, int classificacao, int anoDisc)
            {
                this.nome = nome;
                this.classificacao = classificacao;
                this.anoDisc = anoDisc;
            }
        }
        
      
       
        static void inserir(Stack<registo> pilha)
        {
            Console.Write("Insira o número de alunos a inserir: ");
            int numalunos = int.Parse(Console.ReadLine());
            registo[] reg = new registo[numalunos];
            for (int i = 0; i < numalunos; i++)
            {

                Console.WriteLine("Insira o nome do Aluno.");
                reg[i].nome = Console.ReadLine();
                Console.WriteLine("Insira a Classificação do Aluno.");
                reg[i].classificacao = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o Ano da Disciplina.");
                reg[i].anoDisc = int.Parse(Console.ReadLine());
                pilha.Push(reg[i]);
                Console.WriteLine("Aluno: " + reg[i].nome + " Classificação: " + reg[i].classificacao + " Ano da Disciplina" + reg[i].anoDisc);
            }
        }
        static void Main(string[] args)
        {
  registo r = new registo();
            Stack<registo> pilha = new Stack<registo>();

            Menu:
            Console.WriteLine();
            Console.WriteLine("1.Verificar se existem registos.");
            Console.WriteLine("2.Adicionar Registo.");
            Console.WriteLine("3.Remover um Registo.");
            Console.WriteLine("4.Verificar Classificação de um aluno.");
            Console.WriteLine("5.Sair");

            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {

                case 1:
                    if (pilha.Count <= 0)
                    {
                        Console.WriteLine("A pilha está vazia!");
                    }
                    else Console.WriteLine("A pilha contém " + pilha.Count + " registos.");

                    break;
                case 2:
                    inserir(pilha);
                    break;
                case 3:
                    pilha.Pop();
                    Console.WriteLine("O primeiro registo foi removido.");
                    break;
                case 4:
                    foreach (var registo in pilha)
                    {
                        Console.WriteLine(registo.nome+" "+registo.classificacao);
                    }
                    break;
            }

            goto Menu;
            

            //pilha.Pop();
            


            
        }

    }
}
