using DB;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace db
{
    public partial class Form3 : Form
    {
        private string loginUser;
        private int teacherID;
        private string FIO_T;

        private int gr;
        private int number;

        private int controlID;

        private int r_ID;
        private string fio;
        private string resultName;


        public Form3(string data, int data2, string data3)
        {
            InitializeComponent();
            loginUser = data;
            teacherID = data2;
            FIO_T = data3;

            button1.Visible = false;
            groupNumber.Visible = false;
            label1.Visible = false;

            button3.Visible = false;

            dataGridView1.Visible = false;

            dataGridView2.Visible = false;

            dataGridView1.ReadOnly = true;

            // Disable user from adding new rows
            dataGridView2.AllowUserToAddRows = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UserName.Text = loginUser;
            Login.Text = FIO_T;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                }
                else
                {
                    MessageBox.Show("Такой группы нет");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group();
            dataGridView2.Visible = true;
            button3.Visible = true;
            edit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            TimeTable(number);
            seeResult.Visible = true;
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
                "WHERE\r\n  " +
                "teacher.id =" + teacherID;

            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@gId", teacherID); // Replace with the actual subject ID
                    adapter.Fill(table);
                    controlID = Convert.ToInt32(table.Rows[0]["cID"]);
                }
            }

            table.Columns.RemoveAt(table.Columns.Count - 1);

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
        }

        private void seeResult_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            groupNumber.Visible = true;
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(r_ID.ToString(), fio);

            //updateGrade(r_ID, fio, resultName);


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // Проверяем, если строка не новая и значение во втором столбце изменено
                if (!row.IsNewRow && row.Cells[2].Value != null && row.Cells[2].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    string result = row.Cells[2].Value.ToString();

                    int newResultId = getMarkId(result);

                    updateGrade(id, newResultId);

                }
            }
        }

        private List<string> allowedWords = new List<string> { "Отлично", "Хорошо", "Удовлетворительно", "Неудовлетворительно", "Неявка" }; // список разрешенных слов

        //private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    if (e.ColumnIndex == 1) // замените yourColumnIndex на индекс столбца, который вы хотите проверить
        //    {
        //        string value = e.FormattedValue.ToString().ToLower(); // получаем введенное значение в нижнем регистре

        //        if (!allowedWords.Contains(value))
        //        {
        //            e.Cancel = true; // отменяем ввод
        //            MessageBox.Show("Недопустимое слово. Введите другое слово из списка: apple, banana, orange.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}


        void updateGrade(int id, int newId)
        {
            Db db = new Db();

            string query = "UPDATE personal_result SET personal_resultcol = @newId WHERE name = @id";
           // MessageBox.Show($"{id.ToString()}, {newId.ToString()}");
            using (MySqlConnection connection = new MySqlConnection(db.getConnectionString()))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id.ToString());
                    command.Parameters.AddWithValue("@newId", newId.ToString());
                    command.ExecuteNonQuery();
                }
            }


        }
        int getMarkId(string resultName)
        {
            Db db = new Db();

            DataTable table = new DataTable();

            const string query = "SELECT id FROM result WHERE name = @resultName";

            using (MySqlConnection connection = new MySqlConnection(db.getConnectionString()))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@resultName", resultName);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        return Convert.ToInt32(table.Rows[0]["id"]);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }



        private void edit()
        {
            Db db3 = new Db();

            string query = "SELECT\r\n" +
                "student.id as sID,\r\n" +
                "student.name as FIO,\r\n" +
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
                "student.group_ =" + number + " && control.teacher =" + teacherID;

            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@tId", teacherID); // Replace with the actual subject ID
                    adapter.SelectCommand.Parameters.AddWithValue("@nId", number);
                    adapter.Fill(table);
                }
            }

            dataGridView2.DataSource = table;

            dataGridView2.Columns["FIO"].ReadOnly = true;
            dataGridView2.Columns[0].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
