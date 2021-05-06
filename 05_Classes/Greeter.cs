using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class Greeter
    {
        // 1 Access Modifier
        // 2 Return type
        // 3 Method Signature - includes the method Name and any parameters
        // 4 Body of the method - code that get's executed when the method is called

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting()
        {
            Random rand = new Random();
            string[] greetings = new string[] { "Hello", "Hi", "Sup", "Yo", "Hey" };
            int randomNumber = rand.Next(0, greetings.Length);
            string greeting = greetings[randomNumber];
            return greeting;
        }
    }
}
