using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class No
    {
        public string Nome { get; set; }
        public int Idade { get; set;}
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }
        public No Proximo { get; set; }
        public No(int id)
        {
            CEP = id;
        }
    }
}