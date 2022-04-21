using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB2
{

   public enum AccountType
    {
        Savings,
        Current,
        PF
    }


    public abstract class Accounts
    {
        static int auto_accNo = 100;

        #region Properties
        public string accNo { get; set; }
        public string accName { get; set; }
        public AccountType accType { get; set; }
        public double accBalance { get; set; }
        public string accCity { get; set; }
        public bool accIsActive { get; set; }
        public string accEmail { get; set; }
        #endregion

        #region Constructors
        //.net compilers by default add a parameterless contructor to your class, called as default constructor

        public Accounts()
        {

        }
        public Accounts(string p_accName,AccountType p_accType,double p_accBalance =100)
        {
            accName = p_accName;
            accType = p_accType;
            accBalance = p_accBalance;

            //do a validations of incming values, if everything is fine, increase the static variable value and assign it to accNo property
            auto_accNo = auto_accNo + 1;
            accNo = "SAV" +auto_accNo;
          
        }

        public Accounts(int p_accNo, string p_accName, AccountType p_accType, double p_accBalance, string p_city ="Head Office",string p_email="will provide later")
        {
           
            accName = p_accName;
            accType = p_accType;
            accBalance = p_accBalance;
            accCity = p_city;
            accEmail = p_email;
            auto_accNo = auto_accNo + 1;
            accNo = "SAV" + auto_accNo;
        }
        #endregion

        #region Methods
        public double SimpleIntrest(int p_principal, int p_duration_In_year,double p_roi = 10)
        {
            return ((p_principal * p_roi / 100) * p_duration_In_year);
        }
        #endregion

    }
}
