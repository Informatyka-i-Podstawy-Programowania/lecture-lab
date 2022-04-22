using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotBase
{
    class Pilot : Person
    {
        private string licenceNr;

        public Pilot(string licenceNr, string name, string surname)
        {
            this.name = name; 
            this.surname=surname;
            this.licenceNr = licenceNr;
        }

        public override void print()
        {
            Console.WriteLine("Pilot: "+name+" "+surname+" nr licencji: "+licenceNr);
        }
    }
}
