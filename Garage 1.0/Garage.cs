using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{

    class Garage<T> : IEnumerable<T> where T : Vehicle
    {
         public  int capacity = 0;

        public Garage(int capacity)
        {
            T[] garage = new T[capacity];
            this.capacity = capacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < capacity; i++)
            {
                yield return null;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddCar()
        {
            Car nCar = new Car();
        }
    }
}
