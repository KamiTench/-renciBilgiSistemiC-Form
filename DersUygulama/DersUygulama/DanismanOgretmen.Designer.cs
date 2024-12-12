namespace DersUygulama
{
    partial class DanismanOgretmen
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewIstekler = new System.Windows.Forms.DataGridView();
            this.secimIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDersSecimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersSecimSistemiDataSet2 = new DersUygulama.DersSecimSistemiDataSet2();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.ogrenciDersSecimTableAdapter = new DersUygulama.DersSecimSistemiDataSet2TableAdapters.OgrenciDersSecimTableAdapter();
            this.txtsecimid = new System.Windows.Forms.TextBox();
            this.isteğiseç = new System.Windows.Forms.Button();
            this.secimid = new System.Windows.Forms.TextBox();
            this.ogrenciid = new System.Windows.Forms.TextBox();
            this.dersid = new System.Windows.Forms.TextBox();
            this.durum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersSecimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersSecimSistemiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIstekler
            // 
            this.dataGridViewIstekler.AutoGenerateColumns = false;
            this.dataGridViewIstekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIstekler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secimIDDataGridViewTextBoxColumn,
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.dersIDDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridViewIstekler.DataSource = this.ogrenciDersSecimBindingSource;
            this.dataGridViewIstekler.Location = new System.Drawing.Point(23, 43);
            this.dataGridViewIstekler.Name = "dataGridViewIstekler";
            this.dataGridViewIstekler.RowHeadersWidth = 51;
            this.dataGridViewIstekler.RowTemplate.Height = 24;
            this.dataGridViewIstekler.Size = new System.Drawing.Size(549, 246);
            this.dataGridViewIstekler.TabIndex = 0;
            // 
            // secimIDDataGridViewTextBoxColumn
            // 
            this.secimIDDataGridViewTextBoxColumn.DataPropertyName = "SecimID";
            this.secimIDDataGridViewTextBoxColumn.HeaderText = "SecimID";
            this.secimIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secimIDDataGridViewTextBoxColumn.Name = "secimIDDataGridViewTextBoxColumn";
            this.secimIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.secimIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDersSecimBindingSource
            // 
            this.ogrenciDersSecimBindingSource.DataMember = "OgrenciDersSecim";
            this.ogrenciDersSecimBindingSource.DataSource = this.dersSecimSistemiDataSet2;
            // 
            // dersSecimSistemiDataSet2
            // 
            this.dersSecimSistemiDataSet2.DataSetName = "DersSecimSistemiDataSet2";
            this.dersSecimSistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Lime;
            this.btnOnayla.Location = new System.Drawing.Point(599, 243);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(77, 33);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.Red;
            this.btnReddet.Location = new System.Drawing.Point(717, 243);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(76, 33);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // ogrenciDersSecimTableAdapter
            // 
            this.ogrenciDersSecimTableAdapter.ClearBeforeFill = true;
            // 
            // txtsecimid
            // 
            this.txtsecimid.Location = new System.Drawing.Point(264, 301);
            this.txtsecimid.Name = "txtsecimid";
            this.txtsecimid.Size = new System.Drawing.Size(100, 22);
            this.txtsecimid.TabIndex = 3;
            this.txtsecimid.TextChanged += new System.EventHandler(this.txtsecimid_TextChanged);
            // 
            // isteğiseç
            // 
            this.isteğiseç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.isteğiseç.Location = new System.Drawing.Point(370, 295);
            this.isteğiseç.Name = "isteğiseç";
            this.isteğiseç.Size = new System.Drawing.Size(140, 35);
            this.isteğiseç.TabIndex = 4;
            this.isteğiseç.Text = "Başvuruyu seç";
            this.isteğiseç.UseVisualStyleBackColor = false;
            this.isteğiseç.Click += new System.EventHandler(this.isteğiseç_Click);
            // 
            // secimid
            // 
            this.secimid.Location = new System.Drawing.Point(567, 43);
            this.secimid.Name = "secimid";
            this.secimid.Size = new System.Drawing.Size(15, 22);
            this.secimid.TabIndex = 5;
            // 
            // ogrenciid
            // 
            this.ogrenciid.Location = new System.Drawing.Point(650, 120);
            this.ogrenciid.Name = "ogrenciid";
            this.ogrenciid.Size = new System.Drawing.Size(100, 22);
            this.ogrenciid.TabIndex = 6;
            // 
            // dersid
            // 
            this.dersid.Location = new System.Drawing.Point(650, 160);
            this.dersid.Name = "dersid";
            this.dersid.Size = new System.Drawing.Size(100, 22);
            this.dersid.TabIndex = 7;
            // 
            // durum
            // 
            this.durum.Location = new System.Drawing.Point(650, 200);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(100, 22);
            this.durum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "SecimID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Durumu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "DersID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "ÖğrenciID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(353, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Öğretmen";
            // 
            // DanismanOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.dersid);
            this.Controls.Add(this.ogrenciid);
            this.Controls.Add(this.secimid);
            this.Controls.Add(this.isteğiseç);
            this.Controls.Add(this.txtsecimid);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dataGridViewIstekler);
            this.Name = "DanismanOgretmen";
            this.Text = "DanismanOgretmen";
            this.Load += new System.EventHandler(this.DanismanOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIstekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersSecimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersSecimSistemiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIstekler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private DersSecimSistemiDataSet2 dersSecimSistemiDataSet2;
        private System.Windows.Forms.BindingSource ogrenciDersSecimBindingSource;
        private DersSecimSistemiDataSet2TableAdapters.OgrenciDersSecimTableAdapter ogrenciDersSecimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn secimIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsecimid;
        private System.Windows.Forms.Button isteğiseç;
        private System.Windows.Forms.TextBox secimid;
        private System.Windows.Forms.TextBox ogrenciid;
        private System.Windows.Forms.TextBox dersid;
        private System.Windows.Forms.TextBox durum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}