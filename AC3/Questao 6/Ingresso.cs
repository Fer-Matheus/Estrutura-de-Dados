using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codes;

namespace Codes;

public class Ingresso
{
    public int Id { get; set; }
    public UsuarioFila Usuario { get; set; }
    public Ingresso(UsuarioFila usuario, int id = 0)
    {
        Id = id;
        Usuario = usuario;
    }
}
