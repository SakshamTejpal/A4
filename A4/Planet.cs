using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name-Saksham Tejpal
 * Date-7/24/17
 * Description-This is Planet abstract class
 * Version 0.4-Completed Planet class
 */
namespace A4
{
    abstract class  Planet
    {
        //PRIVATE INSTANCE MEMBERS
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        //PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                MoonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                OrbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                RingCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                RotationPeriod = value;
            }
        }
        //CONSTRUCTOR
        Planet(string name,double diameter,double mass)
        {
            name = _name;
            diameter = _diameter;
            mass = _mass;
        }
        //TO STRING
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _name, _diameter, _mass);
        }

    }
}
    



