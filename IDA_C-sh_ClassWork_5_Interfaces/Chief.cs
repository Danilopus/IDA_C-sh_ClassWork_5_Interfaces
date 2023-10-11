using IDA_C_sh_ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class Chief : ISalary, ICOUT
    {
        public string Name_ { get; set; }
        public long Work_days_ { get; set; }
        public Chief()
        {

            Name_ = "Egor Petrov";
            Work_days_ = 20;

        }
        public long CalculateSalary()
        {
            return Work_days_ * ISalary._chief_work_rate;
        }
        public void Print()
        {
            Console.WriteLine("\nType: "+ this +"\nName: {0}" +
                "\nWork days: {1}" +
                "\nSalary: {2}" +
                "\nTaxes: {3}", 
                Name_, Work_days_, 
                CalculateSalary(), 
                new AccountDepartment().Tax_calculate(this));
        }
    }
}
