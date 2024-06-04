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
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace db
{


    public partial class Form1 : Form
    {
        private int userID = 0;
        string loginUser = "";
        int studentID = 0;
        string FIO = "";
        int teacherID = 0;
        string FIO_T = "";
        int adminID = 0;
        string FIO_A = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginUser = boxUserLog.Text;
            string passUser = boxUserPass.Text;

            Db db = new Db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT authorization.id as UserID " +
                                                    "FROM " +
                                                    "authorization " +
                                                    "WHERE " +
                                                    "authorization.login = @uL AND authorization.password = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
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
                    //MessageBox.Show(status.ToString());
                }

                reader.Close();
                // connection.Close();
            }
            prava(status, userID);
        }
        enum item1
        {
            student = 1,
            teacher,
            admin
        }

        public void prava(int dostup, int userID)
        {
            item1 selection = (item1)dostup;
            string loginUser = boxUserLog.Text;
            switch (selection)
            {
                case item1.student:

                    Db db3 = new Db();
                    string query2 = "SELECT student.id as studentID, student.name as FIO FROM `authorization` INNER JOIN student ON authorization.id = student.login  WHERE authorization.id =" + userID;

                    using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
                    {
                        connection.Open();
                        MySqlCommand command2 = new MySqlCommand(query2, connection);

                        MySqlDataReader reader = command2.ExecuteReader();
                        while (reader.Read())
                        {
                            studentID = Convert.ToInt32(reader["studentID"]);
                            FIO = Convert.ToString(reader["FIO"]);
                        }
                        reader.Close();
                    }

                    Form2 form2 = new Form2(userID, loginUser, studentID, FIO);

                    form2.Show();

                    break;

                case item1.teacher:

                    Db db4 = new Db();
                    string query3 = "SELECT teacher.id as teacherID, teacher.name as FIO_T FROM `authorization` INNER JOIN teacher ON authorization.id = teacher.login  WHERE authorization.id =" + userID;

                    using (MySqlConnection connection = new MySqlConnection(db4.getConnectionString()))
                    {
                        connection.Open();
                        MySqlCommand command2 = new MySqlCommand(query3, connection);

                        MySqlDataReader reader = command2.ExecuteReader();
                        while (reader.Read())
                        {
                            teacherID = Convert.ToInt32(reader["teacherID"]);
                            FIO_T = Convert.ToString(reader["FIO_T"]);
                        }
                        reader.Close();
                    }

                    Form3 form3 = new Form3(loginUser, teacherID, FIO_T);
                    form3.Show();

                    break;
                case item1.admin:
                    Db db5 = new Db();
                    string query4 = "SELECT users.id as adminID, users.name as FIO_A FROM `authorization` INNER JOIN users ON authorization.id = users.login  WHERE authorization.id =" + userID;

                    using (MySqlConnection connection = new MySqlConnection(db5.getConnectionString()))
                    {
                        connection.Open();
                        MySqlCommand command2 = new MySqlCommand(query4, connection);

                        MySqlDataReader reader = command2.ExecuteReader();
                        while (reader.Read())
                        {
                            adminID = Convert.ToInt32(reader["adminID"]);
                            FIO_A = Convert.ToString(reader["FIO_A"]);
                        }
                        reader.Close();
                    }

                    Form4 form4 = new Form4(loginUser, adminID, FIO_A);
                    form4.Show();
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
