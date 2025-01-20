namespace ToDo_List.ToDo
{
    partial class Update_View
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
            txt_Title = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Description = new TextBox();
            label3 = new Label();
            mCal_create = new MonthCalendar();
            groupBox1 = new GroupBox();
            rdo_false = new RadioButton();
            rdo_true = new RadioButton();
            btn_Update = new Button();
            btn_close = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Title
            // 
            txt_Title.Location = new Point(12, 36);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(334, 23);
            txt_Title.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "할 일";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "할 일 상세";
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(12, 110);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(334, 330);
            txt_Description.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "생성일";
            // 
            // mCal_create
            // 
            mCal_create.Location = new Point(376, 36);
            mCal_create.Name = "mCal_create";
            mCal_create.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo_false);
            groupBox1.Controls.Add(rdo_true);
            groupBox1.Location = new Point(376, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 118);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "달성 여부";
            // 
            // rdo_false
            // 
            rdo_false.AutoSize = true;
            rdo_false.Checked = true;
            rdo_false.Location = new Point(38, 77);
            rdo_false.Name = "rdo_false";
            rdo_false.Size = new Size(61, 19);
            rdo_false.TabIndex = 1;
            rdo_false.TabStop = true;
            rdo_false.Text = "미달성";
            rdo_false.UseVisualStyleBackColor = true;
            // 
            // rdo_true
            // 
            rdo_true.AutoSize = true;
            rdo_true.Location = new Point(38, 32);
            rdo_true.Name = "rdo_true";
            rdo_true.Size = new Size(49, 19);
            rdo_true.TabIndex = 0;
            rdo_true.Text = "달성";
            rdo_true.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(376, 379);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(99, 61);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "저장";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(497, 379);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(99, 61);
            btn_close.TabIndex = 9;
            btn_close.Text = "취소";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Update_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 457);
            Controls.Add(btn_close);
            Controls.Add(btn_Update);
            Controls.Add(groupBox1);
            Controls.Add(mCal_create);
            Controls.Add(label3);
            Controls.Add(txt_Description);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Title);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Update_View";
            StartPosition = FormStartPosition.CenterParent;
            Text = "할 일 수정";
            Load += Update_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Title;
        private Label label1;
        private Label label2;
        private TextBox txt_Description;
        private Label label3;
        private MonthCalendar mCal_create;
        private GroupBox groupBox1;
        private RadioButton rdo_false;
        private RadioButton rdo_true;
        private Button btn_Update;
        private Button btn_close;
    }
}