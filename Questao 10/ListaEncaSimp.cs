using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class ListaEncaSimp
{
    public No First { get; set; }
    public ListaEncaSimp()
    {
        First = new();
    }
    public void Insert(No no)
    {
        No aux = First;
        while (aux.Proximo != null)
        {
            aux = aux.Proximo;
        }
        aux.Proximo = no;
    }
    public No Search(int id)
    {
        No aux = First;
        while (aux != null)
        {
            if (aux.Id == id)
            {
                return aux;
            }
            aux = aux.Proximo;
        }
        return null;
    }
    public void Remove(No no)
    {
        No aux = First;
        while (aux != null)
        {
            if (aux.Proximo.Equals(no))
            {

                if (aux.Proximo.Proximo != null)
                {
                    No aux2 = aux.Proximo.Proximo;
                    aux.Proximo = null;
                    aux.Proximo = aux2;
                    break;
                }
                else
                {
                    aux.Proximo = null;
                    break;
                }

            }
            aux = aux.Proximo;
        }
    }
    public void ShowList()
    {
        No aux = First;
        while (aux != null)
        {
            System.Console.WriteLine(aux);
            aux = aux.Proximo;
        }
    }
}
