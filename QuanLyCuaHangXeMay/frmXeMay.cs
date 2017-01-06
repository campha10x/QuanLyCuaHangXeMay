using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.Entity;
using QuanLyCuaHangXeMay.BUS;
namespace QuanLyCuaHangXeMay
{
    public partial class frmXeMay : Form
    {
        public static bool them;
        public MatHang mh_sua = new MatHang();
        public frmXeMay()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        void Refresh_XeMay()
        {
            txtmaxe.Text="";
            txtnsx.Text="";
            txttenxe.Text="";
            txtthongtinbh.Text = "";
            txtdongia.Text = "";
            txthangxe.Text = "";
            nmrudsoluong.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh_XeMay();
        }

        private void frmXeMay_Load(object sender, EventArgs e)
        {
            txtmaxe.Focus();
            if(them==false)
            {
                txtmaxe.Enabled = false;
                button1.Enabled = false;
                txtmaxe.Text = mh_sua.MaXe;
                txttenxe.Text = mh_sua.TenXe;
                txthangxe.Text = mh_sua.TenHangXe;
                txtnsx.Text = mh_sua.NhaSX;
                txtthongtinbh.Text = mh_sua.ThongTinBaoHanh;
                txtdongia.Text = mh_sua.DonGia;
                nmrudsoluong.Value = Convert.ToInt32(mh_sua.SoLuong);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtmaxe.Text==""||txttenxe.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!");
                txtmaxe.Focus();
            }
            else
            {
                if (them == true)
                {
                    List<MatHang> lst = new List<MatHang>();
                    lst = MatHangService.Check_ID(txtmaxe.Text);
                    if (lst.Count > 0)
                    {
                        MessageBox.Show("Không được trùng mã xe!!!", "Thông Báo");
                        txtmaxe.ResetText();
                        txtmaxe.Focus();
                    }
                    else
                    {
                        MatHang mh = new MatHang();
                        mh.MaXe = txtmaxe.Text;
                        mh.NhaSX = txtnsx.Text;
                        mh.SoLuong = nmrudsoluong.Value.ToString();
                        mh.TenHangXe = txthangxe.Text;
                        mh.TenXe = txttenxe.Text;
                        mh.ThongTinBaoHanh = txtthongtinbh.Text;
                        mh.DonGia = txtdongia.Text;
                        MatHangService.MatHang_Insert(mh);
                        MessageBox.Show("Insert thành công", "Thông báo");
                        this.Close();
                    }
                }
                else
                {
                    MatHang mh = new MatHang();
                    mh.MaXe = txtmaxe.Text;
                    mh.NhaSX = txtnsx.Text;
                    mh.SoLuong = nmrudsoluong.Value.ToString();
                    mh.TenHangXe = txthangxe.Text;
                    mh.TenXe = txttenxe.Text;
                    mh.ThongTinBaoHanh = txtthongtinbh.Text;
                    mh.DonGia = txtdongia.Text;
                    MatHangService.MatHang_Update(mh);
                    MessageBox.Show("Update thành công", "Thông báo");
                    this.Close();
                }
            }
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }
    }
}
