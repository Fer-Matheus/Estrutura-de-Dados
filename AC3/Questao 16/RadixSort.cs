using System.Text;
using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class RadixSort
    {
        public ListRadix[] Listas { get; set; }
        public int Max { get; set; }
        private List<string> dadosCru, dadosMeio;
        private List<string> dadosHexa;

        public RadixSort()
        {
            Listas = new ListRadix[128];
            dadosCru = new();
            dadosMeio = new();
            dadosHexa = new();
            Max = 0;
        }
        private void IniciarListas(int intervalo)
        {
            foreach (var item in dadosHexa)
            {
                int a = Max - intervalo * 2;
                int b = Max - intervalo * 2 + 1;
                if (Listas[Int16.Parse((item[a]) + "" + item[b])] == null)
                {
                    Listas[Int16.Parse(item[a] + "" + item[b])] = new(new(item));
                }
                else
                {
                    Listas[Int16.Parse(item[a] + "" + item[b])].Insert(new(item));
                }
            }
        }
        public void RecebeDados(string[] dado)
        {
            foreach (var item in dado)
            {
                dadosCru.Add(item);
            }
            PreencheListHexa();
        }
        public void Sort()
        {
            for (int i = 1; i <= Max / 2; i++)
            {
                IniciarListas(i);
                int pos = 0;
                for (int j = 0; j < 128; j++)
                {
                    while (Listas[j] != null && Listas[j].First != null)
                    {
                        dadosHexa.Insert(pos, Listas[j].RemoveFirst().Nome);
                        pos++;
                    }
                }
            }
        }
        public void ShowSort()
        {
            foreach (var item in dadosHexa)
            {
                string result = "";
                for (int i = 1; i <= (item.Length - 1) / 2; i++)
                {
                    if (item[i * 2 - 1] == '0' && item[i * 2] == '0')
                    {
                        continue;
                    }
                    result += Char.ToString(item[i * 2 - 1]) + Char.ToString(item[i * 2]);
                }
                string output = "";
                char[] vetor = result.ToCharArray();
                for (int i = 0; i < vetor.Length; i += 2)
                {
                    string aux = "" + vetor[i] + "" + vetor[i + 1];
                    char c = (char)int.Parse(aux);
                    output += c;
                }
                System.Console.WriteLine(output);
            }
        }
        public string ConverteEmHexa(string item)
        {
            Byte[] bytes = Encoding.Default.GetBytes(item);
            string hexa = BitConverter.ToString(bytes);
            hexa = hexa.Replace("-", "");
            if (hexa.Length > Max)
            {
                Max = hexa.Length;
            }
            return hexa;
        }
        private void PreencheListHexa()
        {
            foreach (var item in dadosCru)
            {
                dadosMeio.Add(ConverteEmHexa(item));
            }
            foreach (var item in dadosMeio)
            {
                string aux = item;
                for (int i = 0; i < Max - item.Length; i++)
                {
                    aux += 0;
                }
                dadosHexa.Add("0" + aux.ToUpper());
            }
            dadosMeio = null;
        }
        public void Show()
        {
            foreach (var item in dadosHexa)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}