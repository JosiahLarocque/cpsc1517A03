using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //by default all classes are private
    //for this class to be used by an outside user
    //   you must alter the permission for this class
    //   you will use public 
    public class FencePanel
    {
        //Properties
        //a property is associated with a single piece of data
        //a property has two sub components: 
        // get: returns a value to the calling client (outside user)
        // set: receives a value from the calling client
        //  a keyword "value" is used to hold the incoming 
        //       data to the property.
        // the property has a return data type (rdt) which specifies
        //        the type of data allowed.
        //the property syntax does NOT allow for a parameter.

        //Auto implemented property:
        //this style does NOT need a private data member 
        //the system will create an internal data member of the
        //    RTD specified in the property definition


        //public double Height { get; set; } what about negative numbers???

        //Assuming you wish to validate your data, then you should be using
        //   a fully implemented property
        //example: Height must have a positive non-zero value
        //         Height must not be greater than 8 feet
        private double _Height;
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                //validation of data
                // throw exception if invalid
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

        //Fully Implemented Property:
        //this style NEEDS a private data member 
        //the private data member will store the incoming data value
        //Usually this form of property is used when
        //     additional coding is required for the incoming data
        //     such as: validation of the data
        //example: the string data CAN NOT be an empty string 
        private string _Style;

        public string Style
        {
            //the keyword "value" holds the incoming data to
            //   the property
            get
            {
                //returns the stored data value
                return _Style;
            }
            set
            {
                //stores the incoming value in "value" to the
                //    private data member for storage
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }
        
        //nullable numeric property for a double
        //there are ONLY two possibilities:
        //     a) data is missing: null
        //     b) data is present and is of the right datatype
        public double? Price { get; set; }

        //constructor

        //either you code your constructors or you omit your
        //   constructors
        //if you omit constructors then the system will initialize
        //   your data members to the natural system defaults for
        //   that data member datatype.
        //if you code any constructor you are responsible for coding
        //  all constructors to be used by this class

        //Default
        //Similates the system initialization of your data
        //default execsutes on a : new FencePanel();
        public FencePanel()
        {
            //optionally you can override the system values with your
            //   own values
            Height = 6.0;
            Width = 8.0; 
            //the remainder of your data value would be the system values

        }

        //Greedie
        //the constructor has a list of parameters which will receive
        //    an argument value for each property in the class
        public FencePanel(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }

        //Behaviours (a.k.a. methods)
        public double EstimatedNumberOfPanels(double linearLength)
        {
            //You could use either the property Width or the
            //    data member _Width
            //Using the property ensures all validation or excess logic
            //   is in play
            double numberofpanels = linearLength / Width;   //_Width
            return numberofpanels;
        }

        public double FenceArea(double linearLength)
        {
            return linearLength * Height;
        }


        


        
    }//eoc
}//eon
