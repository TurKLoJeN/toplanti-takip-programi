namespace Toplantı_Takip_Programı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toplanti1DataSet = new Toplantı_Takip_Programı.toplanti1DataSet();
            this.kayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitlarTableAdapter = new Toplantı_Takip_Programı.toplanti1DataSetTableAdapters.kayitlarTableAdapter();
            this.toplanti1DataSet1 = new Toplantı_Takip_Programı.toplanti1DataSet1();
            this.kayitlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayitlarTableAdapter1 = new Toplantı_Takip_Programı.toplanti1DataSet1TableAdapters.kayitlarTableAdapter();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimsoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimdurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enstituDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.ambiance_Label4 = new Ambiance.Ambiance_Label();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.ambiance_Label6 = new Ambiance.Ambiance_Label();
            this.textBox2 = new Ambiance.Ambiance_TextBox();
            this.textBox1 = new Ambiance.Ambiance_TextBox();
            this.comboBox1 = new Ambiance.Ambiance_ComboBox();
            this.comboBox2 = new Ambiance.Ambiance_ComboBox();
            this.comboBox3 = new Ambiance.Ambiance_ComboBox();
            this.button1 = new Ambiance.Ambiance_Button_1();
            this.button2 = new Ambiance.Ambiance_Button_2();
            this.button3 = new Ambiance.Ambiance_Button_1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toplanti1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplanti1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ambiance_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toplanti1DataSet
            // 
            this.toplanti1DataSet.DataSetName = "toplanti1DataSet";
            this.toplanti1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitlarBindingSource
            // 
            this.kayitlarBindingSource.DataMember = "kayitlar";
            this.kayitlarBindingSource.DataSource = this.toplanti1DataSet;
            // 
            // kayitlarTableAdapter
            // 
            this.kayitlarTableAdapter.ClearBeforeFill = true;
            // 
            // toplanti1DataSet1
            // 
            this.toplanti1DataSet1.DataSetName = "toplanti1DataSet1";
            this.toplanti1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitlarBindingSource1
            // 
            this.kayitlarBindingSource1.DataMember = "kayitlar";
            this.kayitlarBindingSource1.DataSource = this.toplanti1DataSet1;
            // 
            // kayitlarTableAdapter1
            // 
            this.kayitlarTableAdapter1.ClearBeforeFill = true;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(35, 69);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(35, 20);
            this.ambiance_Label1.TabIndex = 16;
            this.ambiance_Label1.Text = "ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kayitidDataGridViewTextBoxColumn,
            this.isimsoyisimDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.teslimdurumuDataGridViewTextBoxColumn,
            this.enstituDataGridViewTextBoxColumn,
            this.odaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayitlarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(484, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 462);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // kayitidDataGridViewTextBoxColumn
            // 
            this.kayitidDataGridViewTextBoxColumn.DataPropertyName = "kayit_id";
            this.kayitidDataGridViewTextBoxColumn.HeaderText = "kayit_id";
            this.kayitidDataGridViewTextBoxColumn.Name = "kayitidDataGridViewTextBoxColumn";
            // 
            // isimsoyisimDataGridViewTextBoxColumn
            // 
            this.isimsoyisimDataGridViewTextBoxColumn.DataPropertyName = "isim_soyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.HeaderText = "isim_soyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.Name = "isimsoyisimDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // teslimdurumuDataGridViewTextBoxColumn
            // 
            this.teslimdurumuDataGridViewTextBoxColumn.DataPropertyName = "teslim_durumu";
            this.teslimdurumuDataGridViewTextBoxColumn.HeaderText = "teslim_durumu";
            this.teslimdurumuDataGridViewTextBoxColumn.Name = "teslimdurumuDataGridViewTextBoxColumn";
            // 
            // enstituDataGridViewTextBoxColumn
            // 
            this.enstituDataGridViewTextBoxColumn.DataPropertyName = "enstitu";
            this.enstituDataGridViewTextBoxColumn.HeaderText = "enstitu";
            this.enstituDataGridViewTextBoxColumn.Name = "enstituDataGridViewTextBoxColumn";
            // 
            // odaDataGridViewTextBoxColumn
            // 
            this.odaDataGridViewTextBoxColumn.DataPropertyName = "oda";
            this.odaDataGridViewTextBoxColumn.HeaderText = "oda";
            this.odaDataGridViewTextBoxColumn.Name = "odaDataGridViewTextBoxColumn";
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(35, 111);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(102, 20);
            this.ambiance_Label2.TabIndex = 18;
            this.ambiance_Label2.Text = "İsim Soyisim : ";
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(35, 157);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(101, 20);
            this.ambiance_Label3.TabIndex = 19;
            this.ambiance_Label3.Text = "Teslim Tarihi : ";
            // 
            // ambiance_Label4
            // 
            this.ambiance_Label4.AutoSize = true;
            this.ambiance_Label4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label4.Location = new System.Drawing.Point(35, 198);
            this.ambiance_Label4.Name = "ambiance_Label4";
            this.ambiance_Label4.Size = new System.Drawing.Size(119, 20);
            this.ambiance_Label4.TabIndex = 20;
            this.ambiance_Label4.Text = "Teslim Durumu : ";
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(35, 239);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(64, 20);
            this.ambiance_Label5.TabIndex = 21;
            this.ambiance_Label5.Text = "Enstitü : ";
            // 
            // ambiance_Label6
            // 
            this.ambiance_Label6.AutoSize = true;
            this.ambiance_Label6.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label6.Location = new System.Drawing.Point(35, 283);
            this.ambiance_Label6.Name = "ambiance_Label6";
            this.ambiance_Label6.Size = new System.Drawing.Size(48, 20);
            this.ambiance_Label6.TabIndex = 22;
            this.ambiance_Label6.Text = "Oda : ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(163, 109);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = false;
            this.textBox2.Size = new System.Drawing.Size(276, 28);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Ahmet Türk";
            this.textBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(163, 61);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = false;
            this.textBox1.Size = new System.Drawing.Size(145, 28);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.comboBox1.Location = new System.Drawing.Point(163, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 26);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownHeight = 100;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.HoverSelectionColor = System.Drawing.Color.Empty;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 20;
            this.comboBox2.Items.AddRange(new object[] {
            "SAĞLIK BİLİMLERİ ENSTİTÜSÜ",
            "FEN BİLİMLERİ ENSTİTÜSÜ",
            "SOSYAL BİLİMLERİ ENSTİTÜSÜ"});
            this.comboBox2.Location = new System.Drawing.Point(163, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(276, 26);
            this.comboBox2.StartIndex = 0;
            this.comboBox2.TabIndex = 27;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox3.DropDownHeight = 100;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.HoverSelectionColor = System.Drawing.Color.Empty;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.ItemHeight = 20;
            this.comboBox3.Items.AddRange(new object[] {
            "TURUNCU ODA",
            "MAVİ ODA",
            "KAHVERENGİ ODA"});
            this.comboBox3.Location = new System.Drawing.Point(163, 282);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(276, 26);
            this.comboBox3.StartIndex = 0;
            this.comboBox3.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(39, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "KAYDET";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button2.Image = null;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(173, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 30);
            this.button2.TabIndex = 30;
            this.button2.Text = "SİL";
            this.button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button3.Image = null;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(332, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 30);
            this.button3.TabIndex = 31;
            this.button3.Text = "GÜNCELLE";
            this.button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 23);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.pictureBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.dateTimePicker1);
            this.ambiance_ThemeContainer1.Controls.Add(this.button3);
            this.ambiance_ThemeContainer1.Controls.Add(this.button2);
            this.ambiance_ThemeContainer1.Controls.Add(this.button1);
            this.ambiance_ThemeContainer1.Controls.Add(this.comboBox3);
            this.ambiance_ThemeContainer1.Controls.Add(this.comboBox2);
            this.ambiance_ThemeContainer1.Controls.Add(this.comboBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.textBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.textBox2);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label6);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label5);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label4);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label3);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label2);
            this.ambiance_ThemeContainer1.Controls.Add(this.dataGridView1);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label1);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = true;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(1161, 508);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.ambiance_ThemeContainer1.TabIndex = 0;
            this.ambiance_ThemeContainer1.Text = "Toplantı Takip Programı";
            this.ambiance_ThemeContainer1.Click += new System.EventHandler(this.Ambiance_ThemeContainer1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 508);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Form1";
            this.Text = "Toplantı Takip Programı";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplanti1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplanti1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.ambiance_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private toplanti1DataSet toplanti1DataSet;
        private System.Windows.Forms.BindingSource kayitlarBindingSource;
        private toplanti1DataSetTableAdapters.kayitlarTableAdapter kayitlarTableAdapter;
        private toplanti1DataSet1 toplanti1DataSet1;
        private System.Windows.Forms.BindingSource kayitlarBindingSource1;
        private toplanti1DataSet1TableAdapters.kayitlarTableAdapter kayitlarTableAdapter1;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimsoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimdurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enstituDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaDataGridViewTextBoxColumn;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private Ambiance.Ambiance_Label ambiance_Label4;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_Label ambiance_Label6;
        private Ambiance.Ambiance_TextBox textBox2;
        private Ambiance.Ambiance_TextBox textBox1;
        private Ambiance.Ambiance_ComboBox comboBox1;
        private Ambiance.Ambiance_ComboBox comboBox2;
        private Ambiance.Ambiance_ComboBox comboBox3;
        private Ambiance.Ambiance_Button_1 button1;
        private Ambiance.Ambiance_Button_2 button2;
        private Ambiance.Ambiance_Button_1 button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

