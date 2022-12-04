using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class ListaEncadeadaSimplesCircular : ListaEncadeadaSimplesOrdenaTambem
{
    public No Last { get; set; }
    public ListaEncadeadaSimplesCircular()
    {
        First = null;
        Last = null;
    }
    public override void Insert(No no)
    {
        if (First == null)
        {
            First = no;
            Last = no;
            Last.Proximo = First;
        }
        else
        {
            Last.Proximo = no;
            Last = no;
            Last.Proximo = First;
        }
    }
    public override void InsertNaoOrdenado(No no, int pos)
    {
        No aux = First;
        do
        {
            if(aux.Id == pos){
                break;
            }
        } while (aux.Proximo != First);
        No aux2 = aux.Proximo;
        aux.Proximo = no;
        no.Proximo = aux2;
    }

    public override No Search(int id)
    {
        No aux = First;
        do
        {
            if (aux.Id == id)
            {
                return aux;
            }
            aux = aux.Proximo;
        } while (aux != First);
        return null;
    }
    public override bool Remove(int id)
    {
        No aux = First;
        if (aux.Id == id)
        {
            First = aux.Proximo;
            aux = null;
            Last.Proximo = First;
            return true;
        }
        do
        {
            if (aux.Proximo.Id == id)
            {

                No aux2 = aux.Proximo.Proximo;
                aux.Proximo = null;
                aux.Proximo = aux2;
                if (aux2 == First)
                {
                    Last = aux;
                }
                return true;

            }
            aux = aux.Proximo;
        } while (aux.Proximo != First);
        return false;
    }
    public override void ShowList()
    {
        if (First != null)
        {
            No aux = First;
            do
            {
                System.Console.WriteLine(aux);
                aux = aux.Proximo;
            } while (aux != First);
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Lista está vazia!");
        }
    }
    public void DestructListCirc()
    {
        if (First != null)
        {
            No aux = First;
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
