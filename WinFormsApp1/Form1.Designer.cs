namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKoltukSayisi = new System.Windows.Forms.TextBox();
            this.textBoxSalon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOluştur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBakiye = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBiletSat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Sayısı";
            // 
            // textBoxKoltukSayisi
            // 
            this.textBoxKoltukSayisi.Location = new System.Drawing.Point(143, 57);
            this.textBoxKoltukSayisi.Name = "textBoxKoltukSayisi";
            this.textBoxKoltukSayisi.Size = new System.Drawing.Size(100, 23);
            this.textBoxKoltukSayisi.TabIndex = 1;
            // 
            // textBoxSalon
            // 
            this.textBoxSalon.Location = new System.Drawing.Point(143, 22);
            this.textBoxSalon.Name = "textBoxSalon";
            this.textBoxSalon.Size = new System.Drawing.Size(100, 23);
            this.textBoxSalon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salon";
            // 
            // buttonOluştur
            // 
            this.buttonOluştur.Location = new System.Drawing.Point(272, 22);
            this.buttonOluştur.Name = "buttonOluştur";
            this.buttonOluştur.Size = new System.Drawing.Size(139, 58);
            this.buttonOluştur.TabIndex = 4;
            this.buttonOluştur.Text = "Oluştur";
            this.buttonOluştur.UseVisualStyleBackColor = true;
            this.buttonOluştur.Click += new System.EventHandler(this.buttonOluştur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonBakiye);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonBiletSat);
            this.groupBox1.Location = new System.Drawing.Point(27, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ İPTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "OLUŞTUR";
            // 
            // buttonBakiye
            // 
            this.buttonBakiye.Location = new System.Drawing.Point(201, 48);
            this.buttonBakiye.Name = "buttonBakiye";
            this.buttonBakiye.Size = new System.Drawing.Size(61, 46);
            this.buttonBakiye.TabIndex = 9;
            this.buttonBakiye.Text = "BAKİYE";
            this.buttonBakiye.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "BOŞ KOLTUK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "BİLET İPTAL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBiletSat
            // 
            this.buttonBiletSat.Location = new System.Drawing.Point(17, 48);
            this.buttonBiletSat.Name = "buttonBiletSat";
            this.buttonBiletSat.Size = new System.Drawing.Size(66, 46);
            this.buttonBiletSat.TabIndex = 8;
            this.buttonBiletSat.Text = "BİLET SAT";
            this.buttonBiletSat.UseVisualStyleBackColor = true;
            this.buttonBiletSat.Click += new System.EventHandler(this.buttonBiletSat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOluştur);
            this.Controls.Add(this.textBoxSalon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKoltukSayisi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxKoltukSayisi;
        private Label label2;
        private Button buttonOluştur;
        private GroupBox groupBox1;
        private Button buttonBakiye;
        private Button button2;
        private Button button3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Button buttonBiletSat;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public Label label3;
        public TextBox textBoxSalon;
    }
}