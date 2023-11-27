namespace XIIRPL2_10_TICKETING.MasterForm
{
    partial class FrmMasterMaskapai
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
            txtDeskripsi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtJmlKru = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(468, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 33;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(375, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(365, 261);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(192, 112);
            txtDeskripsi.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(305, 283);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 30;
            label8.Text = "Deskripsi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 248);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 28;
            // 
            // txtJmlKru
            // 
            txtJmlKru.FormattingEnabled = true;
            txtJmlKru.Location = new Point(75, 320);
            txtJmlKru.Name = "txtJmlKru";
            txtJmlKru.Size = new Size(121, 23);
            txtJmlKru.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 323);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 26;
            label6.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 286);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 24;
            label4.Text = "Perusahaan";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(75, 283);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(121, 23);
            txtPerusahaan.TabIndex = 22;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(75, 248);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(121, 23);
            txtNama.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 251);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(278, 15);
            label2.TabIndex = 19;
            label2.Text = "semua maskapai yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 18;
            label1.Text = "Master Maskapai";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 163);
            dataGridView1.TabIndex = 17;
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
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtJmlKru);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label8;
        private Label label7;
        private ComboBox txtJmlKru;
        private Label label6;
        private Label label4;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}