namespace XIIRPL2_10_TICKETING.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            button2 = new Button();
            button1 = new Button();
            txtWaktuKeberangkatan = new TextBox();
            label8 = new Label();
            txtMaskapai = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtKodePenerbangan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtKe = new ComboBox();
            txtDari = new ComboBox();
            label7 = new Label();
            txtTanggal = new DateTimePicker();
            label9 = new Label();
            txtDurasiPenerbangan = new TextBox();
            label10 = new Label();
            txtHargaPerTiket = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(517, 415);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 50;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(413, 415);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 49;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(397, 289);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(209, 23);
            txtWaktuKeberangkatan.TabIndex = 48;
            txtWaktuKeberangkatan.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(268, 289);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 47;
            label8.Text = "Waktu Keberangkatan";
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(110, 362);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(121, 23);
            txtMaskapai.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 365);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 43;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 331);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 42;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 292);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 41;
            label4.Text = "Dari";
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(110, 257);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(121, 23);
            txtKodePenerbangan.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-3, 260);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 37;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(261, 15);
            label2.TabIndex = 36;
            label2.Text = "semua jadwal penerbangan  akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 35;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 163);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(110, 323);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(121, 23);
            txtKe.TabIndex = 51;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(110, 291);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(121, 23);
            txtDari.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(268, 257);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 53;
            label7.Text = "Tanggal";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(397, 254);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(209, 23);
            txtTanggal.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(268, 331);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 55;
            label9.Text = "Durasi Penerbangan";
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(397, 323);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(209, 23);
            txtDurasiPenerbangan.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(268, 370);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 57;
            label10.Text = "Harga per Tiket";
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(397, 362);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(209, 23);
            txtHargaPerTiket.TabIndex = 58;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(label10);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label9);
            Controls.Add(txtTanggal);
            Controls.Add(label7);
            Controls.Add(txtDari);
            Controls.Add(txtKe);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(label8);
            Controls.Add(txtMaskapai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtWaktuKeberangkatan;
        private Label label8;
        private ComboBox txtMaskapai;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtKodePenerbangan;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox txtKe;
        private ComboBox txtDari;
        private Label label7;
        private DateTimePicker txtTanggal;
        private Label label9;
        private TextBox txtDurasiPenerbangan;
        private Label label10;
        private NumericUpDown txtHargaPerTiket;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}