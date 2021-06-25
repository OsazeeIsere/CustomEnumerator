using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Fun with IEnumerable/" +
                "IEnumerator");
            Garage carLot = new Garage();
            //Hand over each car in the collection?
            foreach(Car c in carLot)
            {
                Console.WriteLine("{0} is moving on {1} MPH",c.PetName,c.CurrSpeed);
            }

            //manually work with IEnumerator
            IEnumerator i = carLot.GetEnumerator();
            i.MoveNext();
            Car myCar = (Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH", myCar.PetName, myCar.CurrSpeed);


        }

       
    }
}
