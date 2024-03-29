﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToDesignPatterns
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real mallard duck");
        }

    }
}
