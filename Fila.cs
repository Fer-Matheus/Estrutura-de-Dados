using System.Text;

namespace Codes;

public class Fila
{
    protected int top, bottom;
    protected Object[] vetor;
    public Fila(int tamanho)
    {
        top = bottom = 0;
        vetor = new Object[tamanho];
    }
    public virtual bool IsEmpty()
    {
        return bottom == top;
    }
    public virtual bool IsFull()
    {
        return bottom == vetor.Length - 1;
    }
    public int PosTop()
    {
        return top;
    }
    public int PosBottom()
    {
        return bottom;
    }
    public Object Top()
    {
        return vetor[top];
    }
    public Object Bottom()
    {
        return vetor[bottom];
    }
    public virtual bool InQueue(Object obj)
    {
        if (!IsFull())
        
        {
            vetor[bottom] = obj;
            bottom++;
            return true;
        }
        return false;
    }
    public virtual Object DeQueue()
    {
        if (!IsEmpty())
        {
            var item = vetor[top];
            top++;
            return item;
        }
        return null;
    }
    public virtual string SearchQueue(Object obj)
    {
        if (!IsEmpty())
        {
            for (int i = top; i != bottom; i++)
            {
                if (vetor[i] == obj)
                    return $"Item: {vetor[i]} encontrado na posição: {i}";
            }
        }
        return $"Item: {obj} não se encontra na fila!";
    }
    public virtual StringBuilder ShowQueue()
    {
        if (!IsEmpty())
        {
            StringBuilder note = new();
            for (int i = top; i != bottom; i++)
            {
                note.AppendLine($"item: {vetor[i]} se encontra na posição: {i} da fila.");
            }
            return note;
        }
        return null;
    }
}