using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoridims 
{

    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 2, 3, 4 };
            List<int> b = new List<int>() { 4, 3, 5 };
            for (int i = 0; i < 3; i++)
            {
                var va = a[i] * a[i + 1] * a[i + 2];
                var vb = b[i] * b[i + 1] * b[i + 2];

                var vol = va - vb;
                if (vol < 0)
                {
                    Console.WriteLine(vol * -1) ;
                }
                else
                {
                    Console.WriteLine(vol);
                }

            }

        }
        
    }
    
}
