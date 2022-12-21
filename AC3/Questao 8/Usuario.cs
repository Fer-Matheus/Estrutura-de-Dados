using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class Usuario
{
    public int Id { get; set; }
    public int TempTrans { get; set; }

    public Usuario(int id, int tempTrans)
    {
        Id = id;
        TempTrans = tempTrans;
    }
}
