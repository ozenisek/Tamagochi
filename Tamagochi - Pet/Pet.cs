using Pet;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Pet

{
    public abstract class Pett
    {
        private int hunger = 50;
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;

                if (!IsAlive())
                {
                    throw new DeadPetException();
                }
            }
        }
        private Random random = new Random();
        public int Do()
        {
            var toss = random.Next(0, 20);
            Console.WriteLine(toss);
            if (toss < 10)
            {
                Chill();
            }
            else if (toss < 16)
            {
                Play();
            }
            else
            {
                Feed();
            }
            return toss;
        }
        public int Boredom
        {
            get; private set;
        }
        public void Feed()
        {
            Hunger -= 15; Boredom += 5;
            Console.WriteLine("Eats..");
        }

        public void Play()
        {
            Hunger += 28; Boredom -= 25;
            Console.WriteLine("Plays..");
        }
        public void Chill()
        {
            Hunger += 10; Boredom += 10;
            Console.WriteLine("Chilling..");
        }

        public bool IsAlive()
        {
            if (Hunger > 100 || Hunger < 0)
            {
                return false;
            }
            return true;
        }

        public virtual string WhoAmI()
        {
            return "Lizard";
        }
    }
}
