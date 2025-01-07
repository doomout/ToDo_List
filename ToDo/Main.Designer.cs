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
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            dtp_end = new DateTimePicker();
            btn_excel = new Button();
            label3 = new Label();
            label2 = new Label();
            dtp_start = new DateTimePicker();
            label1 = new Label();
            txt_select = new TextBox();
            dataGridView1 = new DataGridView();
            completed = new DataGridViewCheckBoxColumn();
            title = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaption;
            btn_add.Location = new Point(405, 34);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(109, 43);
            btn_add.TabIndex = 0;
            btn_add.Text = "할 일 등록";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_statistics
            // 
            btn_statistics.BackColor = Color.FromArgb(192, 255, 255);
            btn_statistics.Location = new Point(520, 34);
            btn_statistics.Name = "btn_statistics";
            btn_statistics.Size = new Size(109, 43);
            btn_statistics.TabIndex = 1;
            btn_statistics.Text = "통계 보기";
            btn_statistics.UseVisualStyleBackColor = false;
            // 
            // btn_set
            // 
            btn_set.BackColor = Color.FromArgb(255, 192, 255);
            btn_set.Location = new Point(750, 34);
            btn_set.Name = "btn_set";
            btn_set.Size = new Size(109, 43);
            btn_set.TabIndex = 2;
            btn_set.Text = "설정";
            btn_set.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(dtp_end);
            splitContainer1.Panel1.Controls.Add(btn_excel);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(dtp_start);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txt_select);
            splitContainer1.Panel1.Controls.Add(btn_statistics);
            splitContainer1.Panel1.Controls.Add(btn_set);
            splitContainer1.Panel1.Controls.Add(btn_add);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(877, 557);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(713, 9);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 11;
            label4.Text = "김재벌님 반갑습니다.";
            // 
            // dtp_end
            // 
            dtp_end.Format = DateTimePickerFormat.Short;
            dtp_end.Location = new Point(247, 51);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(105, 23);
            dtp_end.TabIndex = 10;
            dtp_end.Value = new DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // btn_excel
            // 
            btn_excel.BackColor = Color.FromArgb(0, 192, 0);
            btn_excel.Location = new Point(635, 34);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(109, 43);
            btn_excel.TabIndex = 9;
            btn_excel.Text = "엑셀 저장";
            btn_excel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "기간";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 57);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 7;
            label2.Text = "~";
            // 
            // dtp_start
            // 
            dtp_start.Format = DateTimePickerFormat.Short;
            dtp_start.Location = new Point(66, 51);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(105, 23);
            dtp_start.TabIndex = 5;
            dtp_start.Value = new DateTime(2025, 1, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "검색";
            // 
            // txt_select
            // 
            txt_select.Location = new Point(66, 12);
            txt_select.Name = "txt_select";
            txt_select.Size = new Size(286, 23);
            txt_select.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { completed, title, description, created_at });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(857, 433);
            dataGridView1.TabIndex = 0;
            // 
            // completed
            // 
            completed.HeaderText = "확인";
            completed.Name = "completed";
            completed.ReadOnly = true;
            completed.Width = 70;
            // 
            // title
            // 
            title.HeaderText = "할 일 요약";
            title.Name = "title";
            title.ReadOnly = true;
            title.Width = 200;
            // 
            // description
            // 
            description.HeaderText = "할 일 상세";
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 400;
            // 
            // created_at
            // 
            created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            created_at.HeaderText = "생성일";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(877, 453);
            panel1.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 557);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "메인창";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add;
        private Button btn_statistics;
        private Button btn_set;
        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txt_select;
        private DateTimePicker dtp_start;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private DataGridViewCheckBoxColumn completed;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn created_at;
        private Button btn_excel;
        private DateTimePicker dtp_end;
        private Label label4;
        private Panel panel1;
    }
}