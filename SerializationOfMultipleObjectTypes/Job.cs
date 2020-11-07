using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationOfMultipleObjectTypes
{
    [Serializable]
    public class Job
    {
        //private string jobDesc;
        //private DateTime jobHireDate;
        public string JobDesc { get; set; }
        public DateTime JobHireDate { get; set; }

    }
}
