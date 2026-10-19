namespace otelOtomasonuProje
{
    partial class FRManaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTNpersonelTakip = new System.Windows.Forms.Button();
            this.BTNmusteriler = new System.Windows.Forms.Button();
            this.BTNhakkımızda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(242, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADMİN GİRİŞİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(242, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "YENİ MÜŞTERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(242, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "ODALAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNpersonelTakip
            // 
            this.BTNpersonelTakip.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNpersonelTakip.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNpersonelTakip.Location = new System.Drawing.Point(242, 326);
            this.BTNpersonelTakip.Name = "BTNpersonelTakip";
            this.BTNpersonelTakip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTNpersonelTakip.Size = new System.Drawing.Size(175, 65);
            this.BTNpersonelTakip.TabIndex = 5;
            this.BTNpersonelTakip.Text = "PERSONEL TAKİP";
            this.BTNpersonelTakip.UseVisualStyleBackColor = false;
            this.BTNpersonelTakip.Click += new System.EventHandler(this.BTNisTakvimi_Click);
            // 
            // BTNmusteriler
            // 
            this.BTNmusteriler.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNmusteriler.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNmusteriler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNmusteriler.Location = new System.Drawing.Point(242, 184);
            this.BTNmusteriler.Name = "BTNmusteriler";
            this.BTNmusteriler.Size = new System.Drawing.Size(175, 65);
            this.BTNmusteriler.TabIndex = 6;
            this.BTNmusteriler.Text = "MÜŞTERİLER";
            this.BTNmusteriler.UseVisualStyleBackColor = false;
            this.BTNmusteriler.Click += new System.EventHandler(this.BTNmusteriler_Click);
            // 
            // BTNhakkımızda
            // 
            this.BTNhakkımızda.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNhakkımızda.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNhakkımızda.Location = new System.Drawing.Point(242, 397);
            this.BTNhakkımızda.Name = "BTNhakkımızda";
            this.BTNhakkımızda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTNhakkımızda.Size = new System.Drawing.Size(175, 65);
            this.BTNhakkımızda.TabIndex = 7;
            this.BTNhakkımızda.Text = "HAKKIMIZDA";
            this.BTNhakkımızda.UseVisualStyleBackColor = false;
            this.BTNhakkımızda.Click += new System.EventHandler(this.BTNhakkımızda_Click);
            // 
            // FRManaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(676, 519);
            this.Controls.Add(this.BTNhakkımızda);
            this.Controls.Add(this.BTNmusteriler);
            this.Controls.Add(this.BTNpersonelTakip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FRManaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FRManaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTNpersonelTakip;
        private System.Windows.Forms.Button BTNmusteriler;
        private System.Windows.Forms.Button BTNhakkımızda;
    }
}