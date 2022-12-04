using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class ListaEncadeadaSimplesOrdenaTambem : ListaEncadeadaSimples
{
    public ListaEncadeadaSimplesOrdenaTambem(int id = 0) : base(id)
    {

    }
    public virtual void Insert(No no)
    {
        if (First == null)
        {
            First = no;
        }
        else
        {
            No aux = First;
            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }
            aux.Proximo = no;
        }

    }
}
