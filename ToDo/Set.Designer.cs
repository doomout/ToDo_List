namespace ToDo_List.ToDo
{
    partial class Set
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "할 일 요약(필수)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(392, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(124, 325);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "반복 요일 선택";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 72);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "일요일";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(26, 110);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "월요일";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(26, 145);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(62, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "화요일";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(26, 182);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(62, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "수요일";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(26, 219);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(62, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "목요일";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(26, 255);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(62, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "금요일";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(26, 292);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(62, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "토요일";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(26, 33);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(50, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "전체";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 104);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 3;
            label2.Text = "할 일 상세(생략 가능)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 131);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 145);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(27, 320);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 295);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "실행일";
            // 
            // button2
            // 
            button2.Location = new Point(262, 296);
            button2.Name = "button2";
            button2.Size = new Size(105, 52);
            button2.TabIndex = 8;
            button2.Text = "저장";
            button2.UseVisualStyleBackColor = true;
            // 
            // Set
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 371);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Set";
            Text = "반복 설정";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button2;
    }
}