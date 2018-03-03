using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Desenvolve um programa que armazene 
  nome
  notas dos módulos das diversas disciplinas
  de N alunos do curso de  Gestão e Programação de Sistemas Informáticos efetuando as seguintes tarefas: 

  a) Registar a classificação de cada módulo.

  b) Apresentar todas as classificações dos módulos associando a mensagem de aprovado ou reprovado.

  c) Pesquisar as classificações tendo por base	o nome do aluno, nessa pesquisa o programa deve também 
  apresentar a média global do aluno e a percentagem de módulos em atraso.

    struct modulos
    string nome modulo
    double notas

    inserir nº alunos
    inserir nº modulos
    inserir as notas de cada modulo

    apresentar todas as notas de todos os modulos e dizer se ta aprovado ou reprovado

    pesquisar as notas pelo nome do aluno
    na pesquisar mostrar a media de todas as disciplinas e a % de modulos reprovados
*/
namespace Ficha_3
{
    class Program
    {
        struct Turma
        {
            public string nome;
            public Modulo[] modulos;
            public Turma(string nome, Modulo[] modulos)
            {
                this.nome = nome;
                this.modulos = modulos;
                // no aluno tem de ter um array de modulos
            }

        }
        struct Modulo
        {
            public string nome;
            public int nModulos;
            public double nota;

            public Modulo(string nome, double nota, int nModulos)
            {
                this.nome = nome;
                this.nota = nota;
                this.nModulos = nModulos;


            }
        }


        static void Main(string[] args)
        {

            Console.Write("Insira o nº de alunos da turma: ");
            int nAlunos = int.Parse(Console.ReadLine());
            Turma[] turma = new Turma[nAlunos];



            for (int i = 0; i < nAlunos; i++)
            {
                Console.Write("Nome do Aluno: ");
                turma[i].nome = Console.ReadLine();

                Console.Write("Insira o nº de módulos de programação: ");
                int nModulos = int.Parse(Console.ReadLine());
                Modulo[] modulos = new Modulo[nModulos];

                for (int m = 0; m < nModulos; m++)
                {
                    Console.Write("Nome do módulo: ");
                    modulos[m].nome = Console.ReadLine();

                    Console.Write("Nota do módulo: ");
                    modulos[m].nota = double.Parse(Console.ReadLine());

                }

                turma[i].modulos = modulos;

                Console.Write("Insira o nome do aluno a pesquisar: ");
                string nomealuno = Console.ReadLine();
                for (int n = 0; n < turma.Length; n++)
                {
                    if (turma[n].nome == nomealuno)
                    {
                        double media = 0;
                        double reprovado = 0;
                        Console.WriteLine("Nome: " + turma[n].nome + "\nMódulos: ");
                        foreach (Modulo modulo in turma[n].modulos)
                        {
                            Console.Write("  " + modulo.nome + " Nota: " + modulo.nota + " Estado: ");
                            media += modulo.nota;
                            if (modulo.nota >= 9.5)
                            {
                                Console.WriteLine("Aprovado");
                            }
                            else
                            {
                                Console.WriteLine("Reprovado");
                                reprovado++;
                            }
                        }
                        media = media / turma[n].modulos.Length;
                        reprovado = reprovado / turma[n].modulos.Length * 100;
                        Console.WriteLine("Média: " + media + "\nPercentagem de módulos reprovados:" + reprovado + "%.");
                    }
                }



                //foreach (var aluno in turma )
                //{
                //    Console.WriteLine("Nome do Aluno: {0} ", turma[i].nome );

                //}
                //foreach (var modulo in modulos)
                //{
                //    Console.WriteLine("Nome do módulo: {0} Nota do módulo: {1} ", modulos[m].nome, modulos[m].nota);

                //}

            }




            Console.ReadKey();
        }
    }
}
