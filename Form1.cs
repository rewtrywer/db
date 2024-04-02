using DB;
using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Drawing;
using MySqlX.XDevAPI.Common;

namespace db
{


    public partial class Form1 : Form
    {
        private int userID = 0;
        public Form1()
        {
            InitializeComponent();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = boxUserLog.Text;
            string passUser = boxUserPass.Text;

            //int userID = 0;

            Db db = new Db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT authorization.id as UserID FROM `authorization`  WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы вошли как " + loginUser);
                userID = Convert.ToInt32(table.Rows[0]["UserID"]);
            }
            else
                MessageBox.Show("Такого пользователя нет");



            Db db2 = new Db();
            string query = "SELECT status.id as statusName FROM users INNER JOIN status ON users.status = status.id WHERE `login` = " + userID;
            int status = 0;
            using (MySqlConnection connection = new MySqlConnection(db2.getConnectionString()))
            {
                connection.Open();
                MySqlCommand command2 = new MySqlCommand(query, connection);


                MySqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    

                    //MessageBox.Show(reader["statusName"].ToString());
                    status = Convert.ToInt32(reader["statusName"]);
                    MessageBox.Show(status.ToString());
                }

                reader.Close();
                // connection.Close();
            }

            prava(status/* userID*/);


        }
        enum item1
        {
            student = 1,
            teacher,
            admin
        }

        public void prava(int dostup /*int userID*/)
        {
            item1 selection = (item1)dostup;
            switch (selection)
            {
                case item1.student:

                    string loginUser = boxUserLog.Text;
                    // Переход от Form1 к Form2
                    Form2 form2 = new Form2(/*userID*/);
                    //this.Hide(); // Скрыть текущую форму (Form1)
                    
                    form2.Show(); // Отобразить новую форму (Form2)
                                  // this.Close();             // form2.student(userID, loginUser);                             // НЕПОНЯТНО В КАКОЕ МЕСТО ПОСТАВИТЬ

                    break;

                case item1.teacher:



                    break;
                case item1.admin:
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            //     "faculty ON control.faculty = faculty.id; ";

            ////int status = 0;
            //using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            //{
            //    MySqlCommand command2 = new MySqlCommand(query, connection);
            //    connection.Open();
            //    //connection.Close();
            //    MySqlDataReader reader = command2.ExecuteReader();
            //    while (reader.Read())
            //    {

            //        label1.Text += $"{reader["groupNum"]}, {reader["teachName"]}, " +
            //                      $"{reader["subName"]}, {reader["typeName"]}, " +
            //                      $"{reader["addressName"]}, {reader["classroomName"]}, " +
            //                      $"{reader["dateName"]}, {reader["timeName"]}, " +
            //                      $"{reader["facultyName"]}{Environment.NewLine}";
            //        //connection.Close();
            //    }
            //    //connection.Close();
            //    reader.Close();
            //    //connection.Close();
            //}
        }
    }
}
