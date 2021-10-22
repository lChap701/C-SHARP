using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployeeSerialization
{
    [Serializable]
    public class Dependents
    {
        public string DependName { get; set; }
        public DateTime DependBdate { get; set; }

        public Dependents(string n, DateTime b)
        {
            DependName = n;
            DependBdate = b;
        }

    }
}
