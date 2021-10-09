using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    class Student
    {
        int studentNumber;
        string name, surname, gender, phone, address, courseCode, imagePath;
        DateTime dob;

        public Student()
        {
        }

        public Student(int studentNumber, string name, string surname, string gender, string phone, string address, string courseCode, string imagePath, DateTime dob)
        {
            this.studentNumber = studentNumber;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
            this.courseCode = courseCode;
            this.dob = dob;
            this.imagePath = imagePath;
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
    }
}
