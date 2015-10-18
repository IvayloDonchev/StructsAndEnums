#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StructsAndEnums
{
    enum Season { Spring=1, Summer, Fall, Autumn = Fall, Winter };
    class Program
    {
        static void doWork()
        {
            //Month first = Month.January;
            //Console.WriteLine(first);
            //++first;
            //Console.WriteLine(first);
            for (Month m = Month.January; m <= Month.December; ++m)
                Console.WriteLine(m);
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
