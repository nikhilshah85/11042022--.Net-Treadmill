using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileIO_demo
{
    internal class FileOperations
    {

        public bool Login(string userName, string password)
        {
            FileStream fs = null;

            if (userName == "Admin")
            {
                fs = new FileStream("admincredentials.txt", FileMode.Open, FileAccess.Read);
            }
            else
            {
                fs = new FileStream("usercredentials.txt", FileMode.Open, FileAccess.Read);
            }

            StreamReader sr = new StreamReader(fs);
            string uName = sr.ReadLine();
            string pwd = sr.ReadLine();

            sr.Close();
            fs.Close();

            if (uName == userName && pwd ==password)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }
    }
}
