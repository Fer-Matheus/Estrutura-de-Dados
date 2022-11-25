using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codes
{
    public class CalculadoraPolonesa
    {
        public Pilha Pilha { get; set; }
        private double op1, op2;
        private double result;
        public CalculadoraPolonesa(int tamanho)
        {
            Pilha = new(tamanho);
            op1 = op2 = 0;
        }
        public void Insere(string func)
        {
            func = Regex.Replace(func, @"[\()]", "");
            string[] passos = func.Split(" ");
            foreach (var item in passos)
            {
                if (double.TryParse(item.ToString(), out double j))
                {
                    Pilha.Push(j);
                }
                else if (item != "")
                {
                    Action(item);
                }
            }
            result = double.Parse(Pilha.Pop().ToString());
        }
        public double RetornaCalc()
        {
            return result;
        }

        private void Action(string item)
        {
            op1 = double.Parse(Pilha.Pop().ToString());
            op2 = double.Parse(Pilha.Pop().ToString());
            switch (item)
            {
                case "+":
                    Pilha.Push(op2 + op1);
                    break;
                case "-":
                    Pilha.Push(op2 - op1);
                    break;
                case "*":
                    Pilha.Push(op2 * op1);
                    break;
                case "/":
                    Pilha.Push(op2 / op1);
                    break;
                default:
                    System.Console.WriteLine("Operação não definida!");
                    break;
            }
        }
    }
}