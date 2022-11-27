using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class Embaralhando
    {
        static void Main(string[] args)
        {
            int[] s1 = { 1, 2, 3, 4, 5 };
            int[] s2 = { 6, 7, 8, 9, 10 };

            Pilha p1 = new(5);
            Pilha p2 = new(5);
            Pilha p3 = new(5);
            PushAll(s1, ref p1);
            PushAll(s2, ref p2);

            System.Console.WriteLine("Pilhas antes de embaralhar:");
            System.Console.WriteLine("Pilha 1:");
            p1.Show();
            System.Console.WriteLine("Pilha 2:");
            p2.Show();
            System.Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                p3.Push(p1.Pop());
            }
            for (int i = 0; i < 5; i++)
            {
                p1.Push(p2.Pop());
            }

            System.Console.WriteLine("Pilhas depois de embaralhar:");
            p1.Show();
            System.Console.WriteLine();
            p3.Show();
            System.Console.WriteLine();
        }
        static void PushAll(int[] s1, ref Pilha p1)
        {
            foreach (var item in s1)
            {
                p1.Push(item);
            }
        }
    }
}