using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }
        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }
        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }
    }
}