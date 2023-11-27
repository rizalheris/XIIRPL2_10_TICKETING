namespace XIIRPL2_10_TICKETING.MasterForm
{
    partial class FrmMasterKodePromo
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
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtDeskripsi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtKodePromo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaksimumDiskon = new NumericUpDown();
            txtPresentaseDiskon = new NumericUpDown();
            txtBerlakuSampai = new DateTimePicker();
            Delete = new DataGridViewButtonColumn();
            BtnEdit = new DataGridViewButtonColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(368, 245);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 74;
            label7.Text = "Deskripsi";
            // 
            // button2
            // 
            button2.Location = new Point(530, 354);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 71;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(437, 354);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 70;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(437, 237);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(209, 52);
            txtDeskripsi.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 344);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 66;
            label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 311);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 65;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 274);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 64;
            label4.Text = "Berlaku Sampai";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(110, 237);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(208, 23);
            txtKodePromo.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 242);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 62;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(295, 15);
            label2.TabIndex = 61;
            label2.Text = "Semua Kode promo yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 60;
            label1.Text = "Master Kode Promo";
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(107, 342);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(211, 23);
            txtMaksimumDiskon.TabIndex = 82;
            // 
            // txtPresentaseDiskon
            // 
            txtPresentaseDiskon.Location = new Point(107, 304);
            txtPresentaseDiskon.Name = "txtPresentaseDiskon";
            txtPresentaseDiskon.Size = new Size(211, 23);
            txtPresentaseDiskon.TabIndex = 83;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(107, 268);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(211, 23);
            txtBerlakuSampai.TabIndex = 84;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, Delete });
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(720, 163);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(txtPresentaseDiskon);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button button2;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtKodePromo;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown txtMaksimumDiskon;
        private NumericUpDown txtPresentaseDiskon;
        private DateTimePicker txtBerlakuSampai;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridView dataGridView1;
    }
}