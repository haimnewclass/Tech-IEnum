using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_IEnum_Console
{
    internal class Cars:IEnumerable<Car>, IEnumerator<Car>
    {

        public IEnumerator<Car> GetEnumerator()
        {
            return this;
        }


        private List<Car> cars = new List<Car>();

        private int _idx = -1;
  
        public void Add(Car c)
        {
            cars.Add(c);
        }

        public void PrintAll()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine($"{c.id}.{c.Name}.{c.Description}");
            }
        }

        public void Dispose()
        {
           Reset();
        }

        public Car Current
        {
            // idx = 0
            //"subaro","Volvo","Mazda"
            get
            {
                if(cars[_idx].km==0)
                {
                    return null;
                }

                return cars[_idx];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {  //"subaro","Volvo","Mazda"
            _idx++;
            if (cars.Count <= _idx)
            {
                return false;
            }else
            {
                return true;
            }
        }

        public void Reset()
        {
            _idx = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
