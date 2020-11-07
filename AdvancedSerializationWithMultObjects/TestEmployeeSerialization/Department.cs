using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmployeeSerialization
{
    [Serializable]
    public class Department
    {
        public int DeptNum { get; set; }
        public string DeptName { get; set; }

    }
}
