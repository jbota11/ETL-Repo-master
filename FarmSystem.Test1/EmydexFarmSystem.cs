using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private List<IAnimal> _animals = new List<IAnimal>();
        public delegate void FarmEmpty();
        public event FarmEmpty FarmIsEmpty;

        //TEST 1
        public void Enter(IAnimal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            string typeAnimal = animal.GetType().Name;
            Console.WriteLine("{0} has entered the farm", typeAnimal);
            _animals.Add(animal);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk

            if (_animals.Count > 0)
            {
                foreach (var animal in _animals)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
                return;
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            List<IMilkableAnimal> milkAnimals = _animals.OfType<IMilkableAnimal>().ToList();

            if (milkAnimals.Count > 0)
            {
                foreach (IMilkableAnimal animal in milkAnimals)
                {
                    animal.ProduceMilk();
                }
            }
            else
                Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (var animal in _animals)
            {
                string typeAnimal = animal.GetType().Name;
                Console.WriteLine("{0} has left the farm", typeAnimal);
            }

            _animals.Clear();

            FarmIsEmpty.Invoke();

            //Console.WriteLine("There are still animals in the farm, farm is not free"); -- UNNECESSARY
        }
    }
}