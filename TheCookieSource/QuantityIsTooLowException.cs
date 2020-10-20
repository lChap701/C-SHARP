using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCookieSource
{
    /// <summary>
    /// Created 10/14/2020 by Lucas Chapman.
    /// This class is created to act as an exception class for the quantity field in the Order class.
    /// </summary>
    public class QuantityIsTooLowException : Exception
    {
        /// <summary>
        /// Exception for when quantity is less than or equal to 0
        /// </summary>
        public QuantityIsTooLowException() : base("Quantity should be greater than 0")
        {
        }
    }
}
