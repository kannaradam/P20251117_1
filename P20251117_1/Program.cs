using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20251117_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Add meg az a értékét: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Add meg a b értékét: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Add meg a c értékét: ");
                double c = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Ez nem másodfokú egyenlet, mert a = 0.");
                    return;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
