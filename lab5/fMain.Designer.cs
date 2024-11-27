﻿namespace lab5
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bindScrStudents = new System.Windows.Forms.BindingSource(this.components);
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindScrStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnSaveAsText,
            this.btnSaveAsBinary,
            this.btnOpenFromText,
            this.btnOpenFromBinary,
            this.tsSeparator3,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 28);
            this.btnAdd.Text = "Додати запис про студента";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 52);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(34, 52);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 52);
            this.btnClear.Text = "Очистити дані";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsText.Image")));
            this.btnSaveAsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(34, 52);
            this.btnSaveAsText.Text = "Зберегти у текстовому форматі";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAsBinary.Image")));
            this.btnSaveAsBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(34, 52);
            this.btnSaveAsBinary.Text = "Зберегти у бінарному форматі";
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromText.Image")));
            this.btnOpenFromText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(34, 52);
            this.btnOpenFromText.Text = "Відкрити з тексту";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromBinary.Image")));
            this.btnOpenFromBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(34, 52);
            this.btnOpenFromBinary.Text = "Відкрити з бінарного файлу";
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 52);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvStudents
            // 
            this.gvStudents.AllowUserToAddRows = false;
            this.gvStudents.AllowUserToDeleteRows = false;
            this.gvStudents.AutoGenerateColumns = false;
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.DataSource = this.bindScrStudents;
            this.gvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStudents.Location = new System.Drawing.Point(0, 33);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.ReadOnly = true;
            this.gvStudents.RowHeadersWidth = 62;
            this.gvStudents.RowTemplate.Height = 28;
            this.gvStudents.Size = new System.Drawing.Size(800, 417);
            this.gvStudents.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvStudents);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота 5";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindScrStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.BindingSource bindScrStudents;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.ToolStripButton btnSaveAsText;
        private System.Windows.Forms.ToolStripButton btnSaveAsBinary;
        private System.Windows.Forms.ToolStripButton btnOpenFromText;
        private System.Windows.Forms.ToolStripButton btnOpenFromBinary;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

