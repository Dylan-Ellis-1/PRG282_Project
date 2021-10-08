using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project
{
    class FileHandler
    {
        string[,] UserDetails;
        public string OutputString = "";
        public bool addedUser = false;
        public bool LoggedIn = false;
        public string UName = "";
        public string UPass = "";
        public string[,] ReadUsers()
        {
            List<string> data = new List<string>();
            data = File.ReadAllLines("LoginDetails.txt").ToList();

            string[] Temp = new string[2];
            int lim = data.Count() - 1;

            for (int k = 0; k < lim; k++)
            {
                Temp = data[k].Split(',');
                UserDetails[k, 0] = Temp[0];
                UserDetails[k, 1] = Temp[1];
            }
            return UserDetails;
        }

        public void AddUser(string NUserName, string NPassword)
        {
            string[,] Users = ReadUsers();
            bool Found = false;

            int UCount = Users.Length;
            for (int i = 0; i < UCount - 1; i++)
            {
                if (NUserName == Users[i, 0])
                {
                    Found = true;
                }
            }
            if (Found == true)
            {
                OutputString = "User Already Exists, create new Username";
            }
            else
            {
                UserDetails[UCount, 0] = NUserName;
                UserDetails[UCount, 1] = NPassword;

                File.Delete("UserDetails.txt");
                File.Create("UserDetails.txt");
                List<string> lines = new List<string>();
                for (int i = 0; i < UserDetails.Length; i++)
                {
                    lines.Add(UserDetails[i, 0] + "," + UserDetails[i, 1]);
                }
                File.WriteAllLines("UserDetails.txt", lines);
                addedUser = true;
                OutputString = "User Added Successfully";
            }
        }

        public void LoginF(string NUserName, string NPassword)
        {
            string[,] Users = ReadUsers();
            int Index = -1;

            int UCount = Users.Length;
            for (int i = 0; i < UCount - 1; i++)
            {
                if (NUserName == Users[i, 0])
                {
                    Index = i;
                }
            }
            if (Index < 0)
            {
                OutputString = "User was not found, Add new User or Revise Username entered";
            }
            else
            if (Users[Index, 1] != NPassword)
            {
                OutputString = "The Wrong Password was given for the related UserName";
            }
            else
            {
                UName = Users[Index, 0];
                UPass = Users[Index, 1];
                LoggedIn = true;
            }
        }
    }
}
