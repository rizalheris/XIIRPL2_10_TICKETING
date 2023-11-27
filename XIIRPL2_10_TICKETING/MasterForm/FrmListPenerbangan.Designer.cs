namespace XIIRPL2_10_TICKETING.MasterForm
{
    partial class FrmListPenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListPenerbangan));
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 24);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 63;
            label1.Text = "List Penerbangan";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 72);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 65;
            label3.Text = "Juanda(SUB)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 72);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 67;
            label5.Text = "Soekarno-Hatta (CGK)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 72);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 69;
            label7.Text = "Mon, 22 May 2023";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(423, 72);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 71;
            label9.Text = "1 penumpang";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 214);
            dataGridView1.TabIndex = 72;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 87);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 21);
            button3.Name = "button3";
            button3.Size = new Size(46, 36);
            button3.TabIndex = 74;
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 124);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // button1
            // 
            button1.Location = new Point(670, 94);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 7;
            button1.Text = "Terapkan Filter";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 71);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 6;
            label6.Text = "Urutkan Berdasarkan";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Harga Terendah";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(346, 50);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(91, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "18:00 - 24:00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(235, 50);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "12:00 - 18:00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(127, 50);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "06:00 - 12:00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(22, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "00:00 - 06:00";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Waktu Keberangkatan";
            label2.Click += label2_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(107, 61);
            button2.Name = "button2";
            button2.Size = new Size(31, 36);
            button2.TabIndex = 86;
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(404, 66);
            button5.Name = "button5";
            button5.Size = new Size(22, 26);
            button5.TabIndex = 88;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(270, 66);
            button6.Name = "button6";
            button6.Size = new Size(22, 26);
            button6.TabIndex = 89;
            button6.UseVisualStyleBackColor = false;
            // 
            // FrmListPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmListPenerbangan";
            Text = "FrmListPenerbangan";
            Load += FrmListPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label9;
        private DataGridView dataGridView1;
        private Label label10;
        private Button button3;
        private GroupBox groupBox1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Button button2;
        private Button button5;
        private Button button6;
    }
}