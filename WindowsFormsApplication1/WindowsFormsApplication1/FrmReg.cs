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
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
       
        //
        /// <summary>
        /// 
        /// </summary>
        //  ;
        

        

        private void FrmReg_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" ;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            

            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show(" 2 ô mật khẩu ko giống nhau, vui lòng nhập lại ");
                textBox1.Focus();
               
                
            }
            else
            {

                try
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "")
                    {
                        MessageBox.Show("Mời bạn nhập thông tin đăng ký");
                        textBox1.Focus();
                    }
                    else
                    {

                        cmd.CommandText = "insert into nguoidung(Tendn,mk) values ('" + textBox1.Text + "','" + textBox2.Text + "')";//,'" + dateTimePicker1.Value.ToShortDateString + "')";;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm tài khoản mới vào CSDL.  " + textBox1.Text + "  chúc mừng bạn đã đăng ký thành công ");

                        SqlDataAdapter da = new SqlDataAdapter("select *from nguoidung", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        con.Dispose();
                        cmd.Dispose();
                        ds.Dispose();
                        da.Dispose();
                        this.Close();
                        
                       
                       

                    }
                }
                catch (Exception eee)
                {
                    MessageBox.Show("Lỗi nữa rùi : " + eee.Message);
                }
            }



        
        }

        

       


    }
}
