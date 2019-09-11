using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Gate
    {
        private double _Height;

        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value > 0 && value <= 8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid height");
                }
            }
        }

        public double Width { get; set; }

        public double Price { get; set; }

        private string _Style;
        public Gate(double height, double width, string style, double price)
        {
            double Height = height;
            double Width = width;
            string Style = style;
            double Price = price;
        }


        public double GateArea()
        {
            //probably should check that width and height has value
            return Width * Height;
        }
    }
}
