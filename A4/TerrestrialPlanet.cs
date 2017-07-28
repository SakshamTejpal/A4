using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name-Saksham Tejpal
 * Date-7/24/17
 * Description-This is TerrestrialPlanet class
 * Version 0.4-Created Methods for TerrestrialPlanet class
 */
namespace A4
{
    public class TerrestrialPlanet : Planet,IHasMoon,IHabitable 
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        //CONSTRUCTOR
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
           : base(name, diameter, mass)
        {
            oxygen = _oxygen;
        }
        //METHODS
        public bool HasMoons()
        {
            bool value;
            value = (MoonCount > 0) ? true : false;

            return value;
        }
        public bool Habitable()
        {
            bool value;
            value = (_oxygen == true) ? true : false;

            return value;
        }
    }
}