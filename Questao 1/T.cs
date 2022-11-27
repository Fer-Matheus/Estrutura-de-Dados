using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class T
{
    public int Indice { get; set; }
    public string AlfaNum1 { get; set; }
    public string AlfaNum2 { get; set; }
    public T(int id, string x, string y)
    {
        Indice = id;
        AlfaNum1 = x;
        AlfaNum2 = y;
    }
    public override string ToString()
    {
        return $" Indice: {Indice}, AlfaNum1: {AlfaNum1}, Alfanum2: {AlfaNum2}";
    }
}
