using System;
using System.Collections.Generic;
using System.Text;

namespace TheSimsConsoleEdition
{
    class Actor : SimObject
    {
        private bool gender;
        private int age;
        private int hunger;
        private int thirst;
        private int bladder;
        private int happiness;
        
        public Actor(bool gender, int age)
        {
            this.gender = gender;
            this.age = age;
            hunger = 50;
            thirst = 50;
            bladder = 50;
            happiness = 50;
        }

        public override void Tick()
        {
            hunger++;
            thirst++;
            bladder++;
            happiness--;
            CheckValues();
        }
        private void CheckValues()
        {
            if (hunger >= 75)
                Console.WriteLine(this.getName() + " is hungry.");
            if (thirst >= 75)
                Console.WriteLine(this.getName() + " is thirsty.");
            if (bladder >= 75)
                Console.WriteLine(this.getName() + " needs to void their bowels.");
            if (happiness <= 25)
                Console.WriteLine(this.getName() + " is unhappy.");
        }
    }
}
