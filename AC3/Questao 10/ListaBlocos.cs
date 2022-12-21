using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class ListaBlocos : ListaEncadeadaSimplesOrdenaTambem
{
    private new Bloco First { get; set; }
    public ListaBlocos()
    {

    }
    public void InsertBlock(Bloco bloco)
    {
        if (First == null)
        {
            First = bloco;
            // First.Proximo = null;
        }
        else
        {
            Bloco aux = First;
            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }
            aux.Proximo = bloco;
        }
    }
    public bool InsertNo(int id, No no)
    {
        if (First != null)
        {
            Bloco aux = First;
            do
            {
                if (aux.Id == id)
                {
                    return aux.Nos.InQueue(no);
                }
                aux = aux.Proximo;
            } while (aux != null);
            return false;
        }
        return false;
    }
    public string SearchBlock(int id)
    {
        if (First != null)
        {
            int acu = 0;
            Bloco aux = First;
            do
            {

                if (aux.Id == id)
                {
                    return $"Bloco encontrado na posição: {acu} da lista.";
                }
                acu++;
                aux = aux.Proximo;
            } while (aux != null);
        }
        return "Nenhum bloco com esse id foi encontrado!";
    }
    public string SearchBlockNo(int id, int idNo)
    {
        if (First != null)
        {
            int acu = 0;
            Bloco aux = First;
            do
            {
                if (aux.Id == id)
                {
                    return $"{aux.Nos.SearchQueueNo(idNo)}.\nNo bloco de id: {aux.Id}, na posição: {acu} da lista.";
                }
                acu++;
                aux = aux.Proximo;
            } while (aux != null);
        }
        return "Item não encontrado no bloco.";
    }
    public void ShowListBlock()
    {
        if (First != null)
        {
            Bloco aux = First;
            do
            {
                System.Console.WriteLine(aux);
                aux = aux.Proximo;
            } while (aux != null);
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Lista vazia!");
            System.Console.WriteLine();
        }
    }
    public void ShowListBlockNo()
    {
        if (First != null)
        {
            Bloco aux = First;
            while (aux != null)
            {
                System.Console.WriteLine($"Item do Bloco de Id: {aux.Id}");
                aux.Nos.ShowQueue();
                aux = aux.Proximo;
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Lista vazia!");
            System.Console.WriteLine();
        }
    }

}
