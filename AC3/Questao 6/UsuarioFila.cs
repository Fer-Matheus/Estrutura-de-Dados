using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class UsuarioFila
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public UsuarioFila(int id = 0, string nome = "Matheus")
    {
        Id = id;
        Nome = nome;
    }
}
