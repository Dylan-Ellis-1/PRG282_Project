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

        public void ConfirmFile() 
        {
            if (File.Exists("LoginDetails.txt") == false)
            {
                File.Create("LoginDetails.txt");
            }
        }
        public string[,] ReadUsers()
        {
            ConfirmFile();
            List<string> data = new List<string>();
            data = File.ReadAllLines("LoginDetails.txt").ToList(); //Come back to

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
        public int AddUser(string NUserName, string NPassword, string CPassword)
        {
            int ErrorT = 0;
            if (NUserName.Contains(" ")||NUserName.Contains(","))
            {
                ErrorT = 1;
                return ErrorT;
            }
            
            if (NPassword.Contains(" ")||NPassword.Contains(","))
            {
                ErrorT = 2;
                return ErrorT;
            }

            if (NPassword != CPassword)
            {
                ErrorT = 3;
                return ErrorT;
            }
            
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
                ErrorT = 4;
                return ErrorT;
            }
            else
            {
                UserDetails[UCount, 0] = NUserName;
                UserDetails[UCount, 1] = NPassword;

                List<string> lines = new List<string>();
                for (int i = 0; i < UserDetails.Length; i++)
                {
                    lines.Add(UserDetails[i, 0] + "," + UserDetails[i, 1]);
                }
                File.WriteAllLines("UserDetails.txt", lines);
                addedUser = true;
            }
            return ErrorT;
        }
        public int LoginF(string NUserName, string NPassword)
        {
            int ErrorN = 0;
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
                ErrorN= 1;
            }
            else
            if (Users[Index, 1] != NPassword)
            {
                ErrorN =2;
            }
            return ErrorN;
            
        }
    }
}
