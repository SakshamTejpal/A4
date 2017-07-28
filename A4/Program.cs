using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name-Saksham Tejpal
 * Date-7/24/17
 * Description-This is Drver class
 * Version 0.3-Created Driver class
 */
namespace A4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Giant Planets :-");
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116464, Convert.ToDouble(5.683 * Math.Pow(10, 26)), "Gas");
            giantPlanet.HasRing();
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine();
            Console.WriteLine("For Terrestrial Planets :-");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, Convert.ToDouble(5.972 * Math.Pow(10, 24)),true ); 
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine();
            Console.Write("WaitForAnyKey");
            Console.ReadKey();
        }
    }
}
