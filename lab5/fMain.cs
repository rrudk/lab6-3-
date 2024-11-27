using Lab04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab5
{
    public partial class fMain : Form
    {
        BindingSource studentsBindingSource = new BindingSource();

        public fMain()
        {
            InitializeComponent();
            btnExit.Alignment = ToolStripItemAlignment.Right;
            this.Load += fMain_Load;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvStudents.AutoGenerateColumns = false;

            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", Name = "Ім'я студента" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Surname", Name = "Прізвище" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Age", Name = "Вік" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "University", Name = "Університет" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Specialty", Name = "Спеціальність" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Year", Name = "Рік навчання" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Rating1", Name = "Оцінка №1" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Rating2", Name = "Оцінка №2" });
            gvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Rating3", Name = "Оцінка №3" });
            gvStudents.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Scholarship", Name = "Стипендія" });

            var students = new List<Student> { new Student("Олександр", "Рудик", 18, "ВНТУ", "ІСТ", 2024, 95, 90, 80, true) };

            studentsBindingSource.DataSource = students;
            gvStudents.DataSource = studentsBindingSource;

            EventArgs args = new EventArgs();
            OnResize(args);
            gvStudents.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            fStudent ft = new fStudent(newStudent);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                studentsBindingSource.Add(newStudent);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Student student = (Student)studentsBindingSource.Current;

            fStudent ft = new fStudent(student);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                studentsBindingSource[studentsBindingSource.Position] = student;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                studentsBindingSource.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                studentsBindingSource.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    try
                    {
                        foreach (Student student in studentsBindingSource.List)
                        {
                            sw.WriteLine($"{student.Name}\t{student.Surname}\t{student.Age}\t{student.University}\t{student.Specialty}" +
                                $"\t{student.Year}\t{student.Rating1}\t{student.Rating2}\t{student.Rating3}\t{student.Scholarship}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталась помилка: \n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.student)|*.student|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter bw = new BinaryWriter(saveFileDialog.OpenFile()))
                {
                    try
                    {
                        foreach (Student student in studentsBindingSource.List)
                        {
                            bw.Write(student.Name);
                            bw.Write(student.Surname);
                            bw.Write(student.Age);
                            bw.Write(student.University);
                            bw.Write(student.Specialty);
                            bw.Write(student.Year);
                            bw.Write(student.Rating1);
                            bw.Write(student.Rating2);
                            bw.Write(student.Rating3);
                            bw.Write(student.Scholarship);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталась помилка: \n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Прочитати дані у текстовому форматі",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentsBindingSource.Clear();

                using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                {
                    try
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] split = line.Split('\t');
                            Student student = new Student(split[0], split[1], int.Parse(split[2]), split[3], split[4], int.Parse(split[5]), 
                                int.Parse(split[6]), int.Parse(split[7]), int.Parse(split[8]), bool.Parse(split[9]));
                            studentsBindingSource.Add(student);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталась помилка: \n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файли даних (*.processor)|*.processor|All files (*.*)|*.*",
                Title = "Прочитати дані у бінарному форматі",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentsBindingSource.Clear();

                using (BinaryReader br = new BinaryReader(openFileDialog.OpenFile()))
                {
                    try
                    {
                        while (br.BaseStream.Position < br.BaseStream.Length)
                        {
                            Student student = new Student
                            {
                                Name = br.ReadString(),
                                Surname = br.ReadString(),
                                Age = br.ReadInt32(),
                                University = br.ReadString(),
                                Specialty = br.ReadString(),
                                Year = br.ReadInt32(),
                                Rating1 = br.ReadInt32(),
                                Rating2 = br.ReadInt32(),
                                Rating3 = br.ReadInt32(),
                                Scholarship = br.ReadBoolean()
                            };
                            studentsBindingSource.Add(student);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Сталась помилка: \n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}