using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class Empilhadeira
    {
        private Pilha pA, pB, pC;

        public Empilhadeira(int tamanho)
        {
            pA = new(tamanho);
            pB = new(tamanho);
            pC = new(tamanho);
        }
        public void RecebeCaixas(Caixa[] caixas)
        {

            foreach (var item in caixas)
            {
                Gerenciar(item);
            }
        }
        public void Organizar()
        {
            Organizando(pB);
            Organizando(pC);
        }


        private void Organizando(Pilha p)
        {
            while (!p.IsEmpty())
            {
                pA.Push(p.Pop());
            }
        }

        private void Gerenciar(Caixa item)
        {
            Caixa aux = (Caixa)pA.ShowTop();
            if (aux == null)
            {
                pA.Push(item);
            }
            else if (item.Peso <= aux.Peso)
            {
                pA.Push(item);
            }
            else
            {
                aux = (Caixa)pA.Pop();
                if (aux.Peso == 10)
                {
                    pB.Push(aux);
                }
                else
                {
                    pC.Push(aux);
                }
                Gerenciar(item);
            }
        }



        public void MostrarPilhas()
        {
            System.Console.WriteLine("Pilha A:");
            pA.Show();
            System.Console.WriteLine("Pilha B:");
            pB.Show();
            System.Console.WriteLine("Pilha C:");
            pC.Show();
        }
    }
}