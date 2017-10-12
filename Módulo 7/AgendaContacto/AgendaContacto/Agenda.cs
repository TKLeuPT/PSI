using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AgendaContacto
{
   static class Agenda
    {
        public static List<Contacto> listaContacto = new List<Contacto>();
        static public void AbrirFicheiro()
        {
            string[] ficheiro = File.ReadAllLines("idkDB.txt").ToArray();

            for (int i = 0; i < ficheiro.Length; i++)
            {
                string[] aux = ficheiro[i].Split(',');
                Contacto novo = new Contacto(aux[0], aux[1],aux[2],aux[3],Convert.ToDateTime(aux[4]),aux[5]);
                AddContacto(novo);
            }
        }

        static public void AddContacto(Contacto novo)
        {
            listaContacto.Add(novo);
        }

        static public void GuardarFicheiro()
        {
            string texto = String.Empty;
            foreach (Contacto item in listaContacto)
            {
               texto += ( item.Nome+","+ item.Morada+","+ item.Email+"," +item.Telemovel+","+ item.DataNascimento+","+ item.Foto+"\n");
                File.WriteAllText("idkDB.txt", texto);
            }
            
        }
        static public void Eliminar(int posicao)
        {
            listaContacto.RemoveAt(posicao);
            
        }
    }
}
