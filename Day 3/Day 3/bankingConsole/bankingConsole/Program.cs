using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankingLIB;
namespace bankingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts accounts = new Accounts() { accNo =101, accBalance =5000, accIsActive =true, accName="Ria" };


       #region Prgram Variables 
            Accounts[] accList = new Accounts[10];
            int position = 0;
            accList[position] = accounts;
            bool continueOperatins = true;
       #endregion

            while (continueOperatins)
            {
                Console.Clear();
                Console.WriteLine("Total Accounts are " + (position + 1));
                #region Menu
                Console.WriteLine("Enter a choice");
                Console.WriteLine("1. Account Details");
                Console.WriteLine("2. Widraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Create a New Account");
                Console.WriteLine("5. Show Account List");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
 #endregion

                #region Operations
                switch (choice)
                {
                    #region Case 1 - Veiw Account Details
                    case 1:
                        Console.WriteLine("Account Number  is " + accounts.accNo);
                        Console.WriteLine("Account Name  is " + accounts.accName);
                        Console.WriteLine("Account Balance  is " + accounts.accBalance);
                        Console.WriteLine("Account Status  is active ? " + accounts.accIsActive);
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        break;
                    #endregion

                    #region Case 2 - Widraw
                    case 2:
                        Console.WriteLine("Enter Amount to Widraw");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount After Widrawal : " + accounts.Widraw(amount));
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        break;
                    #endregion

                    #region Case 3 -  Deposit
                    case 3:
                        Console.WriteLine("Enter Amount to Deposit");
                        int amount2Deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount after Deposit : " + accounts.Deposit(amount2Deposit));
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        break;
                    #endregion

                    #region case 4 - Create New Account
                    case 4:
                        Console.Clear();
                        Console.WriteLine("1. Savings");
                        Console.WriteLine("2. Current");
                        Console.WriteLine("3. PF");
                        int accTypeToCreate = Convert.ToInt32(Console.ReadLine());

                        Accounts newAcc = new Accounts();
                        if (accTypeToCreate == 1)
                        {
                            newAcc = new Savings();
                            newAcc.accType = "Savings";
                        }
                        if (accTypeToCreate == 2)
                        {
                            newAcc = new Current();
                            newAcc.accType = "Current";
                        }
                        if (accTypeToCreate == 3)
                        {
                            newAcc = new PF();
                            newAcc.accType = "PF";
                        }
                       
                        Console.WriteLine("Enter Account Name");
                        newAcc.accName = Console.ReadLine();
                        Console.WriteLine("Enter Initial Account Balance");
                        newAcc.accBalance = Convert.ToInt32(Console.ReadLine());
                        position = position + 1;
                        int newAccountNumber = position + 101;

                        newAcc.accNo = newAccountNumber;
                        newAcc.accIsActive = true;
                        accList[position] = newAcc;
                        Console.WriteLine("Account Created Successfully, new account Number is  " + newAccountNumber);
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        break;
                    #endregion

                    #region case 5 - View Account List
                    case 5:
                        for (int i = 0; i < accList.Length; i++)
                        {
                            Console.WriteLine("Account Number     : " + accList[i].accNo);
                            Console.WriteLine("Account Name       : " + accList[i].accName);
                            Console.WriteLine("Account Balance    : " + accList[i].accBalance);
                            Console.WriteLine("Account Is Active  : " + accList[i].accIsActive);
                            Console.WriteLine("------------------------------------------------------------------");

                        }
                         break;
                    #endregion

                    #region Case 6 - Exit
                    case 6:
                        Console.WriteLine("Thank you for Banking with us");
                        continueOperatins = false;
                        break;
                    #endregion

                    #region Case Default
                    default:
                        break;
                      #endregion
                }
                #endregion
            }
        }
    }
}
