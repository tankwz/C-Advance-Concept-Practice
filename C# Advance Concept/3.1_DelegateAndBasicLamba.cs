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
            //dependency injection is register certain classes which provide certain logics, like database access, you can register these classes on a central location, like you can just say this class is responsive for database access and everybody else in the entire application just need to say i need database access and it will get the register class automatically without you having to create the neccessary class manually
            //so you're centralizing a kind of registry which classes are responsive to which topic and you do that centrally in one location and then everybody else if they need any helper class to something they just say i need this helper class and they get it from the central registry  
        }

        static void s(string[] args)
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
