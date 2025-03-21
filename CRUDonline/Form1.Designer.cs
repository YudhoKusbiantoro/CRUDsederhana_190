namespace CRUD04on
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
            this.NIM = new System.Windows.Forms.Label();
            this.NAMA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.TELEPON = new System.Windows.Forms.Label();
            this.ALAMAT = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtTELEPON = new System.Windows.Forms.TextBox();
            this.txtALAMAT = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(104, 62);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(38, 20);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.Location = new System.Drawing.Point(104, 114);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(55, 20);
            this.NAMA.TabIndex = 1;
            this.NAMA.Text = "NAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(104, 160);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(58, 20);
            this.EMAIL.TabIndex = 3;
            this.EMAIL.Text = "EMAIL";
            // 
            // TELEPON
            // 
            this.TELEPON.AutoSize = true;
            this.TELEPON.Location = new System.Drawing.Point(104, 206);
            this.TELEPON.Name = "TELEPON";
            this.TELEPON.Size = new System.Drawing.Size(82, 20);
            this.TELEPON.TabIndex = 4;
            this.TELEPON.Text = "TELEPON";
            // 
            // ALAMAT
            // 
            this.ALAMAT.AutoSize = true;
            this.ALAMAT.Location = new System.Drawing.Point(104, 245);
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(73, 20);
            this.ALAMAT.TabIndex = 5;
            this.ALAMAT.Text = "ALAMAT";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(252, 58);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(250, 26);
            this.txtNIM.TabIndex = 6;
            // 
            // txtNAMA
            // 
            this.txtNAMA.Location = new System.Drawing.Point(244, 108);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(253, 26);
            this.txtNAMA.TabIndex = 7;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(244, 154);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(257, 26);
            this.txtEMAIL.TabIndex = 8;
            // 
            // txtTELEPON
            // 
            this.txtTELEPON.Location = new System.Drawing.Point(244, 200);
            this.txtTELEPON.Name = "txtTELEPON";
            this.txtTELEPON.Size = new System.Drawing.Size(258, 26);
            this.txtTELEPON.TabIndex = 9;
            // 
            // txtALAMAT
            // 
            this.txtALAMAT.Location = new System.Drawing.Point(239, 242);
            this.txtALAMAT.Name = "txtALAMAT";
            this.txtALAMAT.Size = new System.Drawing.Size(263, 26);
            this.txtALAMAT.TabIndex = 10;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(601, 64);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(116, 31);
            this.Tambah.TabIndex = 11;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.Tambah_click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(607, 114);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(110, 40);
            this.Hapus.TabIndex = 12;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.MouseCaptureChanged += new System.EventHandler(this.Hapus_click);
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(601, 169);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(116, 36);
            this.Ubah.TabIndex = 13;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.Ubah_click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(607, 222);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(101, 43);
            this.Refresh.TabIndex = 14;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(64, 294);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 62;
            this.dgvMahasiswa.RowTemplate.Height = 28;
            this.dgvMahasiswa.Size = new System.Drawing.Size(617, 150);
            this.dgvMahasiswa.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Ubah);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.txtALAMAT);
            this.Controls.Add(this.txtTELEPON);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtNAMA);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.TELEPON);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label TELEPON;
        private System.Windows.Forms.Label ALAMAT;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtTELEPON;
        private System.Windows.Forms.TextBox txtALAMAT;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button Ubah;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

