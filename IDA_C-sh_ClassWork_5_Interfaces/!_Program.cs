// ClassWork template 1.2 // date: 29.09.2023

using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork XX : [Interfaces] 11.10.2023 --------------------------------

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
            // Task_3();


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
        CompositeFigure compositeFigure = new CompositeFigure(3);

            for (int i = 0; i < compositeFigure.figure_list.Length; i++) 
            {
                Console.WriteLine("figure" + i + "\tEdge_quantity -> " + compositeFigure.figure_list[i].Edge_quantity_);
            }
            Console.WriteLine("\nCompositeFigure.GetArea -> {0}", compositeFigure.GetArea());


        }
        public static void Task_3() { }

    } // class Programm
}// namespace

