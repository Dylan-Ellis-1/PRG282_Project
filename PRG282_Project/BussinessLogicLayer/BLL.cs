using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BussinessLogicLayer
{
    class BLL
    {
        public BLL()
        {
        }

        //Login Form Data Validation
        public bool LogInValidation(string username, string password)
        {
            if (username != string.Empty && password != string.Empty)
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
            if (username != string.Empty && password != string.Empty && confirmPassword != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Main Form Data Validation
        public bool searchValidation(string number)
        {
            if (number != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool studentDataValidation(string studentNumber, string studentNameSurname, string picturePath, string datOfBirth, string Gender, string phoneNumber, string address, List<string> courses)
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

            if (studentNumber != string.Empty && studentNameSurname != string.Empty && picturePath != string.Empty && datOfBirth != string.Empty && Gender != string.Empty && phoneNumber != string.Empty && address != string.Empty && courses != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Courses Data Validation
        public bool courseDataValidation(string courseID, string courseName, string link, string description)
        {
            if (courseID != string.Empty && courseName != string.Empty && link != string.Empty && description != string.Empty)
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
