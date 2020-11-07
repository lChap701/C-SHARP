using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationOfMultipleObjectTypes
{
    [Serializable]
    public class Employee
    {
        //private int empNum;
        //private string name;
        //private double salary;
        public int EmpNum { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
