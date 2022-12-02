using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class ListaEncaSimpCircu : ListaEncaSimp
{
    public No Last { get; set; }
    public ListaEncaSimpCircu()
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
            no.Proximo = First;
        }
    }
    
    public override bool Search(int id)
    {
        No aux = First;
        while (aux != Last)
        {
            if (aux.Id == id)
            {
                return true;
            }
            aux = aux.Proximo;
        }
        return false;
    }
    public override void ShowList()
    {
        No aux = First;
        while (aux != Last)
        {
            System.Console.WriteLine(aux);
            aux = aux.Proximo;
        }
    }
}
