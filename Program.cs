using System;
using FileSystem;

namespace learn_csharp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/home/killianfrappart/Dev/CSharp/learn-csharp-5/README.md";
            Console.WriteLine(Exercice1.Answer(path));
            Console.WriteLine(Exercice2.Answer(path));
        }
    }
}
