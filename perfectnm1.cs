using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class perfectnm1
    {
        static void Main(string[] args)
        {
            int num = 28;
            int copy = num;
            int startnum = 1;
          
            int sum = 0;
          while( startnum<num) {
                if (num % startnum == 0)
                {
                    sum = sum + startnum;
                  

                }
                startnum++;
              
            }

            if (sum == copy)
            {
                Console.WriteLine("perfect");
            }
            else
            {
                Console.WriteLine("not perfect");
            }

        }
    }
}
