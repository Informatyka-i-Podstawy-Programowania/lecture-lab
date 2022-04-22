using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace PilotBase
{
    /// <summary>
    ///    
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param>
        /// </param>
        public static PilotBaseMenu.Menu menu = new PilotBaseMenu.Menu();
        public static PilotBaseMenu.Menu createMenu()
        {
            menu.AddOption("Dodaj pilota");
            menu.AddOption("Lista pilotów");
            menu.AddOption("Usuń pilota");
            return menu;
        }
      
        static void Main(string[] args)
        {
            Pilot p1 = new Pilot("ABC 1524", "Jan", "Kowalski");
            p1.print();
            
            ServiceMan s1 = new ServiceMan("stewardessa", "Anna", "Nowak");
            s1.print();
   
            Console.ReadKey();

            List<Person> persons=new List<Person>();
            persons.Add(p1); //Pilot
            persons.Add(s1); //ServiceMan
            for (int k = 0; k < persons.Count(); k++)
                persons[k].print();
            Console.ReadKey();


            //Program.menu=createMenu();
            Program.menu.AddOption("Dodaj pilota");
            Program.menu.AddOption("Lista pilotów");
            Program.menu.AddOption("Usuń pilota");
            Console.WriteLine("Welcome to Pilot Base Apllication.");
            var menu=new PilotBaseMenu.Menu();
            menu.showMenu();
            Console.ReadKey();
        }
    }
}
