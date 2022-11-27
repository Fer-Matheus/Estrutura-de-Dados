using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public static class Sort
{
    public static int[] RadixSort(int[] elementos, string baseSort)
    {
        int[] vetor;
        string[] vetorBase;
        if (baseSort.ToUpper() == "DECIMAL")
        {
            vetor = new int[10];
            vetorBase = TransformaBaseDecimal(elementos);
        }
        else
        {
            vetor = new int[2];
            vetorBase = TransformaBaseBinaria(elementos);
        }

        return vetor;
    }

    private static string[] TransformaBaseBinaria(int[] elementos)
    {
        string[] convertido = new string[elementos.Length];
        for (int i = 0; i < elementos.Length; i++)
        {
            convertido[i] = decimalToBinario(elementos[i]);
        }
        return convertido;
    }

    private static string decimalToBinario(int elemento)
    {
        string binario = null;
        while (elemento != 1)
        {
            string teste = (elemento % 2).ToString();
            binario += teste;
            elemento = elemento / 2;
        }
        binario = "1" + binario;
        return binario;
    }

    private static string[] TransformaBaseDecimal(int[] elementos)
    {
        string[] convertido = new string[elementos.Length];
        for (int i = 0; i < elementos.Length; i++)
        {
            convertido[i] = "0" + elementos[i].ToString();
        }
        return convertido;
    }
    
}