using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class DelegateAndBasicLamba
    {
        public void note()
        {
            //delegates are TYPE describing a common set of functions, all the functions look exactly like delegate are called instances of the delegate


            //lambda is a concise way to define anonymous methods or delegates with less code, lambda expressions are often used for creating small, inline function that can be passed as arguments to other method or assign to delegate variables/


            //generic  enable us to pass in a type to a function like a parameter to a function
            //it enables a TYPE of parameter as a PARAMETER
        }

        static void Main(string[] args)
        {
            MathOp a = Sub;
            a = Add;
            //Console.WriteLine(a(5,78));
            CalnPrint(4, 3, Sub);
            CalnPrint(21, 42, delegate (int a, int c) { return a + c; });
            //lambda, holy shit
            CalnPrint(21, 42, (int a, int c) => { return a + c; });

            //if single line, can rid of return and brackets
            //    CalnPrint(21, 42, (int a, int c) =>  a + c );
            //

            //  CalnPrint(21, 42, (a,c) => a + c);

            //   CalnPrint(3, 4, (a, c) => a * c);

            //    Combine<int> c = Add;

            //Console.Write(c(4, 5));
            CalnPrintGeneric <double>( 4,3, ( a,  b) => a/b);

        }
        delegate T Combine<T>(T a, T b);

        static void CalnPrintGeneric<T>(T x, T y, Combine<T> f)
        {
            var result = f(x, y);
            Console.WriteLine(result);
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
