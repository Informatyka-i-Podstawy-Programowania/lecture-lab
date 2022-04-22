using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_RPG
{
    class Person
    {
        private string name = "";
        private string surname = "";
        private List<string> story =new List<string>();
        private int power;
        private int magic;
        private int strength;
        private int health;

        public Person(string name, string surname, string bornDate)
        {
            this.name = name;
            this.surname = surname;
            story.Add(name + " " + surname + " has born at "+bornDate);
        }

        public void whatsYourName()
        {
            Console.WriteLine("My name is " + surname + ".");
            Console.WriteLine(name + " " + surname + ".");
        }

        public void tellMeYourStory()
        {
            Console.WriteLine("My epic story:");
        }
        public string Name { get => name; }
        public string Surname { get => surname; }
        public int Power { get => power;}
        public int Magic { get => magic;}
        public int Strength { get => strength;}
        public int Health { get => health; set => health = value; }
        
    }
}
