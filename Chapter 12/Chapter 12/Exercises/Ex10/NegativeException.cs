using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12.Exercises.Ex10
{
    class NegativeException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Cannot withdraw/deposit a negative amount or bring balance below 0";
            }
        }
    }
}
