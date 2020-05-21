using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTools.Controllers
{
    public class Validation
    {
        public static int CheckIfValidInt(string inputValue)
        {
            bool isValid = Int32.TryParse(inputValue, out int number);
            if (isValid)
                return number;
            else
                return 0;
        }

        public static double CheckIfValidDouble(string inputValue)
        {
            bool isValid = Double.TryParse(inputValue, out double number);
            if (isValid)
                return number;
            else
                return 0;
        }
    }
}
