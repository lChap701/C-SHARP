using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDiscussion
{
    public class HighBalanceException : Exception
    {
        // Create string to be thrown for this exception
        string msg = "Customer balance is too high";
    }
}
