namespace WindowsFormsApp13
{
    partial class marka
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
            this.lbl16 = new System.Windows.Forms.Label();
            this.txtbox12 = new System.Windows.Forms.TextBox();
            this.btn24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl16.Location = new System.Drawing.Point(94, 108);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(60, 20);
            this.lbl16.TabIndex = 0;
            this.lbl16.Text = "Marka";
            // 
            // txtbox12
            // 
            this.txtbox12.Location = new System.Drawing.Point(199, 106);
            this.txtbox12.Name = "txtbox12";
            this.txtbox12.Size = new System.Drawing.Size(173, 22);
            this.txtbox12.TabIndex = 1;
            // 
            // btn24
            // 
            this.btn24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn24.Location = new System.Drawing.Point(131, 194);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(163, 31);
            this.btn24.TabIndex = 2;
            this.btn24.Text = "Marka Ekle";
            this.btn24.UseVisualStyleBackColor = true;
            this.btn24.Click += new System.EventHandler(this.btn24_Click);
            // 
            // marka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 331);
            this.Controls.Add(this.btn24);
            this.Controls.Add(this.txtbox12);
            this.Controls.Add(this.lbl16);
            this.Name = "marka";
            this.Text = "Marka";
            this.Load += new System.EventHandler(this.marka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.TextBox txtbox12;
        private System.Windows.Forms.Button btn24;
    }
}

