namespace LatihanADONET
{
    partial class Form1
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
            this.btnTesKoneksi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAngkatanInsert = new System.Windows.Forms.TextBox();
            this.txtNamaInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNpmInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCariUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAngkatanUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNpmUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCariDelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAngkatanDelete = new System.Windows.Forms.TextBox();
            this.txtNamaDelete = new System.Windows.Forms.TextBox();
            this.txtNpmDelete = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTesKoneksi
            // 
            this.btnTesKoneksi.Location = new System.Drawing.Point(24, 23);
            this.btnTesKoneksi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTesKoneksi.Name = "btnTesKoneksi";
            this.btnTesKoneksi.Size = new System.Drawing.Size(150, 44);
            this.btnTesKoneksi.TabIndex = 0;
            this.btnTesKoneksi.Text = "Tes Koneksi";
            this.btnTesKoneksi.UseVisualStyleBackColor = true;
            this.btnTesKoneksi.Click += new System.EventHandler(this.btnTesKoneksi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 79);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvwMahasiswa);
            this.tabPage1.Controls.Add(this.btnTampilkanData);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(806, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(12, 67);
            this.lvwMahasiswa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(778, 367);
            this.lvwMahasiswa.TabIndex = 1;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(12, 12);
            this.btnTampilkanData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(224, 44);
            this.btnTampilkanData.TabIndex = 0;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInsert);
            this.tabPage2.Controls.Add(this.txtAngkatanInsert);
            this.tabPage2.Controls.Add(this.txtNamaInsert);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtNpmInsert);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(806, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(130, 165);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 44);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAngkatanInsert
            // 
            this.txtAngkatanInsert.Location = new System.Drawing.Point(130, 115);
            this.txtAngkatanInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAngkatanInsert.Name = "txtAngkatanInsert";
            this.txtAngkatanInsert.Size = new System.Drawing.Size(146, 31);
            this.txtAngkatanInsert.TabIndex = 2;
            // 
            // txtNamaInsert
            // 
            this.txtNamaInsert.Location = new System.Drawing.Point(130, 65);
            this.txtNamaInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNamaInsert.Name = "txtNamaInsert";
            this.txtNamaInsert.Size = new System.Drawing.Size(660, 31);
            this.txtNamaInsert.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Angkatan";
            // 
            // txtNpmInsert
            // 
            this.txtNpmInsert.Location = new System.Drawing.Point(130, 12);
            this.txtNpmInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNpmInsert.Name = "txtNpmInsert";
            this.txtNpmInsert.Size = new System.Drawing.Size(146, 31);
            this.txtNpmInsert.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCariUpdate);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.txtAngkatanUpdate);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtNamaUpdate);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtNpmUpdate);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(806, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UPDATE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCariUpdate
            // 
            this.btnCariUpdate.Location = new System.Drawing.Point(288, 8);
            this.btnCariUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCariUpdate.Name = "btnCariUpdate";
            this.btnCariUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnCariUpdate.TabIndex = 1;
            this.btnCariUpdate.Text = "Cari";
            this.btnCariUpdate.UseVisualStyleBackColor = true;
            this.btnCariUpdate.Click += new System.EventHandler(this.btnCariUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 162);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 44);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAngkatanUpdate
            // 
            this.txtAngkatanUpdate.Location = new System.Drawing.Point(126, 112);
            this.txtAngkatanUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAngkatanUpdate.Name = "txtAngkatanUpdate";
            this.txtAngkatanUpdate.Size = new System.Drawing.Size(146, 31);
            this.txtAngkatanUpdate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angkatan";
            // 
            // txtNamaUpdate
            // 
            this.txtNamaUpdate.Location = new System.Drawing.Point(126, 62);
            this.txtNamaUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNamaUpdate.Name = "txtNamaUpdate";
            this.txtNamaUpdate.Size = new System.Drawing.Size(670, 31);
            this.txtNamaUpdate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nama";
            // 
            // txtNpmUpdate
            // 
            this.txtNpmUpdate.Location = new System.Drawing.Point(126, 12);
            this.txtNpmUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNpmUpdate.Name = "txtNpmUpdate";
            this.txtNpmUpdate.Size = new System.Drawing.Size(146, 31);
            this.txtNpmUpdate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "NPM";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCariDelete);
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtAngkatanDelete);
            this.tabPage4.Controls.Add(this.txtNamaDelete);
            this.tabPage4.Controls.Add(this.txtNpmDelete);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(806, 453);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELETE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCariDelete
            // 
            this.btnCariDelete.Location = new System.Drawing.Point(286, 10);
            this.btnCariDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCariDelete.Name = "btnCariDelete";
            this.btnCariDelete.Size = new System.Drawing.Size(150, 44);
            this.btnCariDelete.TabIndex = 1;
            this.btnCariDelete.Text = "Cari";
            this.btnCariDelete.UseVisualStyleBackColor = true;
            this.btnCariDelete.Click += new System.EventHandler(this.btnCariDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(124, 163);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Angkatan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "NPM";
            // 
            // txtAngkatanDelete
            // 
            this.txtAngkatanDelete.Enabled = false;
            this.txtAngkatanDelete.Location = new System.Drawing.Point(124, 113);
            this.txtAngkatanDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAngkatanDelete.Name = "txtAngkatanDelete";
            this.txtAngkatanDelete.Size = new System.Drawing.Size(146, 31);
            this.txtAngkatanDelete.TabIndex = 3;
            // 
            // txtNamaDelete
            // 
            this.txtNamaDelete.Enabled = false;
            this.txtNamaDelete.Location = new System.Drawing.Point(124, 63);
            this.txtNamaDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNamaDelete.Name = "txtNamaDelete";
            this.txtNamaDelete.Size = new System.Drawing.Size(672, 31);
            this.txtNamaDelete.TabIndex = 2;
            // 
            // txtNpmDelete
            // 
            this.txtNpmDelete.Location = new System.Drawing.Point(124, 13);
            this.txtNpmDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNpmDelete.Name = "txtNpmDelete";
            this.txtNpmDelete.Size = new System.Drawing.Size(146, 31);
            this.txtNpmDelete.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 588);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTesKoneksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan ADO.NET";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesKoneksi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtAngkatanInsert;
        private System.Windows.Forms.TextBox txtNamaInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNpmInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNpmUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAngkatanUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamaUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCariUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCariDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAngkatanDelete;
        private System.Windows.Forms.TextBox txtNamaDelete;
        private System.Windows.Forms.TextBox txtNpmDelete;
    }
}

