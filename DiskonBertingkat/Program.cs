using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskonBertingkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input tingkat diskon :");
            int nDiskon = Convert.ToInt32(Console.ReadLine());
            int output =100000 ;
            for (int i = 0; i < nDiskon; i++)
            {
                Console.Write("Diskon tingkat {0} : ", i);
                int diskon = Convert.ToInt32(Console.ReadLine().ToString());
                output -= (output * diskon) / 100;
            }
            Console.WriteLine("Output {0}",output);
            Console.ReadKey();
        }        
    }
}
