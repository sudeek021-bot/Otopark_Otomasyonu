namespace WindowsFormsApp13
{
    partial class otoparkyeri_sec
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grpbox3 = new System.Windows.Forms.GroupBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.cmbbox4 = new System.Windows.Forms.ComboBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.txtbox6 = new System.Windows.Forms.TextBox();
            this.Grpbox4 = new System.Windows.Forms.GroupBox();
            this.txtbox11 = new System.Windows.Forms.TextBox();
            this.txtbox10 = new System.Windows.Forms.TextBox();
            this.txtbox9 = new System.Windows.Forms.TextBox();
            this.txtbox8 = new System.Windows.Forms.TextBox();
            this.txtbox7 = new System.Windows.Forms.TextBox();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.cmbbox5 = new System.Windows.Forms.ComboBox();
            this.btn241 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Grpbox3.SuspendLayout();
            this.Grpbox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Grpbox3
            // 
            this.Grpbox3.Controls.Add(this.lbl12);
            this.Grpbox3.Controls.Add(this.cmbbox4);
            this.Grpbox3.Controls.Add(this.lbl13);
            this.Grpbox3.Controls.Add(this.txtbox6);
            this.Grpbox3.Location = new System.Drawing.Point(12, 259);
            this.Grpbox3.Name = "Grpbox3";
            this.Grpbox3.Size = new System.Drawing.Size(251, 100);
            this.Grpbox3.TabIndex = 1;
            this.Grpbox3.TabStop = false;
            this.Grpbox3.Text = "Plaka ve Park Yeri";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(6, 24);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(66, 16);
            this.lbl12.TabIndex = 6;
            this.lbl12.Text = "Plaka Ara";
            // 
            // cmbbox4
            // 
            this.cmbbox4.FormattingEnabled = true;
            this.cmbbox4.Location = new System.Drawing.Point(98, 21);
            this.cmbbox4.Name = "cmbbox4";
            this.cmbbox4.Size = new System.Drawing.Size(121, 24);
            this.cmbbox4.TabIndex = 0;
            this.cmbbox4.SelectedIndexChanged += new System.EventHandler(this.cmbbox4_SelectedIndexChanged);
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(6, 67);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(62, 16);
            this.lbl13.TabIndex = 3;
            this.lbl13.Text = "Park Yeri";
            // 
            // txtbox6
            // 
            this.txtbox6.Location = new System.Drawing.Point(98, 61);
            this.txtbox6.Name = "txtbox6";
            this.txtbox6.Size = new System.Drawing.Size(121, 22);
            this.txtbox6.TabIndex = 3;
            this.txtbox6.TextChanged += new System.EventHandler(this.txtbox6_TextChanged);
            // 
            // Grpbox4
            // 
            this.Grpbox4.Controls.Add(this.txtbox11);
            this.Grpbox4.Controls.Add(this.txtbox10);
            this.Grpbox4.Controls.Add(this.txtbox9);
            this.Grpbox4.Controls.Add(this.txtbox8);
            this.Grpbox4.Controls.Add(this.txtbox7);
            this.Grpbox4.Controls.Add(this.lbl15);
            this.Grpbox4.Controls.Add(this.lbl14);
            this.Grpbox4.Controls.Add(this.cmbbox5);
            this.Grpbox4.Location = new System.Drawing.Point(332, 259);
            this.Grpbox4.Name = "Grpbox4";
            this.Grpbox4.Size = new System.Drawing.Size(494, 100);
            this.Grpbox4.TabIndex = 2;
            this.Grpbox4.TabStop = false;
            this.Grpbox4.Text = "Araç";
            // 
            // txtbox11
            // 
            this.txtbox11.Location = new System.Drawing.Point(372, 61);
            this.txtbox11.Name = "txtbox11";
            this.txtbox11.Size = new System.Drawing.Size(100, 22);
            this.txtbox11.TabIndex = 5;
            // 
            // txtbox10
            // 
            this.txtbox10.Location = new System.Drawing.Point(372, 16);
            this.txtbox10.Name = "txtbox10";
            this.txtbox10.Size = new System.Drawing.Size(100, 22);
            this.txtbox10.TabIndex = 6;
            // 
            // txtbox9
            // 
            this.txtbox9.Location = new System.Drawing.Point(236, 61);
            this.txtbox9.Name = "txtbox9";
            this.txtbox9.Size = new System.Drawing.Size(100, 22);
            this.txtbox9.TabIndex = 7;
            // 
            // txtbox8
            // 
            this.txtbox8.Location = new System.Drawing.Point(236, 16);
            this.txtbox8.Name = "txtbox8";
            this.txtbox8.Size = new System.Drawing.Size(100, 22);
            this.txtbox8.TabIndex = 8;
            // 
            // txtbox7
            // 
            this.txtbox7.Location = new System.Drawing.Point(72, 61);
            this.txtbox7.Name = "txtbox7";
            this.txtbox7.Size = new System.Drawing.Size(123, 22);
            this.txtbox7.TabIndex = 9;
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.Location = new System.Drawing.Point(6, 67);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(60, 16);
            this.lbl15.TabIndex = 5;
            this.lbl15.Text = "Park yeri";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Location = new System.Drawing.Point(6, 24);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(62, 16);
            this.lbl14.TabIndex = 4;
            this.lbl14.Text = "Park Yeri";
            // 
            // cmbbox5
            // 
            this.cmbbox5.FormattingEnabled = true;
            this.cmbbox5.Location = new System.Drawing.Point(74, 21);
            this.cmbbox5.Name = "cmbbox5";
            this.cmbbox5.Size = new System.Drawing.Size(121, 24);
            this.cmbbox5.TabIndex = 1;
            
            // 
            // btn241
            // 
            this.btn241.BackColor = System.Drawing.Color.Cyan;
            this.btn241.Location = new System.Drawing.Point(532, 456);
            this.btn241.Name = "btn241";
            this.btn241.Size = new System.Drawing.Size(136, 49);
            this.btn241.TabIndex = 4;
            this.btn241.Text = "Çıkış";
            this.btn241.UseVisualStyleBackColor = false;
            this.btn241.Click += new System.EventHandler(this.btn241_Click);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.Tomato;
            this.btn22.Location = new System.Drawing.Point(332, 376);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(166, 55);
            this.btn22.TabIndex = 5;
            this.btn22.Text = "Otoparktan Ayrıl !";
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.Cyan;
            this.btn23.Location = new System.Drawing.Point(127, 456);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(136, 49);
            this.btn23.TabIndex = 6;
            this.btn23.Text = "Geri";
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.btn23_Click);
            // 
            // otoparkyeri_sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 517);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn241);
            this.Controls.Add(this.Grpbox4);
            this.Controls.Add(this.Grpbox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "otoparkyeri_sec";
            this.Text = "Otoparkyeri_Sec";
            this.Load += new System.EventHandler(this.otoparkyeri_sec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Grpbox3.ResumeLayout(false);
            this.Grpbox3.PerformLayout();
            this.Grpbox4.ResumeLayout(false);
            this.Grpbox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Grpbox3;
        private System.Windows.Forms.GroupBox Grpbox4;
        private System.Windows.Forms.ComboBox cmbbox4;
        
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.ComboBox cmbbox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtbox6;
        private System.Windows.Forms.TextBox txtbox11;
        private System.Windows.Forms.TextBox txtbox10;
        private System.Windows.Forms.TextBox txtbox9;
        private System.Windows.Forms.TextBox txtbox8;
        private System.Windows.Forms.TextBox txtbox7;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn241;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Button btn23;
    }
}

