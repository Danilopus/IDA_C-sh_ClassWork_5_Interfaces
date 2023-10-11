using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal interface I_Simple_N_Angle_Figure
    {
        double Height_ {  get; set; }
        double Base_ {  get; set; }
        double Angle_Base_Edge_ {  get; set; }
        int Edge_quantity_ {  get; set; }
        double[] Edge_length_ { get; set; }
        double Area_ { get; set; }
        double Perimeter_ {  get; set; }

    }
}
