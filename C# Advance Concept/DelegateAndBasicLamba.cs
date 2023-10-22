using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class DelegateAndBasicLamba
    {

        static void Main(string[] args)
        {
            MathOp a = Sub;
            a = Add;
            //Console.WriteLine(a(5,78));
            CalnPrint(4, 3, Sub);
            CalnPrint(21,42, delegate (int a, int c) { return a + c; });
            //lambda, holy shit
            CalnPrint(21, 42,  (int a, int c) => { return a + c; });

            //if single line, can rid of return and brackets
            CalnPrint(21, 42, (int a, int c) =>  a + c );
            //

            CalnPrint(21, 42, (a,c) => a + c);

            CalnPrint(3, 4, (a, c) => a * c);


        }

        static void CalnPrint(int x, int y, MathOp f)
        {
            var result = f(x, y);
            Console.WriteLine(result);
        }

        delegate int MathOp(int c, int f);
        static int Add(int a, int b)
        { return a + b; }
        static int Sub(int a, int b)
        { return a - b; }
    }

}
