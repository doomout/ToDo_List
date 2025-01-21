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
            btnAdd = new Button();
            btnStatistics = new Button();
            btnSet = new Button();
            lbl_welcome = new Label();
            dtpEnd = new DateTimePicker();
            btnExcel = new Button();
            label3 = new Label();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            label1 = new Label();
            txtSelect = new TextBox();
            dgvTodoList = new DataGridView();
            is_completed = new DataGridViewCheckBoxColumn();
            title = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnUserSet = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTodoList).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(416, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "할 일 등록";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btn_add_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.FromArgb(192, 255, 255);
            btnStatistics.Location = new Point(531, 47);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(109, 43);
            btnStatistics.TabIndex = 1;
            btnStatistics.Text = "통계 보기";
            btnStatistics.UseVisualStyleBackColor = false;
            // 
            // btnSet
            // 
            btnSet.BackColor = Color.FromArgb(255, 192, 255);
            btnSet.Location = new Point(761, 47);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(109, 43);
            btnSet.TabIndex = 2;
            btnSet.Text = "반복 설정";
            btnSet.UseVisualStyleBackColor = false;
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
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(258, 64);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(105, 23);
            dtpEnd.TabIndex = 10;
            dtpEnd.Value = new DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(0, 192, 0);
            btnExcel.Location = new Point(646, 47);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(109, 43);
            btnExcel.TabIndex = 9;
            btnExcel.Text = "엑셀 저장";
            btnExcel.UseVisualStyleBackColor = false;
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
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(77, 64);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(105, 23);
            dtpStart.TabIndex = 5;
            dtpStart.Value = new DateTime(2025, 1, 7, 0, 0, 0, 0);
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
            // txtSelect
            // 
            txtSelect.Location = new Point(77, 25);
            txtSelect.Name = "txtSelect";
            txtSelect.Size = new Size(286, 23);
            txtSelect.TabIndex = 3;
            // 
            // dgvTodoList
            // 
            dgvTodoList.AllowUserToAddRows = false;
            dgvTodoList.AllowUserToDeleteRows = false;
            dgvTodoList.BorderStyle = BorderStyle.Fixed3D;
            dgvTodoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodoList.Columns.AddRange(new DataGridViewColumn[] { is_completed, title, description, created_at });
            dgvTodoList.Dock = DockStyle.Fill;
            dgvTodoList.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvTodoList.Location = new Point(0, 0);
            dgvTodoList.Margin = new Padding(10);
            dgvTodoList.MultiSelect = false;
            dgvTodoList.Name = "dgvTodoList";
            dgvTodoList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodoList.Size = new Size(877, 385);
            dgvTodoList.TabIndex = 0;
            dgvTodoList.CellDoubleClick += dgv_ToDoList_CellDoubleClick;
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
            panel2.Controls.Add(btnUserSet);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lbl_welcome);
            panel2.Controls.Add(txtSelect);
            panel2.Controls.Add(dtpEnd);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(btnSet);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnStatistics);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpStart);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 108);
            panel2.TabIndex = 4;
            // 
            // btnUserSet
            // 
            btnUserSet.Location = new Point(697, 9);
            btnUserSet.Name = "btnUserSet";
            btnUserSet.Size = new Size(75, 23);
            btnUserSet.TabIndex = 13;
            btnUserSet.Text = "정보수정";
            btnUserSet.UseVisualStyleBackColor = true;
            btnUserSet.Click += btn_UserSet_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(790, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "로그아웃";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btn_Logout_Click;
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
            panel3.Controls.Add(dgvTodoList);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "메인창";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTodoList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnStatistics;
        private Button btnSet;
        private Label label1;
        private TextBox txtSelect;
        private DateTimePicker dtpStart;
        private DataGridView dgvTodoList;
        private Label label3;
        private Label label2;
        private Button btnExcel;
        private DateTimePicker dtpEnd;
        private Label lbl_welcome;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private ProgressBar progressBar1;
        private Button btnLogout;
        private Button btnUserSet;
        private DataGridViewCheckBoxColumn is_completed;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn created_at;
    }
}