using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class Simple_N_Angle_Figure : I_Simple_N_Angle_Figure
    {
        public double Height_ { get; set; }
        public double Base_ { get; set; }
        public double Angle_Base_Edge_ { get; set; }
        public int Edge_quantity_ { get; set; }
        public double[] Edge_length_ { get; set; }
        public double Area_ { get; set; }
        public double Perimeter_ { get; set; }
        
       /* public Simple_N_Angle_Figure(double height_length, double base_length, double angle_base_edge, int edge_quantity, double[] Edge_length)
        {
        }*/
        public Simple_N_Angle_Figure() 
        {
            Edge_quantity_ = Convert.ToInt32(ServiceFunction.Get_Random(3,10));
            Edge_length_ = new double[Edge_quantity_];
            double edge_length = ServiceFunction.Get_Random(5, 10);
            //for (int i = 0; i < Edge_quantity_; i++){ Edge_length_[i] = ServiceFunction.Get_Random(5, 10); }
            for (int i = 0; i < Edge_quantity_; i++) { Edge_length_[i] = edge_length; }

            Area_ = (Math.Pow(edge_length, 2) * Edge_quantity_) / (4 * Math.Abs(Math.Tan(180 / Edge_quantity_)));

            foreach (var item in Edge_length_)
                Perimeter_ += item;
        }
    }
}
