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
            FirstNo = new No(1);
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
            aux.Proximo = new(aux.CEP+1);
        }
        
    }
}