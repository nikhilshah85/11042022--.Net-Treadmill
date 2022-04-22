using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
namespace Serialization_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
           

            bool moreOperation = true;
            while (moreOperation)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Banking");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Check Account Details");
                Console.WriteLine("3. Break");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        #region XML Serialization          
                        Accounts accObj = ReadNeWAccountDetails();

                        FileStream fileStream = new FileStream(accObj.accNo + ".xml", FileMode.Create, FileAccess.Write);
                        XmlSerializer serializer = new XmlSerializer(typeof(Accounts));
                        serializer.Serialize(fileStream, accObj);

                        Console.WriteLine("Object Savings In XML File");
                        fileStream.Close();
                        Console.ReadLine();
                        #endregion
                        break;
                    case 2:
                        #region XML DeSerialization
                        Console.WriteLine("Enter Account Number");
                        int accno = Convert.ToInt32(Console.ReadLine());
                        Accounts existingAccount;
                        if (File.Exists(accno + ".xml"))
                        {


                            FileStream fs = new FileStream(accno + ".xml", FileMode.Open, FileAccess.Read);
                            XmlSerializer deserializer = new XmlSerializer(typeof(Accounts));
                            existingAccount = (Accounts)deserializer.Deserialize(fs);

                            Console.WriteLine("Account Number " + existingAccount.accNo);
                            Console.WriteLine("Account Name " + existingAccount.accName);
                            Console.WriteLine("Account Type " + existingAccount.accType);
                            Console.WriteLine("Account Balance " + existingAccount.accBalance);
                            Console.WriteLine("Account Is Active " + existingAccount.accIsActive);
                            Console.WriteLine("Account Email " + existingAccount.accEmail);

                            fs.Close();
                        }
                        else
                        {
                            Console.WriteLine("Account No Not Found");
                        }
                        Console.ReadLine();
                        #endregion
                        break;
                    case 3:
                        moreOperation = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choiice");

                        break;
                }
            }
           
            #region Binary Serialization - Create new Account



            //FileStream fileObj = new FileStream(accObj.accNo + ".txt", FileMode.Create, FileAccess.Write);
            //BinaryFormatter formatter = new BinaryFormatter();

            //formatter.Serialize(fileObj, accObj);

            //fileObj.Close();

            //Console.WriteLine("Object Saved to system");
            #endregion

            #region Binary Deserialization
            // Console.WriteLine("Enter Your Account Number");
            // int userAccountNo = Convert.ToInt32(Console.ReadLine());

            // FileStream fs = new FileStream(userAccountNo + ".txt", FileMode.Open, FileAccess.Read);
            // BinaryFormatter binaryFormatter = new BinaryFormatter();
            //Accounts existingAccount = (Accounts) binaryFormatter.Deserialize(fs);

            // Console.WriteLine("Account Number "  + existingAccount.accNo);
            // Console.WriteLine("Account Name " + existingAccount.accName);
            // Console.WriteLine("Account Type " + existingAccount.accType);
            // Console.WriteLine("Account Balance " + existingAccount.accBalance);
            // Console.WriteLine("Account Is Active " + existingAccount.accIsActive);
            // Console.WriteLine("Account Email " + existingAccount.accEmail);

            // fs.Close();
            #endregion

            

            

            #region SOAP Serialization


            //FileStream fileStream = new FileStream(accObj.accNo + ".xml", FileMode.Create, FileAccess.Write);
            //SoapFormatter soapFormatter = new SoapFormatter();
            //soapFormatter.Serialize(fileStream, accObj);
            //Console.WriteLine("Account Saved Successfully");

            //fileStream.Close();
            #endregion

            #region SOAP Deserialization
            //Console.WriteLine("Enter Account Number");
            //int accno = Convert.ToInt32(Console.ReadLine());
            //Accounts existingAccount;
            //if (File.Exists(accno + ".xml"))
            //{


            //    FileStream fs = new FileStream(accno + ".xml", FileMode.Open, FileAccess.Read);
            //    SoapFormatter serializer = new SoapFormatter();
            //    existingAccount = (Accounts)serializer.Deserialize(fs);

            //    Console.WriteLine("Account Number " + existingAccount.accNo);
            //    Console.WriteLine("Account Name " + existingAccount.accName);
            //    Console.WriteLine("Account Type " + existingAccount.accType);
            //    Console.WriteLine("Account Balance " + existingAccount.accBalance);
            //    Console.WriteLine("Account Is Active " + existingAccount.accIsActive);
            //    Console.WriteLine("Account Email " + existingAccount.accEmail);

            //    fs.Close();
            //}
            //else
            //{
            //    Console.WriteLine("Account No Not Found");
            //}
            #endregion
        }

        public static Accounts ReadNeWAccountDetails()
        {
            Accounts accObj = new Accounts();
            Console.WriteLine("Enter Account Number");
            accObj.accNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Name");
            accObj.accName = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            accObj.accType = Console.ReadLine();
            Console.WriteLine("Enter Account Balance");
            accObj.accBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Account Email");
            accObj.accEmail = Console.ReadLine();
            Console.WriteLine("Enter Account IsActive");
            accObj.accIsActive = Convert.ToBoolean(Console.ReadLine());

            return accObj;
        }
    }
}
