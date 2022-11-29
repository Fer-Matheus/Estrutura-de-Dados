using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class Lista
    {
        public No FirstNo { get; set;}

        
        public Lista()
        {
            FirstNo = new No();
        }
        public void adiciona(){
            // No novo = new();
            // novo.Proximo = FirstNo;
            // FirstNo = novo;
            No aux = FirstNo;
            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }
            aux.Proximo = new(aux.Id+1);
        }
        public No Busca(int id){
            No aux = FirstNo;
            while (aux.Proximo != null)
            {
                if (aux.Id == id)
                    return aux;
                aux = aux.Proximo;
            }
            return null;
        }
        public void MostraLista(){
            No aux = FirstNo;
            while (aux != null)
            {
                System.Console.WriteLine(aux);
                aux = aux.Proximo;
            }
        }
    }
}