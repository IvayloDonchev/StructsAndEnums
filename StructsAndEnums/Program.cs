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
            //for (Month m = Month.January; m <= Month.December; ++m)
            //    Console.WriteLine("{0} {1}",(int)m+1, m);
            //Date defaultDate = new Date();
            //Console.WriteLine(defaultDate);
            Date weddingAnniversary = new Date(2013, Month.July, 4);
            Console.WriteLine(weddingAnniversary);
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine("Value of copy is {0}", weddingAnniversaryCopy);
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine("New value of weddingAnniversary is {0}", weddingAnniversary);
            Console.WriteLine("Value of copy is still {0}", weddingAnniversaryCopy);
           // Console.WriteLine("Проба 1 2 3 Proba Кирилицата работи!!!");
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
