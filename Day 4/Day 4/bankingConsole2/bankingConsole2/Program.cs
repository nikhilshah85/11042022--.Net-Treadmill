using bankingLIB2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingConsole2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Named parameter and Default parameter
            //Accounts acc = new Accounts(101, "Nikhil", "Savings", 5000);
            //what is the name of accunt holder ?
            //anyne should not be able to create n object without providing the initial values

            //  Accounts acc = new Accounts(101, "Nikhil", "Savings", 5000, "Mumbai","nik@gmail.com");
            //

            ////this is called as named parameter, it works with constructor and methods or functins both

            //Accounts acc2 = new Accounts(p_city:"Mumbai", p_accType : "Savings", p_accName: "Yash", p_accNo: 5000, p_email: "yash@smewhere.com", p_accBalance: 6000);


            //Accounts acc3 = new Accounts(103, "Roshni", "Savings",p_accBalance:200,"Pune");
            //Console.WriteLine(acc3.accBalance);
            //Console.WriteLine(acc3.accEmail);

            //Console.WriteLine(acc3.SimpleIntrest(100000, 2,18));
            #endregion

            //here user can enter any type of account type, we have specific account types
            //thus, enum - enumarations

            //Accounts acc4 = new Accounts(101,"nikhil", "Fraud")

            //Accounts acc1 = new Accounts(101, "Nikhil", AccountType.Savings);
            //Console.WriteLine(acc1.accType);

            //

            //int? favNo =null;

            //Console.WriteLine(favNo);

            #region Static

            //Accounts acc1 = new Accounts("nik", AccountType.Savings);
            //Accounts acc2 = new Accounts("Yash", AccountType.Savings);
            //Accounts acc3 = new Accounts("Roshni", AccountType.Savings);
            //Accounts acc4 = new Accounts("Ram", AccountType.Savings);
            //Accounts acc5 = new Accounts("Shyam", AccountType.Savings);

            //Console.WriteLine(acc1.accNo + " : " + acc1.accName);
            //Console.WriteLine(acc2.accNo + " : " + acc2.accName);
            //Console.WriteLine(acc3.accNo + " : " + acc3.accName);
            //Console.WriteLine(acc4.accNo + " : " + acc4.accName);
            //Console.WriteLine(acc5.accNo + " : " + acc5.accName);
            #endregion

            //in real life, there is always a type of account
            //account is just not an account, 


            //this should nt be allowed in any exe or app
            Accounts acc1 = new Accounts(); //this is not real
                                            //this we will mark accounts class as an abstract class




        }
    }
}
