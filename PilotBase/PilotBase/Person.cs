using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotBase
{
    abstract class Person
    {
        protected string name;
        protected string surname;
        protected Person()
        {}
        protected Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public abstract void print();
    }
}
