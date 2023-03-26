namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bTLDataSet5 = new WindowsFormsApplication1.BTLDataSet5();
            this.bTLDataSet3 = new WindowsFormsApplication1.BTLDataSet3();
            this.bangdiaTableAdapter = new WindowsFormsApplication1.BTLDataSet3TableAdapters.bangdiaTableAdapter();
            this.bangTableAdapter = new WindowsFormsApplication1.BTLDataSet5TableAdapters.bangTableAdapter();
            this.do_AnDataSet2 = new WindowsFormsApplication1.Do_AnDataSet2();
            this.bangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangTableAdapter1 = new WindowsFormsApplication1.Do_AnDataSet2TableAdapters.bangTableAdapter();
            this.mahangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_AnDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bTLDataSet5
            // 
            this.bTLDataSet5.DataSetName = "BTLDataSet5";
            this.bTLDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bTLDataSet3
            // 
            this.bTLDataSet3.DataSetName = "BTLDataSet3";
            this.bTLDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangdiaTableAdapter
            // 
            this.bangdiaTableAdapter.ClearBeforeFill = true;
            // 
            // bangTableAdapter
            // 
            this.bangTableAdapter.ClearBeforeFill = true;
            // 
            // do_AnDataSet2
            // 
            this.do_AnDataSet2.DataSetName = "Do_AnDataSet2";
            this.do_AnDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangBindingSource
            // 
            this.bangBindingSource.DataMember = "bang";
            this.bangBindingSource.DataSource = this.do_AnDataSet2;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Hàng Điện Tử";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTLDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.do_AnDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BTLDataSet3 bTLDataSet3;
        private BTLDataSet3TableAdapters.bangdiaTableAdapter bangdiaTableAdapter;
        private BTLDataSet5 bTLDataSet5;
        private BTLDataSet5TableAdapters.bangTableAdapter bangTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Do_AnDataSet2 do_AnDataSet2;
        private System.Windows.Forms.BindingSource bangBindingSource;
        private Do_AnDataSet2TableAdapters.bangTableAdapter bangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
    }
}