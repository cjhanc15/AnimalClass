using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Horse : Animal, IWild
    {
        public override void Sing()
        {
            Console.WriteLine("neiiigh");
        }
        public void CatchMe()
        {
            Console.WriteLine("Throw a rope to catch me");
        }
    }
}
