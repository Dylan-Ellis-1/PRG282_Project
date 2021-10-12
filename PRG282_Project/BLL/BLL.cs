using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BLL
{
    class BLL
    {
        public BLL() { }

        //Login Form Data Validation
        public bool LogInValidation(string username, string password)
        {
            if (username != null && password != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool newUserValidation(string username, string password, string confirmPassword)
        {
            if (username != null && password != null && confirmPassword == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Main Form Data Validation
        public bool searchValidation(string studentNumber)
        {
            foreach (char c in studentNumber)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            if (studentNumber != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool groupBox3Validation(string studentNumber, string studentNameSurname, string picturePath, DateTime datOfBirth, string Gender, string phoneNumber, string address, string courses)
        {
            foreach (char c in studentNumber)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            foreach (char c in phoneNumber)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            if (studentNumber != null && studentNameSurname != null && picturePath != null && datOfBirth != null && Gender != null && phoneNumber != null && address != null && courses != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Courses Data Validation
        public bool groupBox1Validation(string courseName)
        {
            if (courseName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool groupBox2Validation(string courseID, string courseName, string link, string description)
        {
            foreach (char c in courseID)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            if (courseID != null && courseName != null && link != null && description != null)
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
