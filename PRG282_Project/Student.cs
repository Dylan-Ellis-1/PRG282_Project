using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    class Student
    {
        string studentNumber, nameSurname, gender, phone, address, imagePath, dob;

        public Student()
        {
        }

        public Student(string studentNumber, string nameSurname, string gender, string phone, string address,  string imagePath, string dob)
        {
            this.studentNumber = studentNumber;
            this.nameSurname = nameSurname;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.dob = dob;
            this.imagePath = imagePath;
        }

        public string StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string NameSurname { get => nameSurname; set => nameSurname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Dob { get => dob; set => dob = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
    }
}
