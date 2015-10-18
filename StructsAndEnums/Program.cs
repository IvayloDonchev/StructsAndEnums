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
            // TODO:
            Season season = Season.Autumn;
            if (season == Season.Fall)
                Console.WriteLine("The season is {0}",season);
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
