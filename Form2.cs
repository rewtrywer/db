using DB;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class Form2 : Form
    {
        private int receivedData;





        public Form2(/*int data*/)
        {
            InitializeComponent();
            //receivedData = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //UserName.Text += receivedData.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Subject_1_Click(object sender, EventArgs e)
        {
            Db db3 = new Db();
            string query = "SELECT " +
                 "group_.number AS groupNum, " +
                 "teacher.name as teachName, " +
                 "subject.name as subName, " +
                 "type_of_control.name as typeName, " +
                 "address.name as addressName, " +
                 "classroom.number as classroomName, " +
                 "date as dateName, " +
                 "time as timeName, " +
                 "faculty.name as facultyName " +
                 "FROM " +
                 "control " +
                 "INNER JOIN " +
                 "group_ ON control.group_ = group_.id " +
                 "INNER JOIN " +
                 "teacher ON control.teacher = teacher.id " +
                 "INNER JOIN " +
                 "subject ON control.subject = subject.id " +
                 "INNER JOIN " +
                 "type_of_control ON control.type = type_of_control.id " +
                 "INNER JOIN " +
                 "address ON control.address = address.id " +
                 "INNER JOIN " +
                 "classroom ON control.classroom = classroom.id " +
                 "INNER JOIN " +
                 "faculty ON control.faculty = faculty.id WHERE subject.id = '1'";

            //int status = 0;
            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                MySqlCommand command2 = new MySqlCommand(query, connection);
                connection.Open();
                //connection.Close();
                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {

                    result_1.Text += $"{reader["groupNum"]}{Environment.NewLine}" +
                $"{reader["teachName"]}{Environment.NewLine}" +
                $"{reader["subName"]}{Environment.NewLine}" +
                $"{reader["typeName"]}{Environment.NewLine}" +
                $"{reader["addressName"]}{Environment.NewLine}" +
                $"{reader["classroomName"]}{Environment.NewLine}" +
                $"{reader["dateName"]}{Environment.NewLine}" +
                $"{reader["timeName"]}{Environment.NewLine}" +
                $"{reader["facultyName"]}{Environment.NewLine}";
                }
                //connection.Close();
                reader.Close();
                //connection.Close();
            }
        }

        private void View_1_Click(object sender, EventArgs e)
        {
            //Db db3 = new Db();
            //string query = "SELECT " +
            //     "group_.number AS groupNum, " +
            //     "teacher.name as teachName, " +
            //     "subject.name as subName, " +
            //     "type_of_control.name as typeName, " +
            //     "address.name as addressName, " +
            //     "classroom.number as classroomName, " +
            //     "date as dateName, " +
            //     "time as timeName, " +
            //     "faculty.name as facultyName " +
            //     "FROM " +
            //     "control " +
            //     "INNER JOIN " +
            //     "group_ ON control.group_ = group_.id " +
            //     "INNER JOIN " +
            //     "teacher ON control.teacher = teacher.id " +
            //     "INNER JOIN " +
            //     "subject ON control.subject = subject.id " +
            //     "INNER JOIN " +
            //     "type_of_control ON control.type = type_of_control.id " +
            //     "INNER JOIN " +
            //     "address ON control.address = address.id " +
            //     "INNER JOIN " +
            //     "classroom ON control.classroom = classroom.id " +
            //     "INNER JOIN " +
            //     "faculty ON control.faculty = faculty.id WHERE subject.id = '1'";

            ////int status = 0;
            //using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            //{
            //    MySqlCommand command2 = new MySqlCommand(query, connection);
            //    connection.Open();
            //    //connection.Close();
            //    MySqlDataReader reader = command2.ExecuteReader();
            //    while (reader.Read())
            //    {

            //        result_1.Text += $"{reader["groupNum"]}{Environment.NewLine}" +
            //    $"{reader["teachName"]}{Environment.NewLine}" +
            //    $"{reader["subName"]}{Environment.NewLine}" +
            //    $"{reader["typeName"]}{Environment.NewLine}" +
            //    $"{reader["addressName"]}{Environment.NewLine}" +
            //    $"{reader["classroomName"]}{Environment.NewLine}" +
            //    $"{reader["dateName"]}{Environment.NewLine}" +
            //    $"{reader["timeName"]}{Environment.NewLine}" +
            //    $"{reader["facultyName"]}{Environment.NewLine}";
            //    }
            //    //connection.Close();
            //    reader.Close();
            //    //connection.Close();
            //}

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
