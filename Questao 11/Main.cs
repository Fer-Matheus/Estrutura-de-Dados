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

            for (int i = 0; i < 100; i++, a+=1000, b+=1000)
            {
                inicio = DateTime.Now;
                lista.Busca(random.Next(a,b));
                fim = DateTime.Now;
                tempos[i] = fim - inicio;
            }
            TimeSpan acu = TimeSpan.FromSeconds(0);
            foreach (var item in tempos)
            {
                System.Console.WriteLine(item);
                acu+=item;
            }
            System.Console.WriteLine($"Tempo médio: {acu/100}");
        }
    }
