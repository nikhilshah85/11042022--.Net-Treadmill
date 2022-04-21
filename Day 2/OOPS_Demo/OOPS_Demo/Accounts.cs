using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Demo
{
    internal class Accounts
    {        
        #region Accounts Properties
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accLastName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        #endregion

        #region Account methods
        public virtual double Widraw(int w_amount)
        {
            if (w_amount < 100)
            {
                Console.WriteLine("Please widraw minimum 100 Rs.");
                return 0;
            }
            else
            {
                accBalance = accBalance - w_amount;
                return accBalance;
            }
        }

        public double Deposit(int d_amount)
        {
            accBalance -= d_amount;
            return accBalance;
        }

        #endregion
    }
}
