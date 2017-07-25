using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name-Saksham Tejpal
 * Date-7/24/17
 * Description-This is GiantPlanet class
 * Version 0.2-Created Constructor for GiantPlanet class
 */
namespace A4
{
    public class GiantPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLE
        private string _type;
        //CONSTRUCTOR
        GiantPlanet(string name,double diameter,double mass,string type)
            : base (name,diameter,mass)
        {
            type = _type;
        }
    }
}