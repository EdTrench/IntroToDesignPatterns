using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToDesignPatterns
{
    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
