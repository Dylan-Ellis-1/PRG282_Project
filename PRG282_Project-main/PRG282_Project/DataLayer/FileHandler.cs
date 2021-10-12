using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.DataLayer
{
    class FileHandler
    {
        public FileHandler()
        {
        }

        public Boolean CheckUser(string username, string password)
        {
            List<string> data = new List<string>();
            data = File.ReadAllLines("LoginDetails.txt").ToList();

            bool found = false;

            foreach (string item in data)
            {
                string[] user = item.Split(',');

                if (user[0] == username && user[1] == password)
                {
                    found = true;
                }
            }

            return found;
        }

        public int AddUser(string username, string password, string confirmPass)
        {
            int errorNum = 0;

            if (username.Contains(" ") || username.Contains(","))
            {
                errorNum = 1;
                return errorNum;
            }

            if (password.Contains(" ") || password.Contains(","))
            {
                errorNum = 2;
                return errorNum;
            }

            if (password != confirmPass)
            {
                errorNum = 3;
                return errorNum;
            }

            List<string> data = new List<string>();
            data = File.ReadAllLines("LoginDetails.txt").ToList();

            foreach (string item in data)
            {
                if (item.Contains(username))
                {
                    errorNum = 4;
                    return errorNum;
                }
            }

            if (errorNum == 0)
            {
                string userData = username + ',' + password;

                using (StreamWriter sw = File.AppendText("LoginDetails.txt"))
                {
                    sw.WriteLine();
                    sw.WriteLine(userData);
                }
            }

            return errorNum;
        }
    }
}
