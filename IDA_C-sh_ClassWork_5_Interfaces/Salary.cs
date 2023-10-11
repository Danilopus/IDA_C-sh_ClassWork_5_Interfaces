using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal interface ISalary
    {
        protected static int _manager_work_rate = 1000; //RUB per day
        protected static int _chief_work_rate = 2500; //RUB per day
        public long CalculateSalary();
        public string Name_ { get; set; }
        public long Work_days_ { get; set; }   
    }
}
