using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Demo
{
    internal class Current : Accounts
    {
        public bool isODApplied { get; set; }

        public override double Widraw(int w_amount)
        {
            if (w_amount > 50000)
            {
                //throw the exception
                Console.WriteLine("Current account cannot widraw more than 50l");
                return 0;
            }
            else
            {
                return base.Widraw(w_amount);
            }

        }
    }
}
