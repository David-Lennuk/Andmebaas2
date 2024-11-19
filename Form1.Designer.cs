namespace Andmebass2
{
    partial class Form1
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
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.Nimetus_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lisa = new System.Windows.Forms.Button();
            this.Kustuta = new System.Windows.Forms.Button();
            this.Uuenda = new System.Windows.Forms.Button();
            this.Pildi_otsing = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.andmebaas_Tarpv23DataSet = new Andmebaas2.Andmebaas_Tarpv23DataSet();
            this.toodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodeTableAdapter = new Andmebaas2.Andmebaas_Tarpv23DataSetTableAdapters.ToodeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmebaas_Tarpv23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_txt
            // 
            this.Id_txt.Location = new System.Drawing.Point(81, 48);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(100, 20);
            this.Id_txt.TabIndex = 11;
            // 
            // Nimetus_txt
            // 
            this.Nimetus_txt.Location = new System.Drawing.Point(81, 74);
            this.Nimetus_txt.Name = "Nimetus_txt";
            this.Nimetus_txt.Size = new System.Drawing.Size(100, 20);
            this.Nimetus_txt.TabIndex = 12;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Location = new System.Drawing.Point(81, 100);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(100, 20);
            this.Kogus_txt.TabIndex = 13;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Location = new System.Drawing.Point(81, 126);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(100, 20);
            this.Hind_txt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nimetus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hind";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Lisa
            // 
            this.Lisa.Location = new System.Drawing.Point(15, 209);
            this.Lisa.Name = "Lisa";
            this.Lisa.Size = new System.Drawing.Size(112, 23);
            this.Lisa.TabIndex = 20;
            this.Lisa.Text = "Lisa andmed";
            this.Lisa.UseVisualStyleBackColor = true;
            this.Lisa.Click += new System.EventHandler(this.Lisa_Click);
            // 
            // Kustuta
            // 
            this.Kustuta.Location = new System.Drawing.Point(133, 209);
            this.Kustuta.Name = "Kustuta";
            this.Kustuta.Size = new System.Drawing.Size(112, 23);
            this.Kustuta.TabIndex = 21;
            this.Kustuta.Text = "Kustuta";
            this.Kustuta.UseVisualStyleBackColor = true;
            this.Kustuta.Click += new System.EventHandler(this.Kustuta_Click);
            // 
            // Uuenda
            // 
            this.Uuenda.Location = new System.Drawing.Point(251, 209);
            this.Uuenda.Name = "Uuenda";
            this.Uuenda.Size = new System.Drawing.Size(112, 23);
            this.Uuenda.TabIndex = 22;
            this.Uuenda.Text = "Uuenda";
            this.Uuenda.UseVisualStyleBackColor = true;
            this.Uuenda.Click += new System.EventHandler(this.Uuenda_Click);
            // 
            // Pildi_otsing
            // 
            this.Pildi_otsing.Location = new System.Drawing.Point(369, 209);
            this.Pildi_otsing.Name = "Pildi_otsing";
            this.Pildi_otsing.Size = new System.Drawing.Size(112, 23);
            this.Pildi_otsing.TabIndex = 23;
            this.Pildi_otsing.Text = "Pildi otsing";
            this.Pildi_otsing.UseVisualStyleBackColor = true;
            this.Pildi_otsing.Click += new System.EventHandler(this.Pildi_otsing_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn,
            this.piltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 186);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // andmebaas_Tarpv23DataSet
            // 
            this.andmebaas_Tarpv23DataSet.DataSetName = "Andmebaas_Tarpv23DataSet";
            this.andmebaas_Tarpv23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodeBindingSource
            // 
            this.toodeBindingSource.DataMember = "Toode";
            this.toodeBindingSource.DataSource = this.andmebaas_Tarpv23DataSet;
            // 
            // toodeTableAdapter
            // 
            this.toodeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimetusDataGridViewTextBoxColumn
            // 
            this.nimetusDataGridViewTextBoxColumn.DataPropertyName = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.HeaderText = "Nimetus";
            this.nimetusDataGridViewTextBoxColumn.Name = "nimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // piltDataGridViewTextBoxColumn
            // 
            this.piltDataGridViewTextBoxColumn.DataPropertyName = "Pilt";
            this.piltDataGridViewTextBoxColumn.HeaderText = "Pilt";
            this.piltDataGridViewTextBoxColumn.Name = "piltDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pildi_otsing);
            this.Controls.Add(this.Uuenda);
            this.Controls.Add(this.Kustuta);
            this.Controls.Add(this.Lisa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Nimetus_txt);
            this.Controls.Add(this.Id_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmebaas_Tarpv23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.TextBox Nimetus_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Lisa;
        private System.Windows.Forms.Button Kustuta;
        private System.Windows.Forms.Button Uuenda;
        private System.Windows.Forms.Button Pildi_otsing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Andmebaas2.Andmebaas_Tarpv23DataSet andmebaas_Tarpv23DataSet;
        private System.Windows.Forms.BindingSource toodeBindingSource;
        private Andmebaas2.Andmebaas_Tarpv23DataSetTableAdapters.ToodeTableAdapter toodeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piltDataGridViewTextBoxColumn;
    }
}

