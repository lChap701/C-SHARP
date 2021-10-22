using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryWithUnitTest
{
    public class LessThanZeroOrEqualToException : Exception
    {
        public LessThanZeroOrEqualToException() : base("Must be greater than zero.")
        {
        }
    }
}
