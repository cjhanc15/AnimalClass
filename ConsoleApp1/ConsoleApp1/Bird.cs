using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bird : Animal, IFly
    {
        public override void Sing()
        {
            Console.WriteLine("Twee Twee");
        }
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
