namespace ApartmanDeneme
{
    partial class Anasayfa
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
            this.Gelirler = new System.Windows.Forms.Button();
            this.Giderler = new System.Windows.Forms.Button();
            this.mailat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gelirler
            // 
            this.Gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gelirler.Location = new System.Drawing.Point(33, 36);
            this.Gelirler.Name = "Gelirler";
            this.Gelirler.Size = new System.Drawing.Size(128, 74);
            this.Gelirler.TabIndex = 0;
            this.Gelirler.Text = "Gelirler";
            this.Gelirler.UseVisualStyleBackColor = true;
            this.Gelirler.Click += new System.EventHandler(this.button1_Click);
            // 
            // Giderler
            // 
            this.Giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giderler.Location = new System.Drawing.Point(33, 136);
            this.Giderler.Name = "Giderler";
            this.Giderler.Size = new System.Drawing.Size(128, 74);
            this.Giderler.TabIndex = 1;
            this.Giderler.Text = "Giderler";
            this.Giderler.UseVisualStyleBackColor = true;
            this.Giderler.Click += new System.EventHandler(this.Giderler_Click);
            // 
            // mailat
            // 
            this.mailat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailat.Location = new System.Drawing.Point(33, 236);
            this.mailat.Name = "mailat";
            this.mailat.Size = new System.Drawing.Size(218, 74);
            this.mailat.TabIndex = 2;
            this.mailat.Text = "Dairelere Mail At";
            this.mailat.UseVisualStyleBackColor = true;
            this.mailat.Click += new System.EventHandler(this.mailat_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.Location = new System.Drawing.Point(33, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 74);
            this.button5.TabIndex = 5;
            this.button5.Text = "Kullanıcı Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(33, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Anasayfa
            // 
            this.AccessibleName = "Anasayfa";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.mailat);
            this.Controls.Add(this.Giderler);
            this.Controls.Add(this.Gelirler);
            this.Name = "Anasayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gelirler;
        private System.Windows.Forms.Button Giderler;
        private System.Windows.Forms.Button mailat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}

