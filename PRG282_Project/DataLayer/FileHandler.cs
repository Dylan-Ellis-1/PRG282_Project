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

        // Method used to get an image from the comuter and place it in the Programs bin folder
        public string AddPicture(string FilePath)
        {
            string[] Npath = FilePath.Split(Path.DirectorySeparatorChar);
            string Lpath = Npath[Npath.Length - 1];

            //Create a unique Name for file
            if (File.Exists(Lpath))
            {
                bool Found = true;
                int k = 1;
                while (Found == true)
                {
                    string temp = Lpath;
                    string[] path = temp.Split('.');
                    path[0] = path[0] + k.ToString();
                    temp = path[0] + path[1];
                    if (File.Exists(temp))
                    {
                        k++;
                    }
                    else
                    {
                        Lpath = temp;
                        Found = false;
                    }
                }
            }

            File.Copy(FilePath, @"Images\" + Lpath);

            return Lpath;
        }

        // Method to check if user login details are correct
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

        // Method to add a new user to the login textfile
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
