using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World!" tagurpidi
            string hellow = "Hello, world";

            for (int i = hellow.Length - 1; i >= 0; i--)
            {
                Console.Write(hellow[i]);
            }
          
        }
    }
}
