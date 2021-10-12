using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    class Course
    {
        string courseCode, name, description, resourcesLink;

        public Course()
        {
        }

        public Course(string courseCode, string name, string description, string resourcesLink)
        {
            this.courseCode = courseCode;
            this.name = name;
            this.description = description;
            this.resourcesLink = resourcesLink;
        }

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string ResourcesLink { get => resourcesLink; set => resourcesLink = value; }
    }
}
