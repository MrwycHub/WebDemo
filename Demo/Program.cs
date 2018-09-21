using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void DoSomething(IMyIf<Animal> returner)
        {
            Console.WriteLine(returner.GetFirst().Name);
        }
        
        static void Main(string[] args)
        {
            #region MyRegion
            //SimpleReturn<Dog> dogReturner = new SimpleReturn<Dog>();
            //dogReturner.items[0] = new Dog { Name = "Avonlea" };
            //IMyIf<Animal> animalReturner = dogReturner;
            //DoSomething(dogReturner); 
            #endregion
            
            Spectrum spectrum = new Spectrum();
           
            foreach (var item in spectrum)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Animal
    {
        public string Name;
    }
    class Dog:Animal
    {

    }
    interface IMyIf<out T>
    {
        T GetFirst();
    }
    class SimpleReturn<T>:IMyIf<T>
    {
        public T[] items = new T[2];
        public T GetFirst() { return items[0]; }
    }

}
