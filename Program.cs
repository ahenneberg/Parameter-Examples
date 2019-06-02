/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        // A method has a sequence of parameters.
        // Parameters define the set of arguments that must be provided for that method.
        static void Foo(int p)
        {
            p += 1;                 // Increment p by 1
            Console.WriteLine(p);   // Write p to screen
        }
        // In the following example, Foos sees the same StringBuilder object that Main instantiated,
        // but has independent reference to it.
        static void Foos (StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
            // Because fooSB is a COPY of a reference, setting it to null doesn't make sb null.
        }
        static void Main()
        {
            Foo (8);                // Call Foo with an argument of 8.
            // By default, arguments in C# are passed by value, which is by far the most common case.
            // This means a copy of the value is created when passed to the method:
            int x = 8;
            Foo (x);                // Make a copy of x
            Console.WriteLine (x);   // x will still be 8
            // Assigning p a new value does not change the contents of x,
            // since p and x reside in different memory locations.
            // Passing a reference-type argument by value copies the reference, but not the object.
            // sb and fooSB are separate variables that reference the same StringBuilder object:
            StringBuilder sb = new StringBuilder();
            Foos(sb);
            Console.WriteLine(sb.ToString());   //test
        }
    }
}

