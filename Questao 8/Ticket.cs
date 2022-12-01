using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;
public class Ticket
{
    public Usuario Usuario { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Termino { get; set; }

    public Ticket(Usuario usuario)
    {
        Usuario = usuario;
        Inicio = DateTime.Now;
    }
    public TimeSpan Realizar()
    {
        Thread.Sleep(Usuario.TempTrans * 1000);
        Termino = DateTime.Now;
        return Termino - Inicio;
    }
}
