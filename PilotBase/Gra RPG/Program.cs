using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("John", "Smith", "1536-01-12");
            Console.WriteLine("What's your name?");
            person.whatsYourName();
            Console.WriteLine("Tell me your story");
            person.tellMeYourStory();
            Console.ReadKey();
        }
    }
}
