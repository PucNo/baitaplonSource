﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;



namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_AnDataSet2.bang' table. You can move, or remove it, as needed.
            this.bangTableAdapter1.Fill(this.do_AnDataSet2.bang);
        }

       
        private void export2Excel(DataGridView g, string duongDan,string tentap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                    if(g.Rows[i].Cells[j].Value != null)
                {
                    obj.Cells[i+2, j+1] = g.Rows[i].Cells[j].Value.ToString();
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tentap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\", "bang dien thoai");
            MessageBox.Show("Bạn đã xuất Excel thành công ở ổ D:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
