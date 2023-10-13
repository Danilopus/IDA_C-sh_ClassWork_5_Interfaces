// ClassWork template 1.2 // date: 29.09.2023

using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork 5 : [Interfaces] 11.10.2023 --------------------------------

// Syntax
/*
 interface IInterface
{
void F001(){}
const int a = 10; 
static int b = 15;
//int c; // No - static only

}
 
 */

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task_1();
             Task_2();

             Console.ReadKey();

        }

        public static void Task_1() 
        {
        Chief chief_obj = new Chief();
        Manager manager_obj = new Manager();

            chief_obj.Print();
            manager_obj.Print();

        }
        public static void Task_2() 
        {
                      
            //CompositeFigure compositeFigure = new CompositeFigure(3);
            CompositeFigure compositeFigure = new CompositeFigure();

            Console.WriteLine("\nCompositeFigure consists of {0} figures:", compositeFigure.figure_list.Length);
            for (int i = 0; i < compositeFigure.figure_list.Length; i++) 
            {
                Console.WriteLine("figure [" + (i+1) + "]\tEdge quantity -> " + compositeFigure.figure_list[i].Edge_quantity_ + 
                    "\tArea -> {0}" +
                    "\tPerimeter -> {1}" +
                    "\tEdge -> {2}"
                    , Math.Round(compositeFigure.figure_list[i].Area_, 2)
                    , Math.Round(compositeFigure.figure_list[i].Perimeter_, 2)
                    , Math.Round(compositeFigure.figure_list[i].Edge_length_[0], 2));
            }
        Console.WriteLine("\nCompositeFigure.GetArea -> {0}", Math.Round(compositeFigure.GetArea(), 2));

        }

    } // class Programm
}// namespace


