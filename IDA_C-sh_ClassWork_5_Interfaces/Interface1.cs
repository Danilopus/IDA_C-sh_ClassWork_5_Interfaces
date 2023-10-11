using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal interface IInterface1
    {
        public void F001();
        void F002();
    }
    internal interface IInterface2
    {
        //public void F002();
        public void F001();
        public void F003();
    }
    internal class Cl1 { }
    class Cl2 : Cl1, IInterface1, IInterface2
    {
        public void F001() { }
        public void F002() { }
        public void F003() { }

    }
}
