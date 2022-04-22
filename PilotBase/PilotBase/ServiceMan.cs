using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotBase
{
    class ServiceMan : Person
    {
        private string position;

        public ServiceMan(string position, string name, string surname)
        {
            this.position = position;
            this.name = name;
            this.surname = surname;
        }

        public string Position { get => position; set => position = value; }

        public override void print()
        {
            Console.WriteLine("Zalogant: " + name + " " + surname + " stanowisko: " + position);
        }
    }
}
