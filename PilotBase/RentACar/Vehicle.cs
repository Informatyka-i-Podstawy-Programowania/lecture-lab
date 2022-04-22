using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class Vehicle
    {
        private string mark;
        private string model;
        private string regNr;
        private string startRent;
        private string endRent;
        private int km;
        private List<string> history = new List<string>();

        public Vehicle(string mark, string model, string regNr, string date)
        {
            this.mark = mark;
            this.model = model;
            this.regNr = regNr;
            startRent = "Not rent yet!";
            history.Add("The car was bought at "+date);
        }

        public void identify(bool withRegNr=true)
        {
            Console.Write(mark + " " + model);
            if (withRegNr)
                Console.WriteLine(" " + regNr);
            else
                Console.WriteLine(" ");
        }

        public void printHistory()
        {

        }

        public string Mark { get => mark;}
        public string Model { get => model;}
        public string RegNr { get => regNr;}
        public string StartRent { get => startRent; set => startRent = value; }
        public string EndRent { get => endRent; set => endRent = value; }
        public int Km { get => km; set => km = value; }
    }
}
