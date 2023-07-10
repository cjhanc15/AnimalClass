using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog: Animal, IDomesticated
    {
        public Dog() {
            Console.Write("Animal Constructor, Good Puppy");
        }

        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }

        public override void Sing()
        {
            Console.WriteLine("Hooooooowl");
        }

        public void fetch(string thing)
        {
            Console.WriteLine("Oh boy, here is your " + thing + ". Let's do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's Suppertime! The very best time of day!");
        }
    }
}
