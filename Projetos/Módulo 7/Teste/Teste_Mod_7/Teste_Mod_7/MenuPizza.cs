using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste_Mod_7
{
    static class MenuPizza
    {
        public static List<Pizza> listaPizzas = new List<Pizza>();
        static public void AbrirFicheiro()
        {
            string[] ficheiro = File.ReadAllLines("pizzas.txt").ToArray();

            for (int i = 0; i < ficheiro.Length; i++)
            {
                string[] aux = ficheiro[i].Split(',');
                //nome,ingrediente1,ingrediente2,ingrediente3,ingrediente4,ingrediente5
                Pizza novo = new Pizza(aux[0], aux[1], aux[2], aux[3], aux[5], aux[6], aux[7]);
                AddPizza(novo);
            }
        }

        static public void AddPizza(Pizza novo)
        {
            listaPizzas.Add(novo);
        }

        static public void GuardarFicheiro()
        {
            string texto = String.Empty;
            foreach (Pizza item in listaPizzas)
            {
                texto += (item.Nome + "," + item.Ingrediente1 + "," + item.Ingrediente2 + "," + item.Ingrediente3 + "," + item.Ingrediente4 +","+ item.Ingrediente5 + "," + item.Foto + "\n");
                File.WriteAllText("pizzas.txt", texto);
            }

        }
        static public void Eliminar(int posicao)
        {
            listaPizzas.RemoveAt(posicao);

        }
    }
}
