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
    public virtual void Insert(No no)
    {
        No aux = First;
        while (aux.Proximo != null)
        {
            aux = aux.Proximo;
        }
        aux.Proximo = no;
    }
    public virtual bool Search(int id)
    {
        No aux = First;
        while (aux != null)
        {
            if (aux.Id == id)
            {
                return true;
            }
            aux = aux.Proximo;
        }
        return false;
    }
    public virtual bool Remove(int id)
    {
        No aux = First;
        while (aux != null)
        {
            if (aux.Id == id && aux.Equals(First))
            {
                First = aux.Proximo;
                aux = null;
                return true;
            }
            else if (aux.Proximo != null && aux.Proximo.Id == id)
            {
                if (aux.Proximo.Proximo != null)
                {
                    No aux2 = aux.Proximo.Proximo;
                    aux.Proximo = null;
                    aux.Proximo = aux2;
                    return true;
                }
                else
                {
                    aux.Proximo = null;
                    return true;
                }
            }
            aux = aux.Proximo;
        }
        return false;
    }
    public virtual void ShowList()
    {
        No aux = First;
        while (aux != null)
        {
            System.Console.WriteLine(aux);
            aux = aux.Proximo;
        }
    }
}
