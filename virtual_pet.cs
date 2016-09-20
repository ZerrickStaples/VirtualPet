using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class virtual_pet
    {
        //fields
        public string Name;
        public int Health;
        public int Hunger;
        public int Thirst;
        public int Waste;

        //properties
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int health
        {
            get { return this.Health; }
            set { this.Health = hunger + thirst + waste; }
        }

        public int hunger
        {
            get { return this.Hunger; }
            set { this.Hunger = 20; }
        }

        public int thirst
        {
            get { return this.Thirst; }
            set { this.Thirst = 20; }
        }

        public int waste
        {
            get { return this.Waste; }
            set { this.Waste = 20; }
        }

        //constructors
        public virtual_pet()
        {

        }

        public virtual_pet(String Name, int Health, int Hunger, int Thirst, int Waste)
        {
            this.Name = Name;
            this.Health = Hunger + Thirst + Waste;
            this.Hunger = Hunger;
            this.Thirst = Thirst;
            this.Waste = Waste;


        }

        //Methods


        public void Tick(int answer)
        {
            Hunger--; Thirst--; Waste--;
            Health = Hunger + Thirst + Waste;

            bool quit = false;

            //setting value for input.
            if (answer == 1)
            {
                hunger += 5;
                thirst -= 3;
                waste -= 2;
            }
            else if (answer == 2)
            {
                thirst += 4;
                waste -= 2;
            }

            else if (answer == 3)
            {
                hunger -= 2;
                thirst -= 2;
                waste += 2;
            }

            else if (answer == 4)
            {
                hunger -= 3;
                thirst -= 3;
                waste += 6;
            }
            else
            {
                quit = true;
            }
        }


        public void PrintAllDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append(" \nHealth: ");
            sb.Append(health);
            sb.Append("\nHunger: ");
            sb.Append(hunger);
            sb.Append("\nThirst: ");
            sb.Append(thirst);
            sb.Append("\nWaste: ");
            sb.Append(waste);
            sb.Append("");

            Console.WriteLine(sb.ToString());
                { } }            

        public void Feed()
        {
            hunger += 5;
            thirst -= 3;
            waste -= 2;
        }

        public void Drink()
        {
            thirst += 4;
            waste -= 2;
        }
        public void Play()
        {
            hunger -= 2;
            thirst -= 2;
            waste += 2;
        }
        public void Relieve()
        {
            hunger -= 3;
            thirst -= 3;
            waste += 6;
        }
    }
}
