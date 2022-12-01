using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class FilaTicket : FilaCircular
{
    public Ticket[] Fila { get; set; }
    public FilaTicket(int tamanho) : base(tamanho)
    {
        Fila = new Ticket[tamanho];
    }
    public bool InQueue(Ticket obj)
    {
        if (!IsFull())
        {
            Fila[bottom] = obj;
            bottom = (bottom + 1) % vetor.Length;
            qtde++;
            return true;
        }
        return false;
    }
    public override Ticket DeQueue()
    {
        if (!IsEmpty())
        {
            var item = Fila[top];
            top = (top + 1) % vetor.Length;
            qtde--;
            return item;
        }
        return null;
    }
}
