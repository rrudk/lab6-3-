namespace lab5
{
    partial class fStudent
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbUniversity = new System.Windows.Forms.TextBox();
            this.tbSpecialty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRating3 = new System.Windows.Forms.TextBox();
            this.tbRating2 = new System.Windows.Forms.TextBox();
            this.tbRating1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbScholarship = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(271, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(147, 26);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вік студента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище студента";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ім\'я студента";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(271, 77);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(147, 26);
            this.tbSurname.TabIndex = 4;
            // 
            // tbUniversity
            // 
            this.tbUniversity.Location = new System.Drawing.Point(271, 161);
            this.tbUniversity.Name = "tbUniversity";
            this.tbUniversity.Size = new System.Drawing.Size(147, 26);
            this.tbUniversity.TabIndex = 6;
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Location = new System.Drawing.Point(271, 203);
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Size = new System.Drawing.Size(147, 26);
            this.tbSpecialty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Назва уніварситету\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Спеціальність";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Рік навчання";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbRating3);
            this.groupBox1.Controls.Add(this.tbRating2);
            this.groupBox1.Controls.Add(this.tbRating1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSpecialty);
            this.groupBox1.Controls.Add(this.tbUniversity);
            this.groupBox1.Controls.Add(this.tbSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Прізвище студента";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Оцінка 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Оцінка 2";
            // 
            // tbRating3
            // 
            this.tbRating3.Location = new System.Drawing.Point(271, 374);
            this.tbRating3.Name = "tbRating3";
            this.tbRating3.Size = new System.Drawing.Size(147, 26);
            this.tbRating3.TabIndex = 19;
            // 
            // tbRating2
            // 
            this.tbRating2.Location = new System.Drawing.Point(271, 332);
            this.tbRating2.Name = "tbRating2";
            this.tbRating2.Size = new System.Drawing.Size(147, 26);
            this.tbRating2.TabIndex = 18;
            // 
            // tbRating1
            // 
            this.tbRating1.Location = new System.Drawing.Point(271, 290);
            this.tbRating1.Name = "tbRating1";
            this.tbRating1.Size = new System.Drawing.Size(147, 26);
            this.tbRating1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Оцінка 1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(271, 248);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(147, 26);
            this.tbYear.TabIndex = 15;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(271, 119);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(147, 26);
            this.tbAge.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbScholarship);
            this.groupBox2.Location = new System.Drawing.Point(13, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стипендія";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chbScholarship
            // 
            this.chbScholarship.AutoSize = true;
            this.chbScholarship.Location = new System.Drawing.Point(44, 37);
            this.chbScholarship.Name = "chbScholarship";
            this.chbScholarship.Size = new System.Drawing.Size(249, 24);
            this.chbScholarship.TabIndex = 0;
            this.chbScholarship.Text = "Студент получає стипендію";
            this.chbScholarship.UseVisualStyleBackColor = true;
            this.chbScholarship.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(488, 39);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(488, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fStudent
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(644, 549);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fStudent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про нового студента";
            this.Load += new System.EventHandler(this.fStudent_Load);
            this.Click += new System.EventHandler(this.btnOk_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbUniversity;
        private System.Windows.Forms.TextBox tbSpecialty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox chbScholarship;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbRating1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRating3;
        private System.Windows.Forms.TextBox tbRating2;
    }
}