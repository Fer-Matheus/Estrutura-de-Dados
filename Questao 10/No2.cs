using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class No2
    {
        public int Id { get; set; }
        public No2 Proximo { get; set; }
        public No2 Anterior { get; set; }
        public No2(int id = 0)
        {
            Id = id;
            Proximo = null;
            Anterior = null;
        }
        public override string ToString()
        {
            return $"Id: {Id}";
        }
    }
}