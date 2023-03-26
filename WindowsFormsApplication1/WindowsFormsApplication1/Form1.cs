using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        public SqlConnection con;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // tk đăng nhập = admin , mk = admin;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Mời bạn nhập Tài Khoản hoặc Mật Khẩu");
                textBox1.Focus();
            }
            else
            {
                con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from nguoidung where Tendn='" + textBox1.Text + "'and mk = '" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label3.Text = "Đăng Nhập Thành Công";
                    Form2 f = (Form2)this.MdiParent;
                    f.enablefull();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Đăng nhập thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    label3.Text = "Tên Đăng Nhập hoặc Mật Khẩu sai";
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg frm = new FrmReg();
            frm.Show();
           this.Close();
        }
    }
}
