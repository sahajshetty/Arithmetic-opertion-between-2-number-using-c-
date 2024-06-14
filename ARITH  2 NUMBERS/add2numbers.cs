using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace consoleApplication4
{
    class add2numbers
    {
        static void Main(string[] args)
        {
            int result;

            Console.Write("ENTER 1st NUMBER:");
            int num1=Convert.ToInt32(Console.ReadLine());

             Console.Write("ENTER 2nd NUMBER:");
            int num2=Convert.ToInt32(Console.ReadLine());

             Console.Write("MY CHOICE:");
            int ch=Convert.ToChar(Console.ReadLine());

            //use switch case
            switch (ch)
            {
                case '+':
                result = num1 + num2;
                Console.Write("RESULT="+result);
                break;
                case '-':
                result = num1 - num2;
                Console.Write("RESULT="+result);
                break;
                case '*':
                result = num1 * num2;
                Console.Write("RESULT="+result);
                break;
                case '/':
                result = num1 / num2;
                Console.Write("RESULT="+result);
                break;
                default:
                Console.Write("INVALID CHOICE");
                break;
            }
            Console.Read();
        }
    }
}