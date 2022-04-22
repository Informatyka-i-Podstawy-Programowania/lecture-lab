using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotBaseMenu
{
    /// <summary>
    /// Class representing a menu
    /// </summary>
    class Menu
    {
        /// <summary>
        /// 
        /// </summary>
        private List<MenuOption> options;
        int nr = 0;

        public Menu()
        { 
            //options = new List<MenuOption>();
        }

        public void AddOption(string text)
        {
            nr += 1; 
            var option = new MenuOption();
            option.Name = text;
            option.Number = nr;
            options.Add(option);
        }

        public void showMenu()
        {
            options.Add(new MenuOption());
            Console.WriteLine("Choose an option:");
            Console.WriteLine("=================");
            foreach (var opt in options)
                opt.printOption();
        }
    }
}
