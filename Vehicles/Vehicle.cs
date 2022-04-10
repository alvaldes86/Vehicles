using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        private string _color;

        public int Wheels { get; set; }

        public string Color
        {
            get { return _color; }
            set { _color = value.Trim(); }
        }

        public Vehicle()
        {
            
        }

        public Vehicle(int pWheels, string pColor)
        {
            Wheels = pWheels;
            Color = pColor;
        }

        ~Vehicle()
        {
            _color = null;
        }

        

        public override string ToString()
        {
            string message = "Wheels: " + Wheels.ToString() + " Color: " + Color;

            return message;

        }
    }
}
