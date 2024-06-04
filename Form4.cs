using DB;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace db
{
    public partial class Form4 : Form
    {
        private string loginUser;
        private int adminID;
        private string FIO_A;

        int status__ = 0;

        public Form4(string data, int data2, string data3)
        {
            InitializeComponent();
            loginUser = data;
            adminID = data2;
            FIO_A = data3;



            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            //dataGridView2.RowsAdded += dataGridView2_RowsAdded;

            dataGridView1.Visible = false;

            button1.Visible = false;
            button3.Visible = false;
            button2.Visible = false;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UserName.Text = loginUser;
            Login.Text = FIO_A;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void add_subject_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Db db3 = new Db();

            string query = "SELECT * FROM subject ORDER BY id ASC";

            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }

            dataGridView1.DataSource = table;

            button3.Visible = true;
            button1.Visible = false;

            button2.Visible = false;

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) // добавление номера строки(id)
        {
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString(); // Add row number
                dataGridView1.Rows[i].Cells[0].ReadOnly = true; // Make the first column read-only
            }
        }



        private void updateGrade(int id, string subject) //добавление предмат
        {
            Db db = new Db();
            string queryCheckExisting = "SELECT COUNT(*) FROM subject WHERE id = @id";
            string queryInsert = "INSERT INTO subject (id, name) VALUES (@id, @subject)";

            using (MySqlConnection connection = new MySqlConnection(db.getConnectionString()))
            {
                connection.Open();

                // Check if a row with the given id already exists
                using (MySqlCommand checkCommand = new MySqlCommand(queryCheckExisting, connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", id.ToString());
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count == 0) // If the row with the given id does not exist
                    {
                        // Insert a new row
                        using (MySqlCommand insertCommand = new MySqlCommand(queryInsert, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@id", id.ToString());
                            insertCommand.Parameters.AddWithValue("@subject", subject);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Проверяем, если строка не новая и значение во втором столбце изменено
                if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    string subject = row.Cells[1].Value.ToString();

                    updateGrade(id, subject);

                }
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            //AddDataToDatabase();
            // AddDataToDatabase2();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Проверяем, если строка не новая и значение во втором столбце изменено
                if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    int subject = Convert.ToInt32(row.Cells[1].Value.ToString());

                    updateGrade2(id, subject);

                }
            }



        }




        private void add_user_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Db db3 = new Db();

            string query = "SELECT * FROM classroom ORDER BY id ASC";

            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }

            dataGridView1.DataSource = table;
            button1.Visible = true;

            button3.Visible = false;
            button2.Visible = false;

        }

        private void updateGrade2(int id, int subject) //добавление предмат
        {
            Db db = new Db();
            string queryCheckExisting = "SELECT COUNT(*) FROM classroom WHERE id = @id";
            string queryInsert = "INSERT INTO classroom (id, number) VALUES (@id, @subject)";

            using (MySqlConnection connection = new MySqlConnection(db.getConnectionString()))
            {
                connection.Open();

                // Check if a row with the given id already exists
                using (MySqlCommand checkCommand = new MySqlCommand(queryCheckExisting, connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", id.ToString());
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count == 0) // If the row with the given id does not exist
                    {
                        // Insert a new row
                        using (MySqlCommand insertCommand = new MySqlCommand(queryInsert, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@id", id.ToString());
                            insertCommand.Parameters.AddWithValue("@subject", subject);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

        }

        private void add_exam_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Db db3 = new Db();

            string query = "SELECT * FROM group_ ORDER BY id ASC";

            DataTable table = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(db3.getConnectionString()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }

            dataGridView1.DataSource = table;

            button2.Visible = true;
            button1.Visible = false;
            button3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Проверяем, если строка не новая и значение во втором столбце изменено
                if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    int subject = Convert.ToInt32(row.Cells[1].Value.ToString());

                    updateGrade3(id, subject);

                }
            }

        }

        private void updateGrade3(int id, int subject) //добавление предмат
        {
            Db db = new Db();
            string queryCheckExisting = "SELECT COUNT(*) FROM group_ WHERE id = @id";
            string queryInsert = "INSERT INTO group_ (id, number) VALUES (@id, @subject)";

            using (MySqlConnection connection = new MySqlConnection(db.getConnectionString()))
            {
                connection.Open();

                // Check if a row with the given id already exists
                using (MySqlCommand checkCommand = new MySqlCommand(queryCheckExisting, connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", id.ToString());
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count == 0) // If the row with the given id does not exist
                    {
                        // Insert a new row
                        using (MySqlCommand insertCommand = new MySqlCommand(queryInsert, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@id", id.ToString());
                            insertCommand.Parameters.AddWithValue("@subject", subject);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
