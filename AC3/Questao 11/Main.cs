using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes;

public class main
{
    static void Main(string[] args)
    {
        Lista lista = new();
        Random random = new();

        for (int i = 0; i < 100000; i++)
        {
            lista.adiciona();
        }
        TimeSpan[] tempos = new TimeSpan[100];
        DateTime inicio, fim;
        int a = 1, b = 1000;

        for (int i = 0; i < 100; i++, a += 1000, b += 1000)
        {
            inicio = DateTime.Now;
            for (int j = 0; j < 100; j++)
            {
                lista.Busca(random.Next(a, b));
            }
            fim = DateTime.Now;
            tempos[i] = fim - inicio;
            System.Console.WriteLine(a + " - " + b);
        }
        TimeSpan acu = TimeSpan.FromSeconds(0);
        foreach (var item in tempos)
        {
            System.Console.WriteLine(item.Milliseconds);
            acu += item;
        }
        File.WriteAllLines("C:\\workspace\\CSharpProjects\\Estrutura-de-dados\\Questao 11\\dados.cvs", tempos.Select(item => item.Milliseconds.ToString()));
        System.Console.WriteLine($"Tempo médio: {acu / 100}");
    }
}
