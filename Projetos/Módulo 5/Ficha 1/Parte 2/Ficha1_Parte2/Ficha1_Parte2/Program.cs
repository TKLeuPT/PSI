using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1_Parte2
{
    struct Jogadores
    {
        public int Idade;
        public string Nome, Posicao;

        public Jogadores(int idade, string nome, string posicao)
        {
            Idade = idade;
            Nome = nome;
            Posicao = posicao;
        }
    }
    struct Funcionarios
    {
        public int Idade;
        public string Nome, Funcao;

        public Funcionarios(int idade, string nome, string funcao)
        {
            Idade = idade;
            Nome = nome;
            Funcao = funcao;
        }
    }

    struct Computadores
    {
        public int GBRam, GBDisco;
        public string Processador, GPU;

        public Computadores(int gbram, int gbdisco, string processador, string gpu)
        {
            GBRam = gbram;
            GBDisco = gbdisco;
            Processador = processador;
            GPU = gpu;
        }
    }

    struct Alunos
    {
        //nome, data de nascimento, morada, código postal, telefone
        //public DateTime DataNascimento;
        public int TLF;
        public string Nome, CodPostal, Morada, DataNascimento;

        public Alunos(int tlf, string codpostal, string nome, string morada, string datanascimento)
        {
            TLF = tlf;
            CodPostal = codpostal;
            Nome = nome;
            Morada = morada;
            DataNascimento = datanascimento;


        }
    }

    struct Atletas
    {
        //nome, data de nascimento, morada, código postal, telefone
        //public DateTime DataNascimento;
        public double Peso, Altura;
        public string Nome, Idade;
        //nome, idade, altura e peso
        public Atletas(int peso, string idade, string nome, int altura)
        {
            Peso = peso;
            Nome = nome;
            Idade = idade;
            Altura = altura;



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jogadores j1 = new Jogadores(20, "Antonio", "Avançado");
            Jogadores j2 = new Jogadores(25, "Joaquim", "Defesa");


            Jogadores[] listajogadores = new Jogadores[] { j1, j2 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Jogador " + (i + 1) + ": Nome: " + listajogadores[i].Nome + " Idade: " + listajogadores[i].Idade + " Posição: " + listajogadores[i].Posicao);

            }

            Funcionarios f1 = new Funcionarios(47, "Afonso", "Papelaria");
            Funcionarios f2 = new Funcionarios(50, "Bernardo", "Portaria");


            Funcionarios[] listafuncionarios = new Funcionarios[] { f1, f2 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Funcionario " + (i + 1) + ": Nome: " + listafuncionarios[i].Nome + " Idade: " + listafuncionarios[i].Idade + " Posição: " + listafuncionarios[i].Funcao);

            }

            Computadores pc1 = new Computadores(8, 1000, "I5", "1050 TI 2GB");
            Computadores pc2 = new Computadores(16, 4000, "I7", "1080 TI 8GB");


            Computadores[] listacomputadores = new Computadores[] { pc1, pc2 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Computador " + (i + 1) + ": Processador: " + listacomputadores[i].Processador + " Placa Gráfica: " + listacomputadores[i].GPU + " Disco Rigido: " + listacomputadores[i].GBDisco + "GB" + " Memória RAM: " + listacomputadores[i].GBRam + "GB");

            }

            Alunos a1 = new Alunos(919999999, "2222-222", "Alberto", "Avenida Principal", "21/12/1900");
            Alunos a2 = new Alunos(912345678, "3355-789", "Jertrudes", "Travessa dos Côcos", "12/03/1999");


            Alunos[] listaalunos = new Alunos[] { a1, a2 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Aluno " + (i + 1) + ": Nome: " + listaalunos[i].Nome + " Telefone: " + listaalunos[i].TLF + " Data de Nascimento: " + listaalunos[i].DataNascimento + " Morada: " + listaalunos[i].Morada + " Código Postal: " + listaalunos[i].CodPostal);

            }

            Atletas at1 = new Atletas();

            Console.WriteLine("Insira o Nome do Atleta 1");
            at1.Nome = Console.ReadLine();
            Console.WriteLine("Insira a Idade do Atleta 1");
            at1.Idade = Console.ReadLine();
            Console.WriteLine("Insira o Peso do Atleta 1");
            var pesoinput = Console.ReadLine();
            double.TryParse(pesoinput, out at1.Peso);
            Console.WriteLine("Insira a Altura do Atleta 1");
            var alturainput = Console.ReadLine();
            double.TryParse(alturainput, out at1.Altura);




            Atletas at2 = new Atletas();


            Console.WriteLine("Insira o Nome do Atleta 2");
            at2.Nome = Console.ReadLine();
            Console.WriteLine("Insira a Idade do Atleta 2");
            at2.Idade = Console.ReadLine();
            Console.WriteLine("Insira o Peso do Atleta 2");
            var pesoinput2 = Console.ReadLine();
            double.TryParse(pesoinput2, out at2.Peso);
            Console.WriteLine("Insira a Altura do Atleta 2");
            var alturainput2 = Console.ReadLine();
            double.TryParse(alturainput2, out at2.Altura);


            Atletas[] listatletas = new Atletas[] { at1, at2 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Atleta " + (i + 1) + ": Nome: " + listatletas[i].Nome + " Idade: " + listatletas[i].Idade + " Peso: " + listatletas[i].Peso + " Altura: " + listatletas[i].Altura);

            }

            if (at1.Peso > at2.Peso)
            {
                Console.WriteLine("O "+at1.Nome+" é mais pesado.");
            }
            else Console.WriteLine("O "+at2.Nome+" é mais pesado.");


            if (at1.Altura > at2.Altura)
            {
                Console.WriteLine("O "+ at1.Nome+ " é mais alto.");
            }
            else Console.WriteLine("O "+at2.Nome+" é mais alto.");


            Console.WriteLine("Média das Alturas: " + (Math.Round((at1.Altura + at2.Altura) / 2)));
            Console.WriteLine("Média dos Pesos: " + (Math.Round((at1.Peso + at2.Peso) / 2)));
            Console.ReadKey();
        }
    }
}
