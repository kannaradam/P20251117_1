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

                double diszkriminans = b * b - 4 * a * c;
                Console.WriteLine($"\nA diszkrimináns értéke: {diszkriminans}");

                if (diszkriminans < 0)
                {
                    Console.WriteLine("Nincs megoldás, mert nem lehet negativ a gyök alatt.");
                }
                else if (diszkriminans == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("1 megoldás van.");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(diszkriminans)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(diszkriminans)) / (2 * a);
                    Console.WriteLine("2 megoldás van.");
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Nem szamot irtal be, írj be szamot.");
            }
            Console.ReadKey();
        }
    }
}
