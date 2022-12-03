using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;
public class App
{
    static void Main(string[] args)
    {
        Usuario[] usuarios = { new(0, 4), new(1, 12), new(2, 20), new(3, 1), new(4, 4), new(5, 1), new(6, 1), };
        FilaCircular fila = new(10);
        foreach (var item in usuarios)
        {
            fila.InQueue(new Ticket(item));
        }
        TimeSpan acu = TimeSpan.Zero;
        System.Console.WriteLine(acu);
        for (int i = 0; i < usuarios.Length; i++)
        {
            Ticket x = (Ticket)fila.DeQueue();
            acu += x.Realizar();
            System.Console.WriteLine(acu);
        }

        System.Console.WriteLine($"Média de espera da fila: {(acu / usuarios.Length)}");
    }
}