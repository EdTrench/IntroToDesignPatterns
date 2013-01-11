using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToDesignPatterns
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
