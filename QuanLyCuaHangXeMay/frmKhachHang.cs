using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangXeMay.BUS;
using QuanLyCuaHangXeMay.Entity;
namespace QuanLyCuaHangXeMay
{
    public partial class frmKhachHang : Form
    {
       public static bool them;
       public KhachHang kh_sua = new KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmaKH.Text = "";
            txtTenKH.Text = "";
            txtEmailKH.Text = "";
            txtDienThoaiKH.Text = "";
            txtDiaChiKH.Text = "";
            dtpkngaysinhKH.ResetText();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtmaKH.Focus();
            txtmaKH.Select();
            if(them==false)
           {
               button1.Enabled = false;
               txtmaKH.Enabled=false;
               txtmaKH.Text = kh_sua.MaKH;
               txtTenKH.Text = kh_sua.TenKH;
               txtDiaChiKH.Text = kh_sua.DiaChi;
               txtDienThoaiKH.Text = kh_sua.DienThoai;
               txtEmailKH.Text = kh_sua.Email;
               DateTime date = DateTime.ParseExact(kh_sua.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
               dtpkngaysinhKH.Value = date;
       
           }
        }

        private void txtmaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmaKH.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!");
                txtmaKH.Focus();

            }
            else
            {
                if (them == true)
                {
                    List<KhachHang> lst = new List<KhachHang>();
                    lst = KhachHangService.Check_ID(txtmaKH.Text);
                    if (lst.Count > 0)
                    {
                        MessageBox.Show("Không được trùng mã khách hàng!!!", "Thông Báo");
                        txtmaKH.ResetText();
                        txtmaKH.Focus();
                    }
                    else
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKH = txtmaKH.Text;
                        kh.TenKH = txtTenKH.Text;
                        string h = dtpkngaysinhKH.Value.ToString("MM/dd/yyyy");
                        kh.NgaySinh = h;
                        kh.DiaChi = txtDiaChiKH.Text;
                        kh.DienThoai = txtDienThoaiKH.Text;
                        kh.Email = txtEmailKH.Text;
                        KhachHangService.KhachHang_Insert(kh);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        this.Close();
                    }


                }
                else
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = txtmaKH.Text;
                    kh.TenKH = txtTenKH.Text;
                    string h = dtpkngaysinhKH.Value.ToString("MM/dd/yyyy");
                    kh.NgaySinh = h;
                    kh.DiaChi = txtDiaChiKH.Text;
                    kh.DienThoai = txtDienThoaiKH.Text;
                    kh.Email = txtEmailKH.Text;
                    KhachHangService.KhachHang_Update(kh);
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    this.Close();
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(h==DialogResult.Yes)
                this.Close();
        }
    }
}
