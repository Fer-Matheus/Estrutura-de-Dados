using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codes
{
    public class No
    {
        public int Id { get; set; }
        public No Proximo { get; set; }
        public No(int id = 0)
        {
            Id = id;
            Proximo = null;
        }
        public override string ToString()
        {
            return $"Id: {Id}";
        }
    }
}