using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToDesignPatterns
{
    abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, event decoys!");
        }
    }
}
