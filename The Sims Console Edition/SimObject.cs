using System;
using System.Collections.Generic;
using System.Text;

namespace TheSimsConsoleEdition
{
    abstract class SimObject
    {
        string name;
        public virtual void Tick()
        {

        }
        public string getName()
        {
            return name;
        }
    }
}
