using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 3;

            if (a+b > 10)
            {
                Console.WriteLine("The Answer is greter than 10");
                
            }
            else{
                Console.WriteLine("The Answer is not greter than 10");
            }
        }
    }
}
