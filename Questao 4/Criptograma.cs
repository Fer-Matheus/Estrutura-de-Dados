using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class Criptograma
{
    private Pilha pPequena, pGrande;
    private string code;

    public Criptograma(int tamanho)
    {

        pGrande = new(tamanho / 2);
        pPequena = new(tamanho / 4);
    }
    public string Codifica(string[] mensagem)
    {
        EsvaziarPilha(ref pPequena);
        EsvaziarPilha(ref pGrande);
        code = "";
        foreach (var item in mensagem)
        {
            if (pPequena.isFull())
            {
                Esvaziar(ref pPequena, ref code);
            }
            if (pGrande.isFull())
            {
                Esvaziar(ref pGrande, ref code);
            }
            pPequena.Push(item);
            pGrande.Push(item);
        }
        Esvaziar(ref pGrande, ref code);
        return code;
    }
    public string Decodificar(string[] mensagem)
    {
        EsvaziarPilha(ref pPequena);
        EsvaziarPilha(ref pGrande);
        code = "";
        foreach (var item in mensagem)
        {
            if (pPequena.isFull())
            {
                Esvaziar(ref pPequena, ref code);
            }
            if (pGrande.isFull())
            {
                EsvaziarPilha(ref pGrande);
            }
            pPequena.Push(item);
            pGrande.Push(item);
        }
        return code;
    }

    private void EsvaziarPilha(ref Pilha p)
    {
        while (!p.IsEmpty())
        {
            p.Pop();
        }
    }

    private void Esvaziar(ref Pilha p, ref string code)
    {
        while (!p.IsEmpty())
        {
            code += " " + p.Pop().ToString();
        }
    }
}
