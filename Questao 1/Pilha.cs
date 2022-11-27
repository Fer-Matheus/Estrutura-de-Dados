namespace Codes;
public class Pilha
{
    public int Top { get; set; }
    public Object[] Vetor { get; set; }

    public Pilha(int tamanho)
    {
        Top = -1;
        Vetor = new Object[tamanho];
    }
    public int PosTop()
    {
        return Top;
    }
    public Object ShowTop()
    {
        if (IsEmpty()) return null;
        return Vetor[Top];
    }
    public bool IsEmpty()
    {
        return Top == -1;
    }
    public bool isFull()
    {
        return Top == Vetor.Length - 1;
    }
    public void Push(Object obj)
    {
        if (!isFull())
        {
            Vetor[++Top] = obj;
        }
        else
        {
            System.Console.WriteLine("Pilha cheia!");
        }
    }
    public Object Pop()
    {
        if (!IsEmpty())
        {
            var obj = Vetor[Top];
            Vetor[Top] = null;
            Top--;
            return obj;
        }
        return null;
    }
    public bool Search(Object obj)
    {
        if (!IsEmpty())
        {
            for (int i = Top; i >= 0; i--)
            {
                if (Vetor[i] == obj)
                    return true;
            }
        }
        return false;
    }
    public void Show()
    {
        if (!IsEmpty())
        {
            for (int i = Top; i >= 0; i--)
            {
                System.Console.WriteLine(Vetor[i]);
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Pilha Vazia!");
        }
    }
}

