using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessClasses
{
    static class Validator
    {
        private static string lineEnd = "\n";

        public static string LineEnd
        {
            get
            {
                return lineEnd;
            }
            set
            {
                lineEnd = value;
            }
        }

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsInteger(string value, string name)
        {
            string msg = "";
            if (!int.TryParse(value, out _))
            {
                msg += name + " must be a valid integer." + LineEnd;
            }
            return msg;
        }


        
    }
}
