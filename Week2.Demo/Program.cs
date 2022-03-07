using System;

namespace Week2.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 0;
            //MyMethod(2, 3, ref x);
            MyMethod(2, 3, x);
            Console.WriteLine($"La x vale: {x}");
            Console.WriteLine("La x vale: " + x);
            Console.WriteLine("La x vale: {0}", x);
            x = SommaValori(2, 3);
            
        }

        //public static void MyMethod(int a, int b, ref int c)
        public static void MyMethod(int a, int b, int c)
        {
            c = a + b;
        }
        public static int MyMethod(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static int SommaValori(int a, int b)
        {
            return a + b;
        }
    }
}
