namespace db
{
    partial class Form3
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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupNumber = new TextBox();
            seeResult = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(12, 58);
            exit.Name = "exit";
            exit.Size = new Size(64, 34);
            exit.TabIndex = 28;
            exit.Text = "Выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 9F);
            Login.Location = new Point(12, 29);
            Login.Name = "Login";
            Login.Size = new Size(50, 20);
            Login.TabIndex = 27;
            Login.Text = "label1";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 9F);
            UserName.Location = new Point(12, 9);
            UserName.Name = "UserName";
            UserName.Size = new Size(50, 20);
            UserName.TabIndex = 26;
            UserName.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(795, 119);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 32;
            label1.Text = "Введите номер группы";
            // 
            // button2
            // 
            button2.Location = new Point(1062, 7);
            button2.Name = "button2";
            button2.Size = new Size(119, 36);
            button2.TabIndex = 31;
            button2.Text = "Расписание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1062, 112);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 30;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupNumber
            // 
            groupNumber.Location = new Point(971, 116);
            groupNumber.Name = "groupNumber";
            groupNumber.Size = new Size(69, 27);
            groupNumber.TabIndex = 29;
            // 
            // seeResult
            // 
            seeResult.Location = new Point(1062, 58);
            seeResult.Name = "seeResult";
            seeResult.Size = new Size(119, 36);
            seeResult.TabIndex = 33;
            seeResult.Text = "Редактировать";
            seeResult.UseVisualStyleBackColor = true;
            seeResult.Click += seeResult_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1169, 312);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 496);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(279, 312);
            dataGridView2.TabIndex = 35;
            // 
            // button3
            // 
            button3.Location = new Point(324, 496);
            button3.Name = "button3";
            button3.Size = new Size(120, 34);
            button3.TabIndex = 36;
            button3.Text = "Применить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1195, 960);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(seeResult);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupNumber);
            Controls.Add(exit);
            Controls.Add(Login);
            Controls.Add(UserName);
            Name = "Form3";
            Text = "Преподаватель";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label Login;
        private Label UserName;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox groupNumber;
        private Button seeResult;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button3;
    }
}