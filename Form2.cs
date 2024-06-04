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
        private int gr;
        private int number;
        private string loginUser;
        private int controlID;
        private int studentID;
        private string studentName;
        private string FIO;


        public Form2(int data, string data2, int data3, string data4)
        {
            InitializeComponent();

            loginUser = data2;
            studentID = data3;
            FIO = data4;
            button2.Enabled = false;
            seeResult.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group();
            norm_res();
        }

        private void Group()
        {
            string groupNumber0 = groupNumber.Text;
            if (int.TryParse(groupNumber0, out gr))
            {
                Db db = new Db();
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT group_.id as Number From group_ WHERE group_.number = @uG", db.getConnection());

                command.Parameters.Add("@uG", MySqlDbType.VarChar).Value = gr;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                

                if (table.Rows.Count > 0)
                {
                    number = Convert.ToInt32(table.Rows[0]["Number"]);
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                    MessageBox.Show("Такой группы нет");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            TimeTable(number);
            seeResult.Visible = true;
            norm_res();
        }

        private void TimeTable(int group)
        {
            Db db3 = new Db();

            string query = "SELECT \r\n  " +
                "control.id as cID,\r\n  " +
                "group_.number AS groupNum,\r\n    " +
                "teacher.name as teachName,\r\n    " +
                "subject.name as subName,\r\n    " +
                "type_of_control.name as typeName,\r\n    " +
                "address.name as addressName,\r\n    " +
                "classroom.number as classroomName,\r\n    " +
                "date as dateName,\r\n    time as timeName,\r\n    " +
                "faculty.name as facultyName,\r\n    " +
                "group_.id as gID\r\n" +
                "FROM\r\n    " +
                "control\r\n        " +
                "INNER JOIN\r\n    " +
                "group_ ON control.group_ = group_.id\r\n\t\t" +
                "INNER JOIN\r\n    " +
                "teacher ON control.teacher = teacher.id\r\n\t\t" +
                "INNER JOIN\r\n\t" +
                "subject ON control.subject = subject.id\r\n\t\t" +
                "INNER JOIN\r\n\t" +
                "type_of_control ON control.type = type_of_control.id\r\n\t\t" +
                "INNER JOIN\r\n\t" +
                "address ON control.address = address.id\r\n\t\t" +
                "INNER JOIN\r\n\t" +
                "classroom ON control.classroom = classroom.id\r\n\t\t" +
                "INNER JOIN\r\n\t" +
                "faculty ON control.faculty = faculty.id\r\n    " +
                "WHERE\r\n    " +
                "group_.id =" + number;

            DataTable table = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@gId", number); // Replace with the actual subject ID
                    adapter.Fill(table);
                    controlID = Convert.ToInt32(table.Rows[0]["cID"]);
                }
            }
     
            table.Columns.RemoveAt(table.Columns.Count - 1);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UserName.Text = loginUser;
            Login.Text = FIO;
        }

        private void E()
        {
            Db db3 = new Db();

            string query = "SELECT\r\n" +
                "result.name as resultName_per_res\r\n" +
                "FROM\r\n" +
                "personal_result\r\n" +
                "INNER JOIN\r\n" +
                "result ON personal_result.personal_resultcol = result.id\r\n" +
                "INNER JOIN\r\n" +
                "control ON personal_result.control = control.id\r\n" +
                "INNER JOIN\r\n" +
                "student ON personal_result.name = student.id\r\n" +
                "Where\r\n" +
                "personal_result.name =" + studentID; //+ "&& control.id =" + controlID;

            DataTable table = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@studentID", studentID);
                    adapter.SelectCommand.Parameters.AddWithValue("@controlID", controlID);
                    adapter.Fill(table);
                }
            }
            dataGridView2.DataSource = table;
            dataGridView2.Visible = true;
        }

        private void norm_res()
        {
            Db db = new Db();
            string query = "SELECT student.group_ as groupNum FROM personal_result INNER JOIN student ON personal_result.name = student.id WHERE personal_result.name ="+studentID;
            DataTable table = new DataTable();
            int id = 0;
            using (MySqlConnection connection = new MySqlConnection(db.getConnectionString()))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["groupNum"]);
                        }
                    }
                }
            }
            if (id != number)
            {
               seeResult.Visible = false;
               dataGridView2.Visible = false;
            }
        }

        private void seeResult_Click(object sender, EventArgs e)
        {
            E();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}