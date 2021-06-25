using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CustomEnumerator
{
    //garage contains a set of cars
   public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        //fill with some car objects upon startup
        public Garage()
        {
            carArray[0] = new Car("Bitto", 80);
            carArray[1] = new Car("Brus", 40);
            carArray[2] = new Car("Big for nothing", 70);
            carArray[3] = new Car("Pencil Light", 60);
        }

        public IEnumerator GetEnumerator()
        {
            //return the array object's IEnumerator
            return carArray.GetEnumerator();
        }
    }
}
