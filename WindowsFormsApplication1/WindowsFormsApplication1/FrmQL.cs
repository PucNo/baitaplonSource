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
    public partial class FrmQL : Form
    {
        public FrmQL()
        {
            InitializeComponent();
        }
        public void loaddl()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from bang", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgv1.DataSource = dt;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt1.Focus();
        }
        public SqlConnection con;
        DataSet ds;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'do_AnDataSet.bang' table. You can move, or remove it, as needed.
            this.bangTableAdapter1.Fill(this.do_AnDataSet.bang);

            con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from bang", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgv1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {      //them
            
           
            if (txt1.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Mã Hàng, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else if (txt2.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Tên Hàng, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else if (txt3.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Số lượng, Mời Bạn Nhập Dữ Liệu Bên Trái");

            else if (txt4.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Loại, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else if (txt5.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Giá, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else
            {
                con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into bang(mahang,tenhang,loai,sl,gia) Values ('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm dữ liệu thành công", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddl();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from bang where mahang='" + dtgv1.Rows[dtgv1.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa dữ liệu thành công", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddl();
                con.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=HDN-PC\\SQLEXPRESS;Initial Catalog=Do_An;Integrated Security=True");
            con.Open();
            if (txt1.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Mã Hàng, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else if (txt2.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Tên Hàng, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else if (txt3.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Số lượng, Mời Bạn Nhập Dữ Liệu Bên Trái");

            else if (txt4.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Loại, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else if (txt5.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Giá, Mời Bạn Nhập Dữ Liệu Bên Trái");
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update bang set mahang = N'" + txt1.Text + "',tenhang = N'" + txt2.Text + "',loai = N'" + txt3.Text + "',sl = N'" + txt4.Text + "',gia = N'" + txt5.Text + "' where mahang = '" + dtgv1.Rows[dtgv1.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa dữ liệu thành công", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddl();
                con.Close();
                
            }
            
        }
        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtgv1.CurrentCell.RowIndex;
            txt1.Text = dtgv1.Rows[t].Cells[0].Value.ToString();
            this.txt2.Text = dtgv1.Rows[t].Cells[1].Value.ToString();
            this.txt3.Text = dtgv1.Rows[t].Cells[2].Value.ToString();
            this.txt4.Text = dtgv1.Rows[t].Cells[3].Value.ToString();
            this.txt5.Text = dtgv1.Rows[t].Cells[4].Value.ToString();
            
        }
    }
}