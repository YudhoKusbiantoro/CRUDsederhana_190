using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD04on
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=YUDHO\\YUDHO;Initial Catalog=CRUDSEDERHANA;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }
        // Event saat form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Fungsi untuk mengosongkan semua input pada TextBox
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNAMA.Clear();
            txtEMAIL.Clear();
            txtTELEPON.Clear();
            txtALAMAT.Clear();

            //Fokus kembali ke NIM agar user siap memasukkan data baru
            txtNIM.Focus();
        }

        // Fungsi untuk menampilkan data di DataGridView
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NIM AS [NIM], Nama, Email, Telepon, Alamat FROM Mahasiswa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMahasiswa.AutoGenerateColumns = true;
                    dgvMahasiswa.DataSource = dt;

                    ClearForm(); // Auto Clear setelah LoadData
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Tambah_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtNIM.Text == "" || txtNAMA.Text == "" || txtEMAIL.Text == "" || txtTELEPON.Text == "" || txtALAMAT.Text == "")
                    {
                        MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    conn.Open();
                    string query = "INSERT INTO Mahasiswa (NIM, Nama, Email, Telepon, Alamat) VALUES (@NIM, @Nama, @Email, @Telepon, @Alamat)";
                   

}