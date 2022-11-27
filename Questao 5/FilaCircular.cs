using System.Text;

namespace Codes;
public class FilaCircular : Fila
{
    private int qtde;
    public FilaCircular(int tamanho) : base(tamanho + 1)
    {
        qtde = 0;
    }
    public override bool IsEmpty()
    {
        return qtde == 0;
    }
    public override bool IsFull()
    {
        return qtde == vetor.Length-1;
    }
    public override bool InQueue(object obj)
    {
        if (!IsFull())
        {
            vetor[bottom] = obj;
            bottom = (bottom + 1) % vetor.Length;
            qtde++;
            return true;
        }
        return false;
    }
    public override object DeQueue()
    {
        if (!IsEmpty())
        {
            var item = vetor[top];
            top = (top + 1) % vetor.Length;
            qtde--;
            return item;
        }
        return null;
    }
    public override string SearchQueue(object obj)
    {
        if (!IsEmpty())
        {
            int aux = top;
            for (int i = top; i != bottom; i = (i + 1) % vetor.Length)
            {

                if (vetor[i] == obj)
                {
                    return $"Item: {obj} na posição: {i} da fila.";
                }
            }
            return $"Item: {obj} não encontrado na fila!";
        }
        return "Fila Vazia!";
    }
    public new void ShowQueue()
    {
        if (!IsEmpty())
        {
            for (int i = top; i != bottom; i = (i + 1) % vetor.Length)
            {
                System.Console.WriteLine($"item: {vetor[i]} se encontra na posição: {i} da fila.");
            }
        }
        else
            System.Console.WriteLine("Fila Vazia!");
    }
}