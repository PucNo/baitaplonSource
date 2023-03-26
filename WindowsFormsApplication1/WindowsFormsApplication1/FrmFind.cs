using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class FrmFind : Form
    {
        public FrmFind()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public DataView dw;
        public DataTable dt;
        private void FrmFind_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_AnDataSet1.bang' table. You can move, or remove it, as needed.
            this.bangTableAdapter1.Fill(this.do_AnDataSet1.bang);
          
            con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from bang",con);
            dt = new DataTable("bang");
            da.Fill(dt);
            dw = new DataView(dt);
            dataGridView1.DataSource = dw;

        }

        private void button1_Click(object sender, EventArgs e)
        {         
            String tenbd = textBox1.Text;
            dw.RowFilter = "tenhang like '" + tenbd + "%'";
            dataGridView1.DataSource = dw;

        }   
      
    }
}
