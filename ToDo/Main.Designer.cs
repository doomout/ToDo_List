namespace ToDo_List.ToDo
{
    partial class Main
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
            btn_add = new Button();
            btn_statistics = new Button();
            btn_set = new Button();
            lbl_welcome = new Label();
            dtp_end = new DateTimePicker();
            btn_excel = new Button();
            label3 = new Label();
            label2 = new Label();
            dtp_start = new DateTimePicker();
            label1 = new Label();
            txt_select = new TextBox();
            dgv_ToDoList = new DataGridView();
            is_completed = new DataGridViewCheckBoxColumn();
            title = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btn_UserSet = new Button();
            btn_Logout = new Button();
            panel1 = new Panel();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_ToDoList).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaption;
            btn_add.Location = new Point(416, 47);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(109, 43);
            btn_add.TabIndex = 0;
            btn_add.Text = "할 일 등록";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_statistics
            // 
            btn_statistics.BackColor = Color.FromArgb(192, 255, 255);
            btn_statistics.Location = new Point(531, 47);
            btn_statistics.Name = "btn_statistics";
            btn_statistics.Size = new Size(109, 43);
            btn_statistics.TabIndex = 1;
            btn_statistics.Text = "통계 보기";
            btn_statistics.UseVisualStyleBackColor = false;
            // 
            // btn_set
            // 
            btn_set.BackColor = Color.FromArgb(255, 192, 255);
            btn_set.Location = new Point(761, 47);
            btn_set.Name = "btn_set";
            btn_set.Size = new Size(109, 43);
            btn_set.TabIndex = 2;
            btn_set.Text = "반복 설정";
            btn_set.UseVisualStyleBackColor = false;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Location = new Point(547, 13);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(122, 15);
            lbl_welcome.TabIndex = 11;
            lbl_welcome.Text = "김재벌님 반갑습니다.";
            // 
            // dtp_end
            // 
            dtp_end.Format = DateTimePickerFormat.Short;
            dtp_end.Location = new Point(258, 64);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(105, 23);
            dtp_end.TabIndex = 10;
            dtp_end.Value = new DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // btn_excel
            // 
            btn_excel.BackColor = Color.FromArgb(0, 192, 0);
            btn_excel.Location = new Point(646, 47);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(109, 43);
            btn_excel.TabIndex = 9;
            btn_excel.Text = "엑셀 저장";
            btn_excel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 70);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "기간";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 70);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "~";
            // 
            // dtp_start
            // 
            dtp_start.Format = DateTimePickerFormat.Short;
            dtp_start.Location = new Point(77, 64);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(105, 23);
            dtp_start.TabIndex = 5;
            dtp_start.Value = new DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "검색";
            // 
            // txt_select
            // 
            txt_select.Location = new Point(77, 25);
            txt_select.Name = "txt_select";
            txt_select.Size = new Size(286, 23);
            txt_select.TabIndex = 3;
            // 
            // dgv_ToDoList
            // 
            dgv_ToDoList.AllowUserToAddRows = false;
            dgv_ToDoList.AllowUserToDeleteRows = false;
            dgv_ToDoList.BorderStyle = BorderStyle.Fixed3D;
            dgv_ToDoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ToDoList.Columns.AddRange(new DataGridViewColumn[] { is_completed, title, description, created_at });
            dgv_ToDoList.Dock = DockStyle.Fill;
            dgv_ToDoList.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_ToDoList.Location = new Point(0, 0);
            dgv_ToDoList.Margin = new Padding(10);
            dgv_ToDoList.MultiSelect = false;
            dgv_ToDoList.Name = "dgv_ToDoList";
            dgv_ToDoList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ToDoList.Size = new Size(877, 385);
            dgv_ToDoList.TabIndex = 0;
            dgv_ToDoList.CellDoubleClick += dgv_ToDoList_CellDoubleClick;
            // 
            // is_completed
            // 
            is_completed.DataPropertyName = "is_completed";
            is_completed.HeaderText = "달성";
            is_completed.Name = "is_completed";
            is_completed.Resizable = DataGridViewTriState.True;
            is_completed.Width = 70;
            // 
            // title
            // 
            title.DataPropertyName = "title";
            title.HeaderText = "할 일";
            title.Name = "title";
            title.Width = 200;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "할 일 상세";
            description.Name = "description";
            description.Width = 400;
            // 
            // created_at
            // 
            created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "생성일";
            created_at.Name = "created_at";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_UserSet);
            panel2.Controls.Add(btn_Logout);
            panel2.Controls.Add(lbl_welcome);
            panel2.Controls.Add(txt_select);
            panel2.Controls.Add(dtp_end);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(btn_excel);
            panel2.Controls.Add(btn_set);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_statistics);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtp_start);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 108);
            panel2.TabIndex = 4;
            // 
            // btn_UserSet
            // 
            btn_UserSet.Location = new Point(697, 9);
            btn_UserSet.Name = "btn_UserSet";
            btn_UserSet.Size = new Size(75, 23);
            btn_UserSet.TabIndex = 13;
            btn_UserSet.Text = "정보수정";
            btn_UserSet.UseVisualStyleBackColor = true;
            btn_UserSet.Click += btn_UserSet_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(790, 9);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(75, 23);
            btn_Logout.TabIndex = 12;
            btn_Logout.Text = "로그아웃";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(progressBar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 493);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 64);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 27);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "달성율";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(459, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(394, 23);
            progressBar1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_ToDoList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(877, 385);
            panel3.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 557);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterParent;
            Text = "메인창";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ToDoList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add;
        private Button btn_statistics;
        private Button btn_set;
        private Label label1;
        private TextBox txt_select;
        private DateTimePicker dtp_start;
        private DataGridView dgv_ToDoList;
        private Label label3;
        private Label label2;
        private Button btn_excel;
        private DateTimePicker dtp_end;
        private Label lbl_welcome;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private ProgressBar progressBar1;
        private Button btn_Logout;
        private Button btn_UserSet;
        private DataGridViewCheckBoxColumn is_completed;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn created_at;
    }
}