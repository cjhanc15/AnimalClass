using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat : Animal, IDomesticated
    {
        public override void Sing()
        {
            Console.WriteLine("meow");
        }
        public void FeedMe()
        {
            Console.WriteLine("Eats cat foood");
        }

        public void TouchMe()
        {
            Console.WriteLine("Scratch my back");
        }
    }
}
