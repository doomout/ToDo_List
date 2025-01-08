namespace ToDo_List
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txt_ID = new TextBox();
            txt_PW = new TextBox();
            btn_signup = new Button();
            btn_login = new Button();
            chk_login = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "PW";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(44, 18);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(194, 23);
            txt_ID.TabIndex = 2;
            // 
            // txt_PW
            // 
            txt_PW.Location = new Point(43, 61);
            txt_PW.Name = "txt_PW";
            txt_PW.Size = new Size(194, 23);
            txt_PW.TabIndex = 3;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(64, 145);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(75, 23);
            btn_signup.TabIndex = 4;
            btn_signup.Text = "회원 가입";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(162, 145);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // chk_login
            // 
            chk_login.AutoSize = true;
            chk_login.Location = new Point(147, 107);
            chk_login.Name = "chk_login";
            chk_login.Size = new Size(90, 19);
            chk_login.TabIndex = 6;
            chk_login.Text = "로그인 유지";
            chk_login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 188);
            Controls.Add(chk_login);
            Controls.Add(btn_login);
            Controls.Add(btn_signup);
            Controls.Add(txt_PW);
            Controls.Add(txt_ID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "계획형 인간";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_ID;
        private TextBox txt_PW;
        private Button btn_signup;
        private Button btn_login;
        private CheckBox chk_login;
    }
}
