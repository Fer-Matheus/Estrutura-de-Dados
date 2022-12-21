using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class Bloco // Tratarei os blocos com estrutura de filas circulares
    {
        public int Id { get; set; }
        public FilaCircular Nos { get; set; }
        public Bloco Proximo { get; set; }
        public Bloco(int id, int tamanho)
        {
            Id = id;
            Nos = new(tamanho);
            Proximo = null;
        }
        public override string ToString()
        {
            return $"Bloco de id: {Id}";
        }
    }
}