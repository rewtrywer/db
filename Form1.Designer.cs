namespace db
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            boxUserLog = new TextBox();
            boxUserPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // boxUserLog
            // 
            boxUserLog.Location = new Point(135, 99);
            boxUserLog.Name = "boxUserLog";
            boxUserLog.Size = new Size(125, 27);
            boxUserLog.TabIndex = 0;
            boxUserLog.TextChanged += textBox1_TextChanged;
            // 
            // boxUserPass
            // 
            boxUserPass.Location = new Point(135, 197);
            boxUserPass.Name = "boxUserPass";
            boxUserPass.Size = new Size(125, 27);
            boxUserPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 102);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 200);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "пароль";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(154, 312);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 211);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(477, 276);
            button1.Name = "button1";
            button1.Size = new Size(101, 65);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boxUserPass);
            Controls.Add(boxUserLog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxUserLog;
        private TextBox boxUserPass;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private Label label3;
        private Button button1;
    }
}
