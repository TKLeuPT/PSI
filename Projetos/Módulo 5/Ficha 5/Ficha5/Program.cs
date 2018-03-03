using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5
{
    class Program
    {
        struct Funcionarios
        {
            public int numfuncionario;
            public string nome;
            public double salario;

            public Funcionarios(string nome, double salario, int numfuncionario)
            {
                this.nome = nome;
                this.salario = salario;
                this.numfuncionario = numfuncionario;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Insira o nº de funcionários a registar: ");
            int numfuncionarios = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Funcionarios[] funcionario = new Funcionarios[numfuncionarios];

            for (int i = 0; i < numfuncionarios; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Nº de Funcionário: ");
                int numfuncionario = int.Parse(Console.ReadLine());

                Funcionarios novofuncionario = new Funcionarios(nome, salario,numfuncionario);
                funcionario[i] = novofuncionario;
            }

            Console.WriteLine();

            Console.WriteLine("Funcionários Ordenados: ");
            
            foreach (Funcionarios func in funcionario.OrderBy(x=>x.numfuncionario))
            {
                Console.WriteLine("Nº de Funcionário: {0} Nome: {1} Salário: {2} ", func.numfuncionario, func.nome, func.salario);
            }

            Console.WriteLine();
            Console.Write("Insira o nº de funcionário a procurar: ");
            int procurarnum = int.Parse( Console.ReadLine());
            for (int i = 0; i < funcionario.Length; i++)
            {
                if (procurarnum == funcionario[i].numfuncionario)
                {
                    Console.WriteLine("Nº de Funcionário: {0} Nome: {1} Salário: {2} ", funcionario[i].numfuncionario, funcionario[i].nome, funcionario[i].salario);
                }


            }

            Console.WriteLine();
            double total = 0;
            double media = 0;
            for (int i = 0; i < funcionario.Length; i++)

            {

                total += funcionario[i].salario;

            }

            media = total / funcionario.Length;

            foreach (Funcionarios func in funcionario.OrderBy(x=>x.salario))
            {
                if (func.salario > 1000)
                {
                    Console.WriteLine("Funcionários com o salário acima de 1000€:");
                    Console.WriteLine("Nº de Funcionário: {0} Nome: {1} Salário: {2} ", func.numfuncionario, func.nome, func.salario);
                    Console.WriteLine();
                }
                if (func.salario < 500)
                {
                    Console.WriteLine("Funcionários com o salário abaixo de 500€:");
                    Console.WriteLine("Nº de Funcionário: {0} Nome: {1} Salário: {2} ", func.numfuncionario, func.nome, func.salario);
                    Console.WriteLine();
                }
               
                if (func.salario > media)
                {
                    Console.WriteLine("Funcionários com o salário acima da média de salários:");
                    Console.WriteLine("Nº de Funcionário: {0} Nome: {1} Salário: {2} ", func.numfuncionario, func.nome, func.salario);
                    Console.WriteLine();
                }


            }

            Console.ReadKey();
        }
    }
}
