using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_IEnum_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "aaa", "bbb", "ccc" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }

            Cars cars = new Cars();
            cars.Add(new Car() { id = 1, Name = "Subaro",km=100 });
            cars.Add(new Car() { id = 2, Name = "Tesla" ,km=200});
            cars.Add(new Car() { id = 3, Name = "Mazda" ,km=23});

            cars.PrintAll();

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Name}.{item.km}");
            }

            //System.IO.Directory.GetFiles()

        }
    }
}
