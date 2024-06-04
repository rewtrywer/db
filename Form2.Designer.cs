namespace db
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserName = new Label();
            Login = new Label();
            result_1 = new Label();
            groupNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            seeResult = new Button();
            label1 = new Label();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 9F);
            UserName.Location = new Point(12, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(50, 20);
            UserName.TabIndex = 0;
            UserName.Text = "label1";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 9F);
            Login.Location = new Point(12, 29);
            Login.Name = "Login";
            Login.Size = new Size(50, 20);
            Login.TabIndex = 1;
            Login.Text = "label1";
            // 
            // result_1
            // 
            result_1.AutoSize = true;
            result_1.Location = new Point(32, 313);
            result_1.Name = "result_1";
            result_1.Size = new Size(0, 20);
            result_1.TabIndex = 12;
            // 
            // groupNumber
            // 
            groupNumber.Location = new Point(1136, 13);
            groupNumber.Name = "groupNumber";
            groupNumber.Size = new Size(69, 27);
            groupNumber.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(1227, 9);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 19;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1229, 58);
            button2.Name = "button2";
            button2.Size = new Size(119, 36);
            button2.TabIndex = 20;
            button2.Text = "Расписание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1169, 312);
            dataGridView1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1178, 176);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(169, 312);
            dataGridView2.TabIndex = 22;
            // 
            // seeResult
            // 
            seeResult.Location = new Point(1228, 109);
            seeResult.Name = "seeResult";
            seeResult.Size = new Size(119, 36);
            seeResult.TabIndex = 23;
            seeResult.Text = "Результаты";
            seeResult.UseVisualStyleBackColor = true;
            seeResult.Click += seeResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(960, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 24;
            label1.Text = "Введите номер группы";
            // 
            // exit
            // 
            exit.Location = new Point(12, 58);
            exit.Name = "exit";
            exit.Size = new Size(64, 34);
            exit.TabIndex = 25;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1361, 519);
            Controls.Add(exit);
            Controls.Add(label1);
            Controls.Add(seeResult);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupNumber);
            Controls.Add(result_1);
            Controls.Add(Login);
            Controls.Add(UserName);
            Name = "Form2";
            Text = "Студент";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private Label Login;
        private Label result_1;
        private TextBox groupNumber;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button seeResult;
        private Label label1;
        private Button exit;
    }
}