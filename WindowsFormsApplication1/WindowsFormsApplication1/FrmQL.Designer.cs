namespace WindowsFormsApplication1
{
    partial class FrmQL
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.do_AnDataSet = new WindowsFormsApplication1.Do_AnDataSet();
            this.bangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangTableAdapter1 = new WindowsFormsApplication1.Do_AnDataSetTableAdapters.bangTableAdapter();
            this.bTLDataSet4 = new WindowsFormsApplication1.BTLDataSet4();
            this.bTLDataSet1 = new WindowsFormsApplication1.BTLDataSet1();
            this.bTLDataSet = new WindowsFormsApplication1.BTLDataSet();
            this.bangdiaTableAdapter = new WindowsFormsApplication1.BTLDataSetTableAdapters.bangdiaTableAdapter();
            this.bangdiaTableAdapter1 = new WindowsFormsApplication1.BTLDataSet1TableAdapters.bangdiaTableAdapter();
            this.bangTableAdapter = new WindowsFormsApplication1.BTLDataSet4TableAdapters.bangTableAdapter();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_AnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(121, 38);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(235, 20);
            this.txt2.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(121, 64);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(235, 20);
            this.txt3.TabIndex = 5;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(121, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(235, 20);
            this.txt1.TabIndex = 6;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(121, 118);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(235, 20);
            this.txt5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá";
            // 
            // dtgv1
            // 
            this.dtgv1.AutoGenerateColumns = false;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahangDataGridViewTextBoxColumn,
            this.tenhangDataGridViewTextBoxColumn,
            this.loaiDataGridViewTextBoxColumn,
            this.slDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.dtgv1.DataSource = this.bangBindingSource;
            this.dtgv1.Location = new System.Drawing.Point(2, 162);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.Size = new System.Drawing.Size(544, 150);
            this.dtgv1.TabIndex = 12;
            this.dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số Lượng";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(121, 92);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(235, 20);
            this.txt4.TabIndex = 13;
            // 
            // do_AnDataSet
            // 
            this.do_AnDataSet.DataSetName = "Do_AnDataSet";
            this.do_AnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangBindingSource
            // 
            this.bangBindingSource.DataMember = "bang";
            this.bangBindingSource.DataSource = this.do_AnDataSet;
            // 
            // bangTableAdapter1
            // 
            this.bangTableAdapter1.ClearBeforeFill = true;
            // 
            // bTLDataSet4
            // 
            this.bTLDataSet4.DataSetName = "BTLDataSet4";
            this.bTLDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bTLDataSet1
            // 
            this.bTLDataSet1.DataSetName = "BTLDataSet1";
            this.bTLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bTLDataSet
            // 
            this.bTLDataSet.DataSetName = "BTLDataSet";
            this.bTLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangdiaTableAdapter
            // 
            this.bangdiaTableAdapter.ClearBeforeFill = true;
            // 
            // bangdiaTableAdapter1
            // 
            this.bangdiaTableAdapter1.ClearBeforeFill = true;
            // 
            // bangTableAdapter
            // 
            this.bangTableAdapter.ClearBeforeFill = true;
            // 
            // mahangDataGridViewTextBoxColumn
            // 
            this.mahangDataGridViewTextBoxColumn.DataPropertyName = "mahang";
            this.mahangDataGridViewTextBoxColumn.HeaderText = "Ma Hàng";
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
            // FrmQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hàng Điện Tử";
            this.Load += new System.EventHandler(this.FrmQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_AnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgv1;
        private BTLDataSet bTLDataSet;
        private BTLDataSetTableAdapters.bangdiaTableAdapter bangdiaTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4;
        private BTLDataSet1 bTLDataSet1;
        private BTLDataSet1TableAdapters.bangdiaTableAdapter bangdiaTableAdapter1;
        private BTLDataSet4 bTLDataSet4;
        private BTLDataSet4TableAdapters.bangTableAdapter bangTableAdapter;
        private Do_AnDataSet do_AnDataSet;
        private System.Windows.Forms.BindingSource bangBindingSource;
        private Do_AnDataSetTableAdapters.bangTableAdapter bangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
    }
}