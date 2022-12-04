using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class CalculadoraPolonesaAvançada : CalculadoraPolonesa
    {
        public CalculadoraPolonesaAvançada(int tamanho) : base(tamanho)
        {
        }
        protected override void EscolheOperacao(string item)
        {
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
                case "%":
                    Pilha.Push((op2 / 100) * op1);
                    break;
                case "~":
                    Pilha.Push(op2);
                    Pilha.Push(op1 * -1);
                    break;
                case "l":
                    Pilha.Push(Math.Log(op2, op1));
                    break;
                case "e":
                    Pilha.Push(Math.Exp(op2));
                    Pilha.Push(op1);
                    break;
                case "^":
                    Pilha.Push(1/op2);
                    Pilha.Push(op1);
                    break;
                default:
                    System.Console.WriteLine("Operação não definida!");
                    break;
            }
        }
    }
}