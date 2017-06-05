using System;

using Training.NetStandard.Lib;

namespace Training.NetStandard.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Common();
            greeter.WriteGreeting(".NET Core");

            Console.ReadKey(true);
        }
    }
}