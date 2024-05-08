using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show Even Numbers");

            /* int num = int.Parse(Console.ReadLine());

             if (num % 2 == 0)
             {
                 Console.WriteLine("This is even number");
             }
             else
             {
                 Console.WriteLine("This is odd Number");
             }*/

            //Example with Loops

            /*  int i = 1;

              while (i<=10)
              {
                  if(i % 2 != 0)
                  {
                      Console.WriteLine(i);

                  }
                  i++;

              }*/

            /*  for (int i = 1; i <= 20; i++)
              {
                  if(i % 2 != 0)
                  {
                      Console.WriteLine(i);
                  }

              }*/

            //Leap Year

            /*   Console.WriteLine("Find a leap Year");

               int year = int.Parse(Console.ReadLine());

               if ( year % 4 == 0)
               {
                   Console.WriteLine("lEAP YEAR");
               }
               else
               {
                   Console.WriteLine("NOT A LEAP YEAR");
               }
   */
            //Sum of natural numbers

            /* int sum = 0;
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i);
                sum = sum + i;
                //0 = 0 +1 = 1
                //1 = 1 +2 = 3
                //3 = 3 + 3 = 6
                //6 = 6 + 4 = 10
                //10 = 10 + 5 = 15
             }
             Console.WriteLine("Sum of natural number is :" + sum );*/

            //Array
            //declare
            int[] a;
            //Initialize
            a = new int[10];


            int[] age = new int[5];
            age[0] = 10;
            age[1] = 20;
            age[2] = 30;
            age[3] = 40;
            age[4] = 50;


            //Console.WriteLine(age[0]);

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);
            }


            Console.ReadKey();
        }
    }
}
