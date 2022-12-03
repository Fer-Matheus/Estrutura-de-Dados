using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class ListaDuplamenteEncadeadaCircular
    {
        public No2 First { get; set; }
        public No2 Last { get; set; }
        public int Qtde { get; set; }

        public ListaDuplamenteEncadeadaCircular()
        {
            First = null;
            Last = null;
            Qtde = 0;
        }
        public void Insert(No2 no)
        {
            if (First == null)
            {
                no.Anterior = no;
                no.Proximo = no;
                First = no;
                Last = no;
                Qtde++;
            }
            else
            {
                no.Anterior = Last;
                no.Proximo = First;
                Last.Proximo = no;
                Last = no;
                First.Anterior = Last;
                Qtde++;
            }
        }
        public void InsertNaoOrdenado(No2 no, int pos)
        {

            if (First == null)
            {
                no.Anterior = no;
                no.Proximo = no;
                First = no;
                Last = no;
                Qtde++;
            }
            else
            {
                int acu = 1;
                No2 aux = First;
                do
                {
                    if (acu == pos)
                    {
                        break;
                    }
                    aux = aux.Proximo;
                    acu++;

                } while (aux != First);

                No2 aux2 = aux.Proximo;

                no.Proximo = aux2;
                no.Anterior = aux;

                aux.Proximo = no;

                aux2.Anterior = no;
                Qtde++;
            }
        }
        public bool Search(int id)
        {
            No2 aux = First;
            do
            {
                if (aux.Id == id)
                {
                    return true;
                }
                aux = aux.Proximo;
            } while (aux != First);
            return false;
        }
        public bool Remove(int id)
        {
            No2 aux = First;
            do
            {
                if (aux.Id == id)
                {
                    if (aux == First)
                    {
                        No2 aux2 = First.Proximo;
                        First = null;
                        Last.Proximo = aux2;
                        aux2.Anterior = Last;
                        First = aux2;
                        Qtde--;
                        return true;
                    }
                    else if (aux == Last)
                    {
                        No2 aux2 = Last.Anterior;
                        Last = null;
                        aux2.Proximo = First;
                        First.Anterior = aux2;
                        Last = aux2;
                        Qtde--;
                        return true;
                    }
                    else
                    {
                        No2 aux2, aux3;
                        aux2 = aux.Anterior;
                        aux3 = aux.Proximo;
                        aux = null;
                        aux2.Proximo = aux3;
                        aux3.Anterior = aux2;
                        Qtde--;
                        return true;
                    }
                }

                else
                    aux = aux.Proximo;
            } while (aux != First);
            return false;
        }

        public void ShowList()
        {
            if (First != null)
            {
                No2 aux = First;
                do
                {
                    System.Console.WriteLine(aux);
                    aux = aux.Proximo;
                } while (aux != First);
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Lista Vazia!");
            }
        }
        public void DestructList()
        {
            No2 aux = First;
            while (aux.Proximo != First)
            {
                aux = aux.Proximo;
            }
            while (aux != First)
            {
                aux.Proximo = First.Proximo;
                First = null;
                First = aux.Proximo;
            }
            First = null;
            Last = null;
        }
    }
}