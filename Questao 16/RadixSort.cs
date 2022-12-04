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
        public ListaEncadeadaSimplesOrdenaTambem[] Listas { get; set; }
        public int Max { get; set; }
        private List<string> dadosCru, dadosMeio;
        private List<string> dadosHexa;

        public RadixSort()
        {
            Listas = new ListaEncadeadaSimplesOrdenaTambem[16];
            dadosCru = new();
            dadosMeio = new();
            dadosHexa = new();
            Max = 0;
            IniciarListas();
        }
        private void IniciarListas()
        {
            for (int i = 0; i < Listas.Length; i++)
            {
                Listas[i] = new(i);
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
        public string Sort()
        {
            
            return "";
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
                dadosHexa.Add("0" + aux);
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