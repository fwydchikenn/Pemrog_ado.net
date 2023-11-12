using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace LatihanADONET
{
    public partial class Form1 : Form
    {
        // constructor

        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            // membuat objek connection
            SQLiteConnection conn = GetOpenConnection();
            // cek status koneksi
            if (conn.State == ConnectionState.Open) // koneksi berhasil
            {
                MessageBox.Show("Koneksi ke database berhasil !", "Informasi",
               MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Koneksi ke database gagal !!!", "Informasi",
               MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            conn.Dispose(); // tutup dan hapus objek connection dari memory
        }
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // deklarasi objek connection
            try // penggunaan blok try-catch untuk penanganan error
            {
                // atur ulang lokasi database yang disesuaikan dengan
                // lokasi database perpustakaan Anda
                string dbName = @"D:\pemograman lanjutan\New folder (2)\Module Praktikum 08 (ADO.NET)\LatihanADO.NET\Database";
                // deklarasi variabel connectionString, ref: https://www.connectionstrings.com/
                string connectionString = string.Format("Data Source={0};FailIfMissing=True", dbName);
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            lvwMahasiswa.Items.Clear();
            SQLiteConnection conn = GetOpenConnection();
            string sql = @"select npm, nama, angkatan, from mahasiswa order by nama";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dtr["npm"].ToString());
                item.SubItems.Add(dtr["nama"].ToString());
                item.SubItems.Add(dtr["angkatan"].ToString());
                lvwMahasiswa.Items.Add(item);
            }
            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();

        }
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;
            lvwMahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("NPM", 70, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 190, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Angkatan", 70, HorizontalAlignment.Center);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi npm harus diisi
            if (string.IsNullOrEmpty(txtNpmInsert.Text))
            {
                MessageBox.Show("NPM harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNpmInsert.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNamaInsert.Text))
            {
                MessageBox.Show("Nama harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNamaInsert.Focus();
                return;

            }
            SQLiteConnection conn = GetOpenConnection();
            var sql = @"insert into mahasiswa (npm, nama, angkatan) values (@npm, @nama, @angkatan)";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@npm", txtNpmInsert.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaInsert.Text);
                cmd.Parameters.AddWithValue("@angkatan", txtAngkatanInsert.Text);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // reset form
                txtNpmInsert.Clear();
                txtNamaInsert.Clear();
                txtAngkatanInsert.Clear();
                txtNpmInsert.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            conn.Dispose();
        }

        private void btnCariUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNpmUpdate.Text))
            {
                MessageBox.Show("NPM harus !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                txtNpmUpdate.Focus();
                return;
            }
            // membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();
            // deklarasi variabel sql untuk menampung perintah SELECT
            string sql = @"select npm, nama, angkatan from mahasiswa where npm = @npm";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@npm", txtNpmUpdate.Text);
            SQLiteDataReader dtr = cmd.ExecuteReader();
            if (dtr.Read()) // data ditemukan
            {
                // tampilkan nilainya ke textbox
                txtNpmUpdate.Text = dtr["npm"].ToString();
                txtNamaUpdate.Text = dtr["nama"].ToString();
                txtAngkatanUpdate.Text = dtr["angkatan"].ToString();
            }
            else
                MessageBox.Show("Data mahasiswa tidak ditemukan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi npm harus diisi
            if (string.IsNullOrEmpty(txtNpmUpdate.Text))
            {
                MessageBox.Show("NPM harus !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNpmUpdate.Focus();
                return;
            }
            // validasi nama harus diisi
            if (string.IsNullOrEmpty(txtNamaUpdate.Text))
            {
                MessageBox.Show("Nama harus !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNamaUpdate.Focus();
                return;
            }
            // membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();
            // deklarasi variabel sql untuk menampung perintah UPDATE
            string sql = @"update mahasiswa set nama = @nama, angkatan = @angkatan where npm = @npm";
            
            // membuat objek Command untuk mengeksekusi perintah SQL
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            try
            {
                // set parameter untuk nama, angkatan dan npm
                cmd.Parameters.AddWithValue("@nama", txtNamaUpdate.Text);
                cmd.Parameters.AddWithValue("@angkatan", txtAngkatanUpdate.Text);
                cmd.Parameters.AddWithValue("@npm", txtNpmUpdate.Text);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                cmd.Dispose();
            }
            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // reset form
                txtNpmUpdate.Clear();
                txtNamaUpdate.Clear();
                txtAngkatanUpdate.Clear();
                txtNpmUpdate.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            // setelah selesai digunakan, 
            // segera hapus objek connection dari memory
            conn.Dispose();
        }

        private void btnCariDelete_Click(object sender, EventArgs e)
        {
            // validasi npm harus diisi
            if (string.IsNullOrEmpty(txtNpmDelete.Text))
            {
                MessageBox.Show("NPM harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNpmDelete.Focus();
                return;
            }

            // membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah SELECT
            string sql = "SELECT npm, nama, angkatan FROM mahasiswa WHERE npm = @npm";

            // membuat objek Command untuk mengeksekusi perintah SQL
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@npm", txtNpmDelete.Text);

            // membuat objek DataReader untuk menampung hasil perintah SELECT
            SQLiteDataReader dtr = cmd.ExecuteReader(); // eksekusi perintah SELECT

            if (dtr.Read()) // data ditemukan
            {
                // tampilkan nilainya ke textbox
                txtNpmDelete.Text = dtr["npm"].ToString();
                txtNamaDelete.Text = dtr["nama"].ToString();
                txtAngkatanDelete.Text = dtr["angkatan"].ToString();
            }
            else
            {
                MessageBox.Show("Data mahasiswa tidak ditemukan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset form
                txtNamaDelete.Clear();
                txtAngkatanDelete.Clear();
            }

            // Setelah selesai digunakan, segera hapus objek datareader, command, dan connection dari memory
            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validasi npm harus diisi
            if (string.IsNullOrEmpty(txtNpmDelete.Text))
            {
                MessageBox.Show("NPM harus diisi !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNpmDelete.Focus();
                return;
            }

            // Membuat objek Connection, sekaligus buka koneksi ke database
            SQLiteConnection conn = GetOpenConnection();

            // Deklarasi variabel sql untuk menampung perintah DELETE
            string sql = "DELETE FROM mahasiswa WHERE npm = @npm";

            // Membuat objek Command untuk mengeksekusi perintah SQL
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@npm", txtNpmDelete.Text);

            int result = 0;
            try
            {
                result = cmd.ExecuteNonQuery(); // Eksekusi perintah DELETE
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset form
                txtNpmDelete.Clear();
                txtNamaDelete.Clear();
                txtAngkatanDelete.Clear();
                txtNpmDelete.Focus();
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Setelah selesai digunakan, segera hapus objek connection dari memory
            conn.Dispose();
        }
    }
}

