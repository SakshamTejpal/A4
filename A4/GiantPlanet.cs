using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name-Saksham Tejpal
 * Date-7/24/17
 * Description-This is GiantPlanet class
 * Version 0.3-Created Meathods for GiantPlanet class
 */
namespace A4
{
    public class GiantPlanet : Planet,IHasMoon
    {
        //PRIVATE INSTANCE VARIABLE
        private string _type;
        //CONSTRUCTOR
        GiantPlanet(string name,double diameter,double mass,string type)
            : base (name,diameter,mass)
        {
            type = _type;
        }
        //METHODS
        public bool HasMoons()
        {
            bool value;
            value =(MoonCount > 0) ? true : false;

            return value;
        }
        public bool HasRings()
        {
            bool value;
            value = (RingCount > 0) ? true : false;

            return value;
        }


    }
}