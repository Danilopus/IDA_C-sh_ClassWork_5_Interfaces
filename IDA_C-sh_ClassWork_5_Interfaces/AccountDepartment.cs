using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{ 
    internal class AccountDepartment
    {
        int tax = 13;
        public long Tax_calculate(ISalary salary_obj)
        {
           return Convert.ToInt64(salary_obj.CalculateSalary() * ((double)tax / 100)); 
        }
    }
}
