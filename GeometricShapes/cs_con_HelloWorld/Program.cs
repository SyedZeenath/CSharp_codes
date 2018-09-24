using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_HelloWorld
{
    /// <summary>
    /// my first c# program
    /// </summary>
    class Program
    {
        /// <summary>
        ///     the main method
        ///     <seealso cref="Program.Demo"/>
        ///     <seealso cref="Program.Add(int, int)"/>
        ///     <seealso cref="System.Console.WriteLine(String)"/>
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            Demo();
            int a = 10;
            int b = 20;
            int c = Add(a, b);

            Console.WriteLine("Result= " + c);
            Console.WriteLine("result= " + c.ToString());
            Console.WriteLine("result= {0}", c);   //positional argument


            Console.ReadKey();
        }
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <example>Add(10, 20)</example>
        /// <param name="x">first Name</param>
        /// <param name="y">Second Name</param>
        /// <returns></returns>
        private static int Add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Add 3 numbers
        /// </summary>
        /// <example>
        ///     int a =10, b =20, c=30;
        ///     int result = Add(a, b, c);
        /// </example>
        /// <param name="x">first Number</param>
        /// <param name="y">Second Number</param>
        /// <param name="z">third Number</param>
        /// <returns>sum of 3 numbers</returns>
        private static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        private static void Demo()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("anotherWorld");
            Console.WriteLine("different World");
        }
    }
}
