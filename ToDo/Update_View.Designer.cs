namespace ToDo_List.ToDo
{
    partial class updateView
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
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            mCalCreate = new MonthCalendar();
            groupBox1 = new GroupBox();
            rdoFalse = new RadioButton();
            rdoTrue = new RadioButton();
            btnUpdateOrAdd = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 36);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(334, 23);
            txtTitle.TabIndex = 0;
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
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(334, 330);
            txtDescription.TabIndex = 3;
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
            // mCalCreate
            // 
            mCalCreate.Location = new Point(376, 36);
            mCalCreate.Name = "mCalCreate";
            mCalCreate.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoFalse);
            groupBox1.Controls.Add(rdoTrue);
            groupBox1.Location = new Point(376, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 118);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "달성 여부";
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Checked = true;
            rdoFalse.Location = new Point(38, 77);
            rdoFalse.Name = "rdoFalse";
            rdoFalse.Size = new Size(61, 19);
            rdoFalse.TabIndex = 1;
            rdoFalse.TabStop = true;
            rdoFalse.Text = "미달성";
            rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            rdoTrue.AutoSize = true;
            rdoTrue.Location = new Point(38, 32);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new Size(49, 19);
            rdoTrue.TabIndex = 0;
            rdoTrue.Text = "달성";
            rdoTrue.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrAdd
            // 
            btnUpdateOrAdd.Location = new Point(376, 379);
            btnUpdateOrAdd.Name = "btnUpdateOrAdd";
            btnUpdateOrAdd.Size = new Size(99, 61);
            btnUpdateOrAdd.TabIndex = 8;
            btnUpdateOrAdd.Text = "저장";
            btnUpdateOrAdd.UseVisualStyleBackColor = true;
            btnUpdateOrAdd.Click += btn_UpdateOrAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(497, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 61);
            btnClose.TabIndex = 9;
            btnClose.Text = "취소";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btn_close_Click;
            // 
            // updateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 457);
            Controls.Add(btnClose);
            Controls.Add(btnUpdateOrAdd);
            Controls.Add(groupBox1);
            Controls.Add(mCalCreate);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "updateView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "할 일 수정";
            Load += Update_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private MonthCalendar mCalCreate;
        private GroupBox groupBox1;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
        private Button btnUpdateOrAdd;
        private Button btnClose;
    }
}