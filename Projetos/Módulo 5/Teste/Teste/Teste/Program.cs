using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    //    Pretende-se um programa para a gestão de cartões de uma discoteca com capacidade para 300 pessoas.






    class Program
    {
        struct Clientes
        {
            //A cada cliente é dado, à entrada, um cartão com um número.Os cartões estão previamente numerados e têm espaço para 10 produtos.

            //Quando um cliente sai, o programa deverá calcular o preço a pagar de todos os seus cartões. 
            //O programa deverá apresentar a descrição do produto e o preço, o total do cartão e total de todos os cartões.

            public int numCartao, numCartoes;

            public Cartoes[] cartoes;
            public Clientes(int numCartao, int numCartoes, Cartoes[] cartoes)
            {
                this.numCartoes = numCartoes;
                this.numCartao = numCartao;
                this.cartoes = cartoes;
            }
        }
        struct Cartoes
        {
            //De cada vez que o cliente consome algum produto é registado no cartão o código do produto.
            public Produtos[] produtos;
            public int numCartao;
            public string codigoPrd;
            public double valorCartao;

            public Cartoes(int numCartao, string codigoPrd, double valorCartao, Produtos[] produtos)
            {
                this.produtos = produtos;
                this.valorCartao = valorCartao;
                this.numCartao = numCartao;
                this.codigoPrd = codigoPrd;
            }
        }
        struct Produtos
        {
            //Nesta discoteca são vendidos produtos registados numa lista previamente definida com o código do produto, a descrição e o preço.
            //É necessário verificar se o código do produto introduzido é valido. 
            //Se o cliente exceder os 10 consumos terá que pedir novo cartão.

            public double preco;
            public string descricao;
            public int codigo;

            public Produtos(double preco, string descricao, int codigo)
            {
                this.preco = preco;
                this.descricao = descricao;
                this.codigo = codigo;
            }
        }

        struct Pagamento
        {
            //No fim do dia todos os cartões são verificados, para isso cada pagamento é guardado num registo com a data, o número e o valor do cartão.
            //Calcula e mostra o valor total do dia.
            public string data;
            public int numCartao;

        }
        static void Main(string[] args)
        {
            Console.Write("Insira o nº de clientes da discoteca: ");
            int numclientes = int.Parse(Console.ReadLine());

            while (numclientes > 300)
            {
                Console.WriteLine("O número máximo de clientes é 300!");
                Console.Write("Insira o número de clientes: ");
                numclientes = int.Parse(Console.ReadLine());
                if (numclientes <= 300)
                    break;
            }

            Clientes[] clientesdisco = new Clientes[numclientes];

            for (int i = 0; i < numclientes; i++)
            {

                Console.Write("Insira o nº de cartões do cliente: ");
                int numcartoes = int.Parse(Console.ReadLine());

                Cartoes[] cartoescli = new Cartoes[numcartoes];
                for (int c = 0; c < numcartoes; c++)
                {
                    Console.Write("Nº do Cartão: ");
                    int numcartao = int.Parse(Console.ReadLine()); // clientesdisco[i].numCartao

                    //while (numcartao == clientesdisco[i].numCartao)
                    //{
                    //    Console.Write("Nº de Cartão já existente! ");
                    //    numcartao = int.Parse(Console.ReadLine());
                    //    if (numcartao != clientesdisco[i].numCartao)
                    //        break;

                    //}

                    Console.Write("Insira o número de produtos a registar: ");
                    int nProdutos = int.Parse(Console.ReadLine());




                    while (nProdutos > 10)
                    {
                        Console.WriteLine("O número máximo de produtos é 10!");
                        Console.Write("Insira o número de produtos a registar: ");
                        nProdutos = int.Parse(Console.ReadLine());
                        if (nProdutos <= 10)
                            break;
                    }


                    Produtos[] produtos = new Produtos[nProdutos];

                    for (int p = 0; p < nProdutos; p++)
                    {


                        Console.WriteLine("Insira o código do produto: ");
                        Console.WriteLine("1. Sumo");
                        Console.WriteLine("2. Cerveja");
                        Console.WriteLine("3. RedBull");
                        Console.WriteLine("4. Tosta");
                        Console.Write("Código do Produto: ");
                        produtos[p].codigo = int.Parse(Console.ReadLine());

                        while (produtos[p].codigo > 4)
                        {
                            Console.WriteLine("Só existem 4 produtos!");
                            Console.WriteLine("Insira o código do produto: ");
                            Console.WriteLine("1. Sumo");
                            Console.WriteLine("2. Cerveja");
                            Console.WriteLine("3. RedBull");
                            Console.WriteLine("4. Tosta");
                            Console.Write("Código do Produto: ");
                            produtos[p].codigo = int.Parse(Console.ReadLine());
                            if (produtos[p].codigo <= 4)
                                break;
                        }

                        switch (produtos[p].codigo)
                        {

                            case 1:
                                do
                                {

                                    produtos[p].descricao = "Sumo";
                                    produtos[p].preco = 1;
                                    Console.WriteLine("Registou um Sumo");
                                    Console.WriteLine("Preço do Sumo: " + produtos[p].preco);
                                    cartoescli[i].valorCartao = cartoescli[i].valorCartao + 1;
                                    break;
                                } while (true);
                                break;

                            case 2:
                                do
                                {
                                    produtos[p].descricao = "Cerveja";
                                    produtos[p].preco = 0.90;
                                    Console.WriteLine("Registou uma Cerveja");
                                    Console.WriteLine("Preço da Cerveja: " + produtos[p].preco);
                                    cartoescli[i].valorCartao = cartoescli[i].valorCartao + 0.90;
                                    break;
                                } while (true);
                                break;

                            case 3:
                                do
                                {
                                    produtos[p].descricao = "RedBull";
                                    produtos[p].preco = 2.50;
                                    Console.WriteLine("Registou um RedBull");
                                    Console.WriteLine("Preço do RedBull: " + produtos[p].preco);
                                    cartoescli[i].valorCartao = cartoescli[i].valorCartao + 2.50;
                                    break;
                                } while (true);
                                break;

                            case 4:
                                do
                                {
                                    produtos[p].descricao = "Tosta";
                                    produtos[p].preco = 2;
                                    Console.WriteLine("Registou uma Tosta");
                                    Console.WriteLine("Preço da Tosta: " + produtos[p].preco);
                                    cartoescli[i].valorCartao = cartoescli[i].valorCartao + 2;
                                    break;
                                } while (true);
                                break;

                        }
                        Console.WriteLine();

                    }
                    clientesdisco[i].cartoes = cartoescli;
                    cartoescli[i].numCartao = numcartao;
                    cartoescli[i].produtos = produtos;
                    for (int pr = 0; pr < produtos.Length; pr++)
                    {
                        Console.WriteLine("Código do Produto: {0} Descrição do Produto: {1} Preço do Produto: {2}", produtos[pr].codigo, produtos[pr].descricao, produtos[pr].preco);
                    }
                   
                    double soma = 0;
                    soma = cartoescli[i].valorCartao;
                    Console.WriteLine("Total dos Cartões: " + soma + "Euros");

                }             
                                  
            }
            Console.ReadKey();
        }
    }
}
