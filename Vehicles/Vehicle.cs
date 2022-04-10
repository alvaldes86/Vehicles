using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        private int _wheels;
        private string _color;

        public int Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }

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
            string message = "";

            return message;

        }
    }
}
