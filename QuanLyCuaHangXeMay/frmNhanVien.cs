using System;
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
    public partial class frmNhanVien : Form 
    {
        public static bool them;
        public NhanVien nv_sua = new NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "" || txttennv.Text == "" || cmbchucvu.SelectedIndex == -1 || cmbgioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin !!!");
                txtmanv.Focus();
            }
            else
            {
                if (them == true)
                {
                    List<NhanVien> lst = new List<NhanVien>();
                    lst = NhanVienService.Check_ID(txtmanv.Text);
                    if (lst.Count > 0)
                    {
                        MessageBox.Show("Không được trùng mã nhân viên!!!", "Thông Báo");
                        txtmanv.ResetText();
                        txtmanv.Focus();
                    }
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.MaNhanVien = txtmanv.Text;
                        nv.TenNhanVien = txttennv.Text;
                        nv.Ngayvaolam = dtpkngayvaolam.Value.ToString("MM/dd/yyyy");
                        nv.NgaySinh = dtpkngayvaolam.Value.ToString("MM/dd/yyyy");
                        nv.LuongCoBan = txtluongcoban.Text;
                        nv.Luong = txtLuong.Text;
                        nv.GioiTinh = cmbgioitinh.SelectedItem.ToString();
                        nv.ChucVu = cmbchucvu.SelectedItem.ToString();
                        nv.DiaChi = txtdiachi.Text;
                        nv.DienThoai = txtdienthoai.Text;
                        NhanVienService.NhanVien_Insert(nv);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        this.Close();
                    }

                }
                else
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = txtmanv.Text;
                    nv.TenNhanVien = txttennv.Text;
                    nv.Ngayvaolam = dtpkngayvaolam.Value.ToString();

                    nv.NgaySinh = dtpkngaysinhnv.Value.ToString();
                    nv.LuongCoBan = txtluongcoban.Text;
                    nv.Luong = txtLuong.Text;
                    nv.GioiTinh = cmbgioitinh.Text;
                    nv.ChucVu = cmbchucvu.Text;
                    nv.DiaChi = txtdiachi.Text;
                    nv.DienThoai = txtdienthoai.Text;
                    NhanVienService.NhanVien_Update(nv);
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    this.Close();

                }
            }
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
           
            cmbgioitinh.Items.Add("Nam");
            cmbgioitinh.Items.Add("Nữ");


            cmbchucvu.Items.Add("Trưởng Phòng");
            cmbchucvu.Items.Add("Giám đốc");
            cmbchucvu.Items.Add("Nhân viên");
            if(them==false)
            {
                button1.Enabled = false;
                txtmanv.Enabled = false;
                txtmanv.Text = nv_sua.MaNhanVien;
                txttennv.Text = nv_sua.TenNhanVien;
                txtdiachi.Text = nv_sua.DiaChi;
                txtdienthoai.Text = nv_sua.DienThoai;

                dtpkngaysinhnv.Value = DateTime.ParseExact(nv_sua.NgaySinh, "dd/MM/yyyy", null);
                //dtpkngaysinhnv.Value = DateTime.Parse(nv_sua.NgaySinh);
                cmbgioitinh.SelectedText = nv_sua.GioiTinh;
                cmbchucvu.SelectedText = nv_sua.ChucVu;
                txtLuong.Text = nv_sua.Luong;
                txtluongcoban.Text = nv_sua.LuongCoBan;
              
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtluongcoban.Text = "";
            txtLuong.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";

            cmbchucvu.SelectedIndex = 0;
            cmbgioitinh.SelectedIndex = 0;
            dtpkngaysinhnv.ResetText();
            dtpkngayvaolam.ResetText();
        }

        private void dtpkngayvaolam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            double luongcoban;
            int namvaolam;
            if (cmbchucvu.SelectedItem.ToString() == "Trưởng Phòng")
            {
                luongcoban = 3000000;
                txtluongcoban.Text = luongcoban.ToString();
                namvaolam = dtpkngayvaolam.Value.Year;
                txtLuong.Text = ((namvaolam - 2010)*500000 + luongcoban).ToString();
              
            }
            else if(cmbchucvu.SelectedItem.ToString()=="Giám đốc")
            {
                luongcoban = 4000000;
                txtluongcoban.Text = luongcoban.ToString();
                namvaolam = dtpkngayvaolam.Value.Year;
                txtLuong.Text = ((namvaolam - 2010)*1000000 + luongcoban).ToString();
              
            }
            else
            {
                luongcoban = 2000000;
                txtluongcoban.Text = luongcoban.ToString();
                namvaolam = dtpkngayvaolam.Value.Year;
                txtLuong.Text = ((namvaolam - 2010) * 300000 + luongcoban).ToString();
              
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
