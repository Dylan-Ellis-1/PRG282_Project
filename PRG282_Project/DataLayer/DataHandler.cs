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
                                        
        string con = "Server=.; Initial Catalog= Project; Integrated Security=SSPI";
        
        //Get
        public DataTable getStudent()
        {
            SqlConnection cn = new SqlConnection(con);

            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents", con);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable studentData = new DataTable();

            adapter.Fill(studentData);

            return studentData;
        }
        public DataTable getCourse()
        {
            SqlConnection cn = new SqlConnection(con);

            SqlDataAdapter adapter = new SqlDataAdapter("spGetCoursesValues", con);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable studentData = new DataTable();

            adapter.Fill(studentData);

            return studentData;
        }

        public List<string> getModCodes()
        {

            List<string> Courses = new List<string>();
            SqlConnection cn = new SqlConnection(con);

            SqlDataAdapter adapter = new SqlDataAdapter("spGetModCodes", con);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable studentData = new DataTable();

            adapter.Fill(studentData);
            for (int k = 0; k < studentData.Rows.Count - 1; k++)
            {
                Courses.Add(studentData.Rows[k][0].ToString());
            }
            return Courses;
        }

        //Update
        public string updateStudent(Student student, List<string> courses)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateStudents", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    cmd.Parameters.AddWithValue("@NameSurname", student.NameSurname);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@DOB", student.Dob);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@ImgPath", student.ImagePath);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteJoingCourses", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudnetNumber", student.StudentNumber);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                foreach (string course in courses)
                {
                    using (SqlConnection cn = new SqlConnection(con))
                    {
                        SqlCommand cmd = new SqlCommand("spAddStudentCourses", cn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                        cmd.Parameters.AddWithValue("@ModCode", course);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }

                return "Student data updated successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to update Student data:\n\n" + eA.Message;
            }
        }

        public string updateCourse(Course course)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spUpdateCourses", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ModCode", course.CourseCode);
                    cmd.Parameters.AddWithValue("@ModName", course.Name);
                    cmd.Parameters.AddWithValue("@ModDesc", course.Description);
                    cmd.Parameters.AddWithValue("@Link", course.ResourcesLink);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                return "Course data updated successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to update Course data:\n\n" + eA.Message;
            }
        }

        //Delete

        public string deleteStudent(string id)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteStudents", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudnetNumber", id);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                return "Student data deleted successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to delete Student data:\n\n" + eA.Message;
            }
        }

        public string deleteCourse(string id)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteCourses", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CourseCode", id);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                return "Course data deleted successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to delete Course data:\n\n" + eA.Message;
            }
        }

        public string deleteCourseForStudent(string courseID, string studentID)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spDeleteCoursesStudent", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CourseCode", courseID);
                    cmd.Parameters.AddWithValue("@StudentNumber", studentID);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                return "Course data for Student deleted successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to delete Course data of the Student:\n\n" + eA.Message;
            }
        }

        //Search
        public DataTable searchStudent(string id)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudents", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudnetNumber", id);

                cn.Open();

                DataTable data = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    data.Load(dr);

                    return data;
                }
            }
        }

        public DataTable searchCourse(string id)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spSearchCourses", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CourseCode", id);

                cn.Open();

                DataTable data = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    data.Load(dr);

                    return data;
                }
            }
        }

        public DataTable populateCourse(string id)
        {
            using (SqlConnection cn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spPopulateCourses", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudnetID", id);

                cn.Open();

                DataTable data = new DataTable();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    data.Load(dr);

                    return data;
                }
            }
        }

        //Add
        public string addStudent(Student student, List<string> courses)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spAddStudents", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    cmd.Parameters.AddWithValue("@NameSurname", student.NameSurname);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@DOB", student.Dob);
                    cmd.Parameters.AddWithValue("@Phone", student.Phone);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@ImgPath", student.ImagePath);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                foreach (string course in courses)
                {
                    using (SqlConnection cn = new SqlConnection(con))
                    {
                        SqlCommand cmd = new SqlCommand("spAddStudentCourses", cn);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                        cmd.Parameters.AddWithValue("@ModCode", course);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }

                return "Student data added successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to add Student data:\n\n" + eA.Message;
            }
        }

        public string addCourse(Course course)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(con))
                {
                    SqlCommand cmd = new SqlCommand("spAddCourses", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ModCode", course.CourseCode);
                    cmd.Parameters.AddWithValue("@ModName", course.Name);
                    cmd.Parameters.AddWithValue("@ModDesc", course.Description);
                    cmd.Parameters.AddWithValue("@Link", course.ResourcesLink);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                return "Course data added successfully.";
            }
            catch (Exception eA)
            {
                return "The following error was encountered while trying to add Course data:\n\n" + eA.Message;
            }
        }
    }
}
