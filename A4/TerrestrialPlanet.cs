using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name-Saksham Tejpal
 * Date-7/24/17
 * Description-This is TerrestrialPlanet class
 * Version 0.3-Created Constuctor for GiantPlanet class
 */
namespace A4
{
    public class TerrestrialPlanet : Planet 
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        //CONSTRUCTOR
        TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
           : base(name, diameter, mass)
        {
            oxygen = _oxygen;
        }
    }
}