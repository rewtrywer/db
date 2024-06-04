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
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 200);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(154, 312);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(380, 450);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(boxUserPass);
            Controls.Add(boxUserLog);
            Name = "Form1";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxUserLog;
        private TextBox boxUserPass;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
    }
}
