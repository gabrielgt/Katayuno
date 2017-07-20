using System;

namespace Katayuno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Katayuno!");
            var bar = new Bar();
            var foo = new Foo(bar);
            Console.WriteLine(foo.DoFoo());
            Console.ReadLine();
        }
    }
}