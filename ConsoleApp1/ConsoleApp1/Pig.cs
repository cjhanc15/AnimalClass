using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pig : Animal, IDomesticated
    {
        public void FeedMe()
        {
            Console.WriteLine("Eating slop");
        }

        public override void Sing()
        {
            Console.WriteLine("ooinkk");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please pet me");
        }
    }
}
