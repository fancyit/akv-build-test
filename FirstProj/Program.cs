using SecondProj;
using System;

namespace FirstProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling method from second project");

            MyClass.SayMyName();
        }
    }
}
