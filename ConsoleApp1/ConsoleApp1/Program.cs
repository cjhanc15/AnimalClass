using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal beast = new Animal();

            //beast.Talk();
            //beast.Greet();
            //beast.Sing();

            //Console.ReadLine();

            Dog einstein = new Dog();
            einstein.Talk();
            einstein.Greet();
            einstein.Sing();
            einstein.fetch("ball");
            einstein.FeedMe();
            einstein.TouchMe();

            Console.ReadLine();

            Robin robin = new Robin();
            robin.Talk();
            robin.Greet();
            robin.Sing();

            Console.ReadLine();

            Horse alli = new Horse();
            alli.Sing();
            alli.CatchMe();

            Console.ReadLine();

            Pig pig = new Pig();

            pig.Sing();
            pig.TouchMe();
            pig.FeedMe();

            Console.ReadLine();

            Cat salem = new Cat();
            salem.Sing();
            salem.TouchMe();
            salem.FeedMe();

            Console.ReadLine();

            Bird bird = new Bird();

            bird.Sing();
            bird.Fly();

            Console.ReadLine();
        }
    }
}