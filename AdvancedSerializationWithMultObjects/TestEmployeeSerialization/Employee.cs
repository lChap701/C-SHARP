using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployeeSerialization
{
    [Serializable]
    public class Employee
    {
        public int EmpNum { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DeptNum { get; set; }
        public List<Dependents> Depend;

    }
}
