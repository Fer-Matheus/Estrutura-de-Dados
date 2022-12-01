using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class Lista
    {
        public Record FirstNo { get; set; }


        public Lista()
        {
            FirstNo = new Record();
        }
        public void adiciona()
        {
            Record aux = FirstNo;
            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }
            aux.Proximo = new(aux.Id + 1);
        }
        public Record Busca(int id)
        {
            Record aux = FirstNo;
            while (aux != null)
            {
                if (aux.Id == id)
                    return aux;
                aux = aux.Proximo;
            }
            return null;
        }
        public void MostraLista()
        {
            Record aux = FirstNo;
            while (aux != null)
            {
                System.Console.WriteLine(aux);
                aux = aux.Proximo;
            }
        }
    }
}