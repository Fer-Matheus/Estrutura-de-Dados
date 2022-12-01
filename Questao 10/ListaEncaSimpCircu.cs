using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class ListaEncaSimpCircu : ListaEncaSimp
{
    public No Last { get; set; }
    public ListaEncaSimpCircu() : base()
    {
        Last = First;
    }
}
