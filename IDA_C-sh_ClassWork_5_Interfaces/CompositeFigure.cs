using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class CompositeFigure
    //internal class CompositeFigure
    {   
        public Simple_N_Angle_Figure[] figure_list {  get; set; }

        public double GetArea()
        {
            double composite_figure_area = 0;
            foreach (Simple_N_Angle_Figure figure in figure_list)
                composite_figure_area += figure.Area_;
            return composite_figure_area;
        }
        public CompositeFigure(): this((int)ServiceFunction.Get_Random(3,10)) { }

        public CompositeFigure(int simple_figure_quantuty)
        {
            figure_list = new Simple_N_Angle_Figure[simple_figure_quantuty];

            for (int i = 0; i < figure_list.Length; i++)
            {
                figure_list[i] = new Simple_N_Angle_Figure();
            }
        }

    }
}
