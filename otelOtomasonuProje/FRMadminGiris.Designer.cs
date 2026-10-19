namespace otelOtomasonuProje
{
    partial class FRMadminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMadminGiris));
            this.BTNgiris = new System.Windows.Forms.Button();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.textKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNgiris
            // 
            this.BTNgiris.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNgiris.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNgiris.ForeColor = System.Drawing.Color.Transparent;
            this.BTNgiris.Location = new System.Drawing.Point(476, 232);
            this.BTNgiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNgiris.Name = "BTNgiris";
            this.BTNgiris.Size = new System.Drawing.Size(75, 30);
            this.BTNgiris.TabIndex = 10;
            this.BTNgiris.Text = "Giriş ";
            this.BTNgiris.UseVisualStyleBackColor = false;
            this.BTNgiris.Click += new System.EventHandler(this.BTNgiris_Click);
            // 
            // textSifre
            // 
            this.textSifre.BackColor = System.Drawing.Color.Teal;
            this.textSifre.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.Location = new System.Drawing.Point(440, 205);
            this.textSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(135, 20);
            this.textSifre.TabIndex = 9;
            this.textSifre.TextChanged += new System.EventHandler(this.textSifre_TextChanged);
            // 
            // textKullaniciAdi
            // 
            this.textKullaniciAdi.BackColor = System.Drawing.Color.Teal;
            this.textKullaniciAdi.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKullaniciAdi.Location = new System.Drawing.Point(440, 174);
            this.textKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textKullaniciAdi.Name = "textKullaniciAdi";
            this.textKullaniciAdi.Size = new System.Drawing.Size(135, 20);
            this.textKullaniciAdi.TabIndex = 8;
            this.textKullaniciAdi.TextChanged += new System.EventHandler(this.textKullaniciAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(398, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(348, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // FRMadminGiris
            // 
            this.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(585, 368);
            this.Controls.Add(this.BTNgiris);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.textKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRMadminGiris";
            this.Text = "Otel Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNgiris;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.TextBox textKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

