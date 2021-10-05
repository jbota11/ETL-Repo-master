using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public abstract class Animal : IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public abstract void Talk();
        public abstract void Run();
    }
}
