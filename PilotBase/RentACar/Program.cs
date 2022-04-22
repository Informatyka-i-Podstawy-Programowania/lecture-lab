using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Chevrolet", "Camarro", "SG 15236", "2022-04-08");
            vehicle.identify(false);
            vehicle.printHistory();
            Console.ReadKey();
        }
    }
}
