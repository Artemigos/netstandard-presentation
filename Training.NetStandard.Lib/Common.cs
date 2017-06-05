using System;

namespace Training.NetStandard.Lib
{
    public class Common
    {
        public string Greet(string name) =>
            $"Hello, {name}!";

        public void WriteGreeting(string name) =>
            Console.WriteLine(Greet(name));
    }
}
