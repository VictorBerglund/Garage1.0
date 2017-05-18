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
        private T[] garage;

        public Garage(int capacity)
        {
            garage = new T[capacity];
            this.capacity = capacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < capacity; i++)
            {
                if(garage[i] != null)
                yield return garage[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool AddToArray(T vehicle)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (garage[i] == null)
                {
                    garage[i] = vehicle;
                    return true;
                }
            }
            return false;
        }

        public void RemoveFromArray(int idxrem)
        {
            int i;
            for ( i= 0; i < capacity && idxrem > 0; i++)
            {
                if (garage[i] != null)
                {
                    idxrem--;
                }
            }
            if(idxrem == 0)
                garage[i - 1] = null;
        }

        public IEnumerable<Vehicle> Search()
        {
            return garage.Where(veh => (veh as Motorcycle)?.CC < 100);
        }
    }
}
