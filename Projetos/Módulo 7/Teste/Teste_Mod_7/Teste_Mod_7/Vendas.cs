using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Mod_7
{
    static class Vendas
    {
         public static List<Venda> listaVendas = new List<Venda>();
        static public void AbrirFicheiro()
        {
            string[] ficheiro = File.ReadAllLines("vendas.txt").ToArray();

            for (int i = 0; i < ficheiro.Length; i++)
            {
                string[] aux = ficheiro[i].Split(',');
                Venda novo = new Venda(aux[0], int.Parse(aux[1]), Convert.ToDateTime(aux[2]));
                AddVenda(novo);
            }
        }

        static public void AddVenda(Venda novo)
        {
            listaVendas.Add(novo);
        }

        static public void GuardarFicheiro()
        {
            string texto = String.Empty;
            foreach (Venda item in listaVendas)
            {
                texto += (item.DataVenda.ToShortDateString() + "," + item.Pizza + "," + item.Qtd + "\n");
                File.WriteAllText("vendas.txt", texto);
            }

        }
        static public void Eliminar(int posicao)
        {
            listaVendas.RemoveAt(posicao);

        }
    }
}
