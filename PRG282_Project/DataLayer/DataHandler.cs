using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG282_Project.DataLayer
{
    class DataHandler
    {
        public DataHandler()
        {
        }
                                        
        static string con = "Server=.; Initial Catalog= [Project]; Integrated Security=SSPI";

        SqlConnection cn = new SqlConnection(con);
        
        public DataTable getStudent()
        {
            string query = "SELECT * FROM Students";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable studentData = new DataTable();

            adapter.Fill(studentData);

            return studentData;
        }

        public List<string> GetModCodes()
        {
            SqlConnection cn = new SqlConnection(con);

            SqlDataAdapter adapter = new SqlDataAdapter("spGetCourses", con);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable studentData = new DataTable();

            adapter.Fill(studentData);
            List<string> CCodes = new List<string>();
            for (int k = 0; k< studentData.Rows.Count- 1; k++)
            {
                CCodes.Add(studentData.Rows[k][0].ToString());
            }
            return CCodes;
        }
        public DataTable getCourse()
        {
            string query = "SELECT * FROM Courses";

            SqlDataAdapter adapter = new SqlDataAdapter("spGetCoursesValues", con);

            DataTable courseData = new DataTable();

            adapter.Fill(courseData);

            return courseData;
        }

        public string updateStudent(Student student)
        {
            try
            {
                cn.Open();
            }
            catch (Exception eA)
            {
                MessageBox.Show("Error while connecting to the database: " + eA);
            }

            try
            {
                string query = "UPDATE Students SET NameSurname = '" + student.NameSurname + "', ImgPath = '" + student.ImagePath + "', StudentDOB = '" + student.Dob + "', Gender = '" + student.Gender + "', Phone = '" + student.Phone + "', Address_ = '" + student.Address + "' WHERE StudentNumber = '" + student.StudentNumber + "'";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();

                cn.Close();

                return "Student details have been updated";
            }
            catch (Exception eE)
            {
                return eE.Message + "\nStudent details could not be updated.";
            }
        }

        public string updateCourse(Course course)
        {
            try
            {
                cn.Open();
            }
            catch (Exception eA)
            {
                MessageBox.Show("Error while connecting to the database: " + eA);
            }

            try
            {
                string query = "UPDATE Courses SET ModName = '" + course.Name + "', ModDesc = '" + course.Description + "', Link = '" + course.ResourcesLink + "' WHERE ModCode = '" + course.CourseCode + "'";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();

                cn.Close();

                return "Module details have been updated.";
            }
            catch (Exception eE)
            {
                return eE.Message + "\nModule details could not be updated";
            }
        }

        public string deleteStudent(string id)
        {
            try
            {
                cn.Open();
            }
            catch (Exception eA)
            {
                MessageBox.Show("Error while connecting to the database: " + eA);
            }

            try
            {
                string query = "DELETE FROM Students WHERE StudentNumber = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();

                cn.Close();

                return "Deleted details of Student with Student number: " + id;
            }
            catch (Exception eE)
            {
                return eE.Message + "\nCould not delete the Student.";
            }

            
        }

        public string deleteCourse(string id)
        {
            try
            {
                cn.Open();
            }
            catch (Exception eA)
            {
                MessageBox.Show("Error while connecting to the database: " + eA);
            }

            try
            {
                string query = "DELETE FROM Courses WHERE ModCode = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();

                cn.Close();

                return "Deleted details of the Module with Module code: " + id;
            }
            catch (Exception eE)
            {
                return eE.Message + "\nCould not delete the Module details";
            }

            
        }

        public DataTable searchStudent(string id)
        {
            string query = "SELECT * FROM Students WHERE StudentNumber = '" + id + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable studentData = new DataTable();

            adapter.Fill(studentData);

            return studentData;
        }

        public DataTable searchCourse(string id)
        {
            string query = "SELECT * FROM Courses WHERE ModCode = '" + id + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable courdeData = new DataTable();

            adapter.Fill(courdeData);

            return courdeData;
        }

        public DataTable populateCourse(string id)
        {
            string query = "SELECT * FROM StudentCourses WHERE StudentNumber = '" + id + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataTable studentCourseData = new DataTable();

            adapter.Fill(studentCourseData);

            return studentCourseData;
        }

        public string addStudent(Student student)
        {
            try
            {
                cn.Open();
            }
            catch (Exception eA)
            {
                MessageBox.Show("Error while connecting to the database: " + eA);
            }

            try
            {
                string query = "INSERT INTO Students (StudentNumber, NameSurname, ImgPath, StudentDOB, Gender, Phone, Address_) VALUES ('" + student.StudentNumber + "', '" + student.NameSurname + "', '" + student.ImagePath + "', '" + student.Dob + "', '" + student.Gender + "', '" + student.Phone + "', '" + student.Address + "')";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();

                cn.Close();

                return "A new Student has been added.";
            }
            catch (Exception eE)
            {
                return eE.Message + "\nThe new Student could not be added.";
            } 
        }

        public string addCourse(Course course)
        {
            try
            {
                cn.Open();
            }
            catch (Exception eA)
            {
                MessageBox.Show("Error while connecting to the database: " + eA);
            }

            try
            {
                string query = "INSERT INTO Courses (ModCode, ModName, ModDesc, Link) VALUES ('" + course.CourseCode + "', '" + course.Name + "', '" + course.Description + "', '" + course.ResourcesLink + "')";

                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();

                cn.Close();

                return "A new Module has been added.";
            }
            catch (Exception eE)
            {
                return eE.Message + "\nThe new Module could not be added.";
            } 
        }
    }
}
