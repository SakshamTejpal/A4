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
    public class GiantPlanet : Planet,IHasMoon,IHasRing
    {
        //PRIVATE INSTANCE VARIABLE
        private string _type;
        //CONSTRUCTOR
        public GiantPlanet(string name,double diameter,double mass,string type)
            : base (name,diameter,mass)
        {
            _type = type;
        }
        //METHODS
        public bool HasMoons()
        {
            bool value;
            value =(MoonCount > 0) ? true : false;

            return value;
        }

       

        public bool HasRing()
        {

            bool value;
            value = (RingCount > 0) ? true : false;

            return value;
        }


    }
}