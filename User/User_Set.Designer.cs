namespace ToDo_List.User
{
    partial class User_Set
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
            lbl_id = new Label();
            label1 = new Label();
            label2 = new Label();
            tb_pw1 = new TextBox();
            tb_pw2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_Update = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(12, 18);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(30, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "id - ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "비밀 번호 - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "비밀 번호 확인 - ";
            // 
            // tb_pw1
            // 
            tb_pw1.Location = new Point(120, 64);
            tb_pw1.Name = "tb_pw1";
            tb_pw1.Size = new Size(293, 23);
            tb_pw1.TabIndex = 3;
            // 
            // tb_pw2
            // 
            tb_pw2.Location = new Point(120, 107);
            tb_pw2.Name = "tb_pw2";
            tb_pw2.Size = new Size(293, 23);
            tb_pw2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(120, 142);
            label3.Name = "label3";
            label3.Size = new Size(210, 15);
            label3.TabIndex = 5;
            label3.Text = "비밀 번호는 8자리 이상이어야 합니다";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(276, 18);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 6;
            label4.Text = "id는 변경할 수 없습니다";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(217, 177);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 7;
            btn_Update.Text = "변경";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(325, 177);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // User_Set
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 219);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Update);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_pw2);
            Controls.Add(tb_pw1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_id);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "User_Set";
            StartPosition = FormStartPosition.CenterParent;
            Text = "회원 정보 수정";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_id;
        private Label label1;
        private Label label2;
        private TextBox tb_pw1;
        private TextBox tb_pw2;
        private Label label3;
        private Label label4;
        private Button btn_Update;
        private Button btn_Cancel;
    }
}