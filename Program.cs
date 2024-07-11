using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatsCommandLineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numberInput = new int[5];
           numberInput[0] = Convert.ToInt32(args[0]);
           numberInput[1] = Convert.ToInt32(args[1]);
           numberInput[2] = Convert.ToInt32(args[2]);
           numberInput[3] = Convert.ToInt32(args[3]);
           numberInput[4] = Convert.ToInt32(args[4]);

           int min = int.MaxValue, max = 0, sum, avg;

           sum = numberInput[0] + numberInput[1] + numberInput[2] + numberInput[3] + numberInput[4];
           Console.WriteLine("The sum of 5 numbers is " + sum);

           avg = sum / 5;
           Console.WriteLine("The average of 5 numbers is " + avg);

           for (int i = 0; i < numberInput.Length; i++)
           {

               if (numberInput[i] > max)
                   max = Math.Max(numberInput[i], max);

           }

           Console.WriteLine("The count of the numbers from the command line is " + numberInput.Length);

           Console.WriteLine("The maximum of the 5 numbers is " + max);

           for (int i = 0; i < numberInput.Length; i++)
           {

               if (numberInput[i] < min)
                   min = Math.Min(numberInput[i], min);

           }

           Console.WriteLine("The minimum of the 5 numbers is " + min);
        }
    }
}
