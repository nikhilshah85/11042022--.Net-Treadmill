using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileIO_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region FileIO Demo 1:
            //FileStream fs = new FileStream("myinfo.txt", FileMode.Create, FileAccess.Write);  //this is your book
            //StreamWriter sw = new StreamWriter(fs); //this is the pen 
            //sw.WriteLine("I am from Mumbai");
            //sw.WriteLine("I am a .Net trainer");
            //sw.WriteLine("I am Doing a traininig right now");
            //sw.WriteLine("I am from India");

            ////File is an external resource to applcation
            ////we should always close the files

            /////first close the pen
            ////close the book

            //sw.Close(); //pen is closed
            //fs.Close(); //book is closed


            //Console.WriteLine("Details written to file");
            #endregion

            

            FileOperations ops = new FileOperations();
            Console.WriteLine("Enter User Name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();   


            bool result = ops.Login(username, password);

            if (result)
            {
                Console.WriteLine("Welcome to Banking System  " + username);

                #region Dynamic Demo Read and Write

                //Console.WriteLine("Welcome To my File System");
                //Console.WriteLine("1.Create New file");
                //Console.WriteLine("2. Read a file");

                //int choice = Convert.ToInt32(Console.ReadLine());

                //switch (choice)
                //{
                //    case 1:
                //        #region Write to file

                //        Console.WriteLine("Enter Your First Name");
                //        string name = Console.ReadLine();

                //        FileStream newFile = new FileStream(name + ".txt", FileMode.Create, FileAccess.Write);
                //        StreamWriter writer = new StreamWriter(newFile);

                //        string details = "info";
                //        bool moreDetails = true;

                //        while (moreDetails)
                //        {
                //            details = Console.ReadLine();
                //            writer.WriteLine(details);
                //            if (details == "")
                //            {
                //                moreDetails = false;
                //                writer.Close();
                //                newFile.Close();
                //            }
                //        }

                //        Console.WriteLine("Thank you for all the information, your are details are save in " + name + ".txt");
                //        #endregion
                //        break;
                //    case 2:
                //        #region Read File
                //        Console.WriteLine("Enter your Name");
                //        string filename = Console.ReadLine();

                //        if (File.Exists(filename + ".txt"))
                //        {

                //            FileStream fs = new FileStream(filename + ".txt", FileMode.Open, FileAccess.Read);
                //            StreamReader sr = new StreamReader(fs);
                //            Console.WriteLine(sr.ReadToEnd());

                //            sr.Close();
                //            fs.Close();
                //        }
                //        else
                //        {
                //            Console.WriteLine("File not found in system");
                //        }
                //        #endregion
                //        break;
                //   default:
                //        Console.WriteLine("Incorrect optin");
                //        break;
                //}
                #endregion

            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }

        }
    }
}
