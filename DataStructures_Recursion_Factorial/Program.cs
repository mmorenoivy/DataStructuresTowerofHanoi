using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Recursion_Factorial
{
    class Program
    {

        static void Main(string[] args)
        {
            //int n = 3;
            //recursion(n);
            

            int m = 3;
            towerOfHanoi(m, 'A', 'C', 'B');
            Console.ReadKey();
        }

       //static void recursion(int n)
       // {
       //     if (n < 1)
       //     {
       //         return;
       //     }
       //     else
       //     {
       //         Console.Write(n + " ");
       //         recursion(n - 1);

       //         Console.Write(n + " ");
       //         return;
       //     }
            
       // }

        static void towerOfHanoi(int n, char from, char to, char misc)
        {
            //if moving one disc only
            if(n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + from + " " +  "to rod " + to);
                return;
            }
            //else if not, then recursively call subtasks
            towerOfHanoi(n-1, from, to, misc);
            Console.WriteLine("Move disk " + n + " " + " from rod " + from + " to rod " + to);
            towerOfHanoi(n-1, misc, to, from);
        }
    }
}
