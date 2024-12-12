namespace DersUygulama
{
    partial class OgrenciIsleri
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
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtGNO = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersRaporu = new System.Windows.Forms.Button();
            this.btnOgrenciRaporu = new System.Windows.Forms.Button();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKontenjan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(132, 99);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(100, 22);
            this.txtOgrenciAd.TabIndex = 0;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(132, 127);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgrenciSoyad.TabIndex = 1;
            // 
            // txtGNO
            // 
            this.txtGNO.Location = new System.Drawing.Point(132, 155);
            this.txtGNO.Name = "txtGNO";
            this.txtGNO.Size = new System.Drawing.Size(100, 22);
            this.txtGNO.TabIndex = 2;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(847, 96);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(100, 22);
            this.txtDersAdi.TabIndex = 3;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(847, 124);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(100, 22);
            this.txtDersKodu.TabIndex = 4;
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(847, 152);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(100, 22);
            this.txtKredi.TabIndex = 5;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(132, 194);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(100, 30);
            this.btnOgrenciEkle.TabIndex = 6;
            this.btnOgrenciEkle.Text = "Kaydet";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click_1);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDersEkle.Location = new System.Drawing.Point(846, 226);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(101, 31);
            this.btnDersEkle.TabIndex = 7;
            this.btnDersEkle.Text = "Kaydet";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click_1);
            // 
            // btnDersRaporu
            // 
            this.btnDersRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDersRaporu.Location = new System.Drawing.Point(723, 548);
            this.btnDersRaporu.Name = "btnDersRaporu";
            this.btnDersRaporu.Size = new System.Drawing.Size(75, 23);
            this.btnDersRaporu.TabIndex = 8;
            this.btnDersRaporu.Text = "Yenile";
            this.btnDersRaporu.UseVisualStyleBackColor = false;
            this.btnDersRaporu.Click += new System.EventHandler(this.btnDersRaporu_Click);
            // 
            // btnOgrenciRaporu
            // 
            this.btnOgrenciRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOgrenciRaporu.Location = new System.Drawing.Point(225, 548);
            this.btnOgrenciRaporu.Name = "btnOgrenciRaporu";
            this.btnOgrenciRaporu.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciRaporu.TabIndex = 9;
            this.btnOgrenciRaporu.Text = "Yenile";
            this.btnOgrenciRaporu.UseVisualStyleBackColor = false;
            this.btnOgrenciRaporu.Click += new System.EventHandler(this.btnOgrenciRaporu_Click);
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(43, 275);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 24;
            this.dgvOgrenciler.Size = new System.Drawing.Size(437, 267);
            this.dgvOgrenciler.TabIndex = 10;
            this.dgvOgrenciler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciler_CellContentClick);
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(529, 275);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.RowHeadersWidth = 51;
            this.dgvDersler.RowTemplate.Height = 24;
            this.dgvDersler.Size = new System.Drawing.Size(450, 267);
            this.dgvDersler.TabIndex = 11;
            this.dgvDersler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDersler_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Öğrenci Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "GNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ders Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ders Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ders Kredisi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(447, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Öğrenci İşleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(128, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Öğrenci Ekle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(842, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ders Ekle";
            // 
            // txtKontenjan
            // 
            this.txtKontenjan.Location = new System.Drawing.Point(846, 180);
            this.txtKontenjan.Name = "txtKontenjan";
            this.txtKontenjan.Size = new System.Drawing.Size(100, 22);
            this.txtKontenjan.TabIndex = 21;
            this.txtKontenjan.TextChanged += new System.EventHandler(this.txtKontenjan_TextChanged);
            // 
            // OgrenciIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(991, 603);
            this.Controls.Add(this.txtKontenjan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDersler);
            this.Controls.Add(this.dgvOgrenciler);
            this.Controls.Add(this.btnOgrenciRaporu);
            this.Controls.Add(this.btnDersRaporu);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtGNO);
            this.Controls.Add(this.txtOgrenciSoyad);
            this.Controls.Add(this.txtOgrenciAd);
            this.Name = "OgrenciIsleri";
            this.Text = "OgrenciIsleri";
            this.Load += new System.EventHandler(this.OgrenciIsleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtGNO;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersRaporu;
        private System.Windows.Forms.Button btnOgrenciRaporu;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKontenjan;
    }
}