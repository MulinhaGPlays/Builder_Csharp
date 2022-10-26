using Builder.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Domain
{
    public class Meal : IMealCompositeProtocol, IMealModelProtocol
    {
        public string name { get; set; }
        public int number { get; set; }

        public Meal(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public int GetPrice()
        {
            return this.number;
        }
    }
}
