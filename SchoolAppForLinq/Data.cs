using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolAppForLinq
{
    class Data
    {
        String ConnectionString = "Server=HSC-5YQM6Y2; Database=School; Integrated Security=true;";
        public List<Students> Get()
        {
            List<Students> students = new List<Students>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Students", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Students student = new Students();
                    student.ID = Convert.ToInt32(rdr["ID"]);
                    student.Grade = Convert.ToInt32(rdr["Grade"]);
                    student.Name = rdr["Name"].ToString();

                    students.Add(student);
                }
                con.Close();
            }
            return students;
        }
        public List<Subjects> Get1()
        {
            List<Subjects> subjects = new List<Subjects>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Subjects", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Subjects subject = new Subjects();
                    subject.ID = Convert.ToInt32(rdr["ID"]);
                    subject.SubjectName = rdr["SubjectName"].ToString();
                    subject.Teacher = rdr["Teacher"].ToString();

                    subjects.Add(subject);
                }
                con.Close();
            }
            return subjects;
        }
        public List<Marks> Get2()
        {
            List<Marks> marks = new List<Marks>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Marks", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Marks mark = new Marks();
                    mark.ID = Convert.ToInt32(rdr["ID"]);
                    mark.Maths = Convert.ToInt32(rdr["Maths"]);
                    mark.Social = Convert.ToInt32(rdr["Social"]);
                    mark.Science = Convert.ToInt32(rdr["Science"]);
                    mark.English = Convert.ToInt32(rdr["English"]);
                    mark.Computers = Convert.ToInt32(rdr["Computers"]);

                    marks.Add(mark);
                }
                con.Close();
            }
            return marks;
        }
    }
}