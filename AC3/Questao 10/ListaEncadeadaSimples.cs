namespace Codes;

public class ListaEncadeadaSimples
{
    public int Id { get; set; }
    public No First { get; set; }
    public ListaEncadeadaSimples(int id = 0)
    {
        Id = id;
        First = null;
    }
    public virtual void InsertNaoOrdenado(No no, int pos)
    {
        if (First == null)
        {
            First = no;
        }
        else
        {
            No aux = First;
            while (aux != null)
            {
                if (aux.Id == pos)
                {
                    break;
                }
                aux = aux.Proximo;
            }
            if (aux == null)
            {
                System.Console.WriteLine("Posição informada não existe na lista!");
            }
            else
            {
                No aux2 = aux.Proximo;
                aux.Proximo = no;
                no.Proximo = aux2;
            }
        }

    }
    public virtual No Search(int id)
    {
        No aux = First;
        while (aux != null)
        {
            if (aux.Id == id)
            {
                return aux;
            }
            aux = aux.Proximo;
        }
        return null;
    }
    public virtual bool Remove(int id)
    {
        No aux = First;
        while (aux != null)
        {
            if (aux.Id == id && aux.Equals(First))
            {
                First = aux.Proximo;
                aux = null;
                return true;
            }
            else if (aux.Proximo != null && aux.Proximo.Id == id)
            {
                if (aux.Proximo.Proximo != null)
                {
                    No aux2 = aux.Proximo.Proximo;
                    aux.Proximo = null;
                    aux.Proximo = aux2;
                    return true;
                }
                else
                {
                    aux.Proximo = null;
                    return true;
                }
            }
            aux = aux.Proximo;
        }
        return false;
    }
    public No RemoveFirst(){
        No aux = First;
        First = First.Proximo;
        return aux;
    }
    public virtual void ShowList()
    {
        if (First != null)
        {
            No aux = First;
            while (aux != null)
            {
                System.Console.WriteLine(aux);
                aux = aux.Proximo;
            }
        }
        else
        {
            System.Console.WriteLine("Lista Vazia!");
        }

    }
    public virtual void DestructList()
    {
        No aux = First;
        while (First != null)
        {
            aux = First.Proximo;
            First = null;
            First = aux;
        }
    }
}
