using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Calculator class
    /// Has methods to perform mathematical operations.
    /// <list type="bullet">
    /// <item>
    /// <term>Add</term>
    /// <description>Addition Operation</description>
    /// </item>
    /// <item>
    /// <term>Sub</term>
    /// <description>Subtraction Operation</description>
    /// </item>
    /// <item>
    /// <term>Mul</term>
    /// <description>Multiplication Operation</description>
    /// </item>
    /// <item>
    /// <term>Div</term>
    /// <description>Division Operation</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// This class can add, subtract, multiply and divide.
    /// </remarks>
    public class Calculator
    {

        public static void Main(String[] args)
        {
            Calculator c = new Calculator();
            char a;
            String val;
            int n1, n2, ans;
            Console.Write("Enter integer: ");
            val = Console.ReadLine();
            n1 = Convert.ToInt32(val);
            Console.Write("Enter integer: ");
            val = Console.ReadLine();
            n2 = Convert.ToInt32(val);
            Console.Write("Enter operation: ");
            val = Console.ReadLine();
            a = Convert.ToChar(val);
            switch (a)
            {
                case '+':
                    ans = c.Add(n1, n2);
                    Console.WriteLine("result: ");
                    Console.WriteLine(ans);
                    break;
                case '-':
                    ans = c.Sub(n1, n2);
                    Console.WriteLine("result: ");
                    Console.WriteLine(ans);
                    break;
                case '*':
                    ans = c.Mul(n1, n2);
                    Console.WriteLine("result: ");
                    Console.WriteLine(ans);
                    break;
                case '/':
                    ans = c.Div(n1, n2);
                    Console.WriteLine("result: ");
                    Console.WriteLine(ans);
                    break;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Adds two integers <paramref name="x"/> and <paramref name="y"/> and returns the result as <paramref name="z"/>.
        /// </summary>
        /// <param name="x">an integer type number </param>
        /// <param name="y">an integer type number </param>
        /// <returns></returns>
        public int Add(int x, int y)
        {
            int z = x + y;
            return z;
        }
        /// <summary>
        /// performs substraction on two integers <paramref name="x"/> and <paramref name="y"/> and returns the result as <paramref name="z"/>.
        /// </summary>
        /// <param name="x">an integer type number </param>
        /// <param name="y">an integer type number </param>
        /// <returns></returns>
        public int Sub(int x, int y)
        {

            int z = x - y;
            return z;
        }
        /// <summary>
        /// performs multiplication on two integers <paramref name="x"/> and <paramref name="y"/> and returns the result as <paramref name="z"/>.
        /// </summary>
        /// <param name="x">an integer type number </param>
        /// <param name="y">an integer type number </param>
        /// <returns>an</returns>
        public int Mul(int x, int y)
        {
            int z = x * y;
            return z;
        }
        /// <summary>
        /// performs division on two integers <paramref name="x"/> and <paramref name="y"/> and returns the result as <paramref name="z"/>.
        /// </summary>
        /// <param name="x">an integer type number </param>
        /// <param name="y">an integer type number </param>
        /// <returns></returns>
        /// <exception cref="System.DivideByZeroException">Thrown when the second parameter is zero
        /// </exception>
        public int Div(int x, int y)
        {
            int z = x / y;
            return z;
        }
    }
}
