namespace db
{
    partial class Form4
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
            exit = new Button();
            Login = new Label();
            UserName = new Label();
            add_user = new Button();
            add_subject = new Button();
            add_exam = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(12, 56);
            exit.Name = "exit";
            exit.Size = new Size(64, 34);
            exit.TabIndex = 31;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 9F);
            Login.Location = new Point(12, 27);
            Login.Name = "Login";
            Login.Size = new Size(50, 20);
            Login.TabIndex = 30;
            Login.Text = "label1";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 9F);
            UserName.Location = new Point(12, 7);
            UserName.Name = "UserName";
            UserName.Size = new Size(50, 20);
            UserName.TabIndex = 29;
            UserName.Text = "label1";
            // 
            // add_user
            // 
            add_user.Location = new Point(147, 7);
            add_user.Name = "add_user";
            add_user.Size = new Size(174, 29);
            add_user.TabIndex = 32;
            add_user.Text = "Добавить аудиторию";
            add_user.UseVisualStyleBackColor = true;
            add_user.Click += add_user_Click;
            // 
            // add_subject
            // 
            add_subject.Location = new Point(327, 7);
            add_subject.Name = "add_subject";
            add_subject.Size = new Size(174, 29);
            add_subject.TabIndex = 33;
            add_subject.Text = "Добавить предмет";
            add_subject.UseVisualStyleBackColor = true;
            add_subject.Click += add_subject_Click;
            // 
            // add_exam
            // 
            add_exam.Location = new Point(507, 7);
            add_exam.Name = "add_exam";
            add_exam.Size = new Size(174, 29);
            add_exam.TabIndex = 34;
            add_exam.Text = "Добавить группу";
            add_exam.UseVisualStyleBackColor = true;
            add_exam.Click += add_exam_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 227);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(580, 120);
            button3.Name = "button3";
            button3.Size = new Size(101, 34);
            button3.TabIndex = 37;
            button3.Text = "Применить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(580, 120);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 38;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(580, 120);
            button2.Name = "button2";
            button2.Size = new Size(101, 34);
            button2.TabIndex = 39;
            button2.Text = "Применить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(742, 402);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(add_exam);
            Controls.Add(add_subject);
            Controls.Add(add_user);
            Controls.Add(exit);
            Controls.Add(Login);
            Controls.Add(UserName);
            Name = "Form4";
            Text = "Администратор";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label Login;
        private Label UserName;
        private Button add_user;
        private Button add_subject;
        private Button add_exam;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}