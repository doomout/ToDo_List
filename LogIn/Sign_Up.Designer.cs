namespace ToDo_List
{
    partial class Sign_Up
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_id = new TextBox();
            txt_pw1 = new TextBox();
            txt_pw2 = new TextBox();
            btn_signUp = new Button();
            lbl_PWCheck = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "비밀번호";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "비밀번호 확인";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(12, 27);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(226, 23);
            txt_id.TabIndex = 3;
            // 
            // txt_pw1
            // 
            txt_pw1.Location = new Point(12, 98);
            txt_pw1.Name = "txt_pw1";
            txt_pw1.PasswordChar = '*';
            txt_pw1.Size = new Size(226, 23);
            txt_pw1.TabIndex = 4;
            // 
            // txt_pw2
            // 
            txt_pw2.Location = new Point(12, 153);
            txt_pw2.Name = "txt_pw2";
            txt_pw2.PasswordChar = '*';
            txt_pw2.Size = new Size(226, 23);
            txt_pw2.TabIndex = 5;
            // 
            // btn_signUp
            // 
            btn_signUp.Location = new Point(163, 219);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(75, 23);
            btn_signUp.TabIndex = 6;
            btn_signUp.Text = "회원 가입";
            btn_signUp.UseVisualStyleBackColor = true;
            btn_signUp.Click += btn_signUp_Click;
            // 
            // lbl_PWCheck
            // 
            lbl_PWCheck.AutoSize = true;
            lbl_PWCheck.ForeColor = Color.Red;
            lbl_PWCheck.Location = new Point(108, 189);
            lbl_PWCheck.Name = "lbl_PWCheck";
            lbl_PWCheck.Size = new Size(134, 15);
            lbl_PWCheck.TabIndex = 7;
            lbl_PWCheck.Text = "비밀 번호는 8자리 이상";
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 254);
            Controls.Add(lbl_PWCheck);
            Controls.Add(btn_signUp);
            Controls.Add(txt_pw2);
            Controls.Add(txt_pw1);
            Controls.Add(txt_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Sign_Up";
            StartPosition = FormStartPosition.CenterParent;
            Text = "회원가입";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_id;
        private TextBox txt_pw1;
        private TextBox txt_pw2;
        private Button btn_signUp;
        private Label lbl_PWCheck;
    }
}