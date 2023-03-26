namespace WindowsFormsApplication1
{
    partial class FrmFind
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bTLDataSet6 = new WindowsFormsApplication1.BTLDataSet6();
            this.bTLDataSet2 = new WindowsFormsApplication1.BTLDataSet2();
            this.bangdiaTableAdapter = new WindowsFormsApplication1.BTLDataSet2TableAdapters.bangdiaTableAdapter();
            this.bangTableAdapter = new WindowsFormsApplication1.BTLDataSet6TableAdapters.bangTableAdapter();
            this.do_AnDataSet1 = new WindowsFormsApplication1.Do_AnDataSet1();
            this.bangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangTableAdapter1 = new WindowsFormsApplication1.Do_AnDataSet1TableAdapters.bangTableAdapter();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_AnDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.tenhangDataGridViewTextBoxColumn,
            this.loaiDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Tên Hàng";
            // 
            // bTLDataSet6
            // 
            this.bTLDataSet6.DataSetName = "BTLDataSet6";
            this.bTLDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bTLDataSet2
            // 
            this.bTLDataSet2.DataSetName = "BTLDataSet2";
            this.bTLDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangdiaTableAdapter
            // 
            this.bangdiaTableAdapter.ClearBeforeFill = true;
            // 
            // bangTableAdapter
            // 
            this.bangTableAdapter.ClearBeforeFill = true;
            // 
            // do_AnDataSet1
            // 
            this.do_AnDataSet1.DataSetName = "Do_AnDataSet1";
            this.do_AnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangBindingSource
            // 
            this.bangBindingSource.DataMember = "bang";
            this.bangBindingSource.DataSource = this.do_AnDataSet1;
            // 
            // bangTableAdapter1
            // 
            this.bangTableAdapter1.ClearBeforeFill = true;
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Mã Hàng";
            this.mahangDataGridViewTextBoxColumn.Name = "mahangDataGridViewTextBoxColumn";
            // 
            // tenhangDataGridViewTextBoxColumn
            // 
            this.tenhangDataGridViewTextBoxColumn.DataPropertyName = "tenhang";
            this.tenhangDataGridViewTextBoxColumn.HeaderText = "Tên Hàng";
            this.tenhangDataGridViewTextBoxColumn.Name = "tenhangDataGridViewTextBoxColumn";
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loại";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            // 
            // slDataGridViewTextBoxColumn
            // 
            this.slDataGridViewTextBoxColumn.DataPropertyName = "sl";
            this.slDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.slDataGridViewTextBoxColumn.Name = "slDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FrmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFind";
            this.Load += new System.EventHandler(this.FrmFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_AnDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private BTLDataSet2 bTLDataSet2;
        private BTLDataSet2TableAdapters.bangdiaTableAdapter bangdiaTableAdapter;
        private BTLDataSet6 bTLDataSet6;
        private BTLDataSet6TableAdapters.bangTableAdapter bangTableAdapter;
        private Do_AnDataSet1 do_AnDataSet1;
        private System.Windows.Forms.BindingSource bangBindingSource;
        private Do_AnDataSet1TableAdapters.bangTableAdapter bangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;

    }
}