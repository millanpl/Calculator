using System;

namespace Animal
{
    class Program
    {
        static int Main(string[] args)
        {
            Perro fido = new Perro();
            Console.WriteLine(fido.Ladrar());
            return 0;
        }
    }
}
