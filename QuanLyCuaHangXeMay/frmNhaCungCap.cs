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
    public partial class frmNhaCungCap : Form
    {
        public bool them;
        public NhaCungCap ncc_sua=new NhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtten.Text = "";
            txtemail.Text = "";
            txtdt.Text = "";
            txtdc.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!");
                txtma.Focus();

            }
            else
            {
                if (them == true)
                {
                    List<NhaCungCap> lst = new List<NhaCungCap>();
                    lst = NhaCungCapService.Check_ID(txtma.Text);
                    if (lst.Count > 0)
                    {
                        MessageBox.Show("Không được trùng mã nhà cung cấp!!!", "Thông Báo");
                        txtma.ResetText();
                        txtma.Focus();
                    }
                    else
                    {
                        NhaCungCap ncc = new NhaCungCap();
                        ncc.MaNhaCC = txtma.Text;
                        ncc.TenNhaCC = txtten.Text;
                        ncc.Email = txtemail.Text;
                        ncc.DienThoai = txtdt.Text;
                        ncc.DiaChi = txtdc.Text;
                        NhaCungCapService.NhaCungCap_Insert(ncc);
                        MessageBox.Show("Insert thành công", "Thông báo");
                        this.Close();
                    }

                }
                else
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaNhaCC = txtma.Text;
                    ncc.TenNhaCC = txtten.Text;
                    ncc.Email = txtemail.Text;
                    ncc.DienThoai = txtdt.Text;
                    ncc.DiaChi = txtdc.Text;
                    NhaCungCapService.NhaCungCap_Update(ncc);
                    MessageBox.Show("Update thành công", "Thông báo");
                    this.Close();
                }
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            if(them==false)
            {
                
                button1.Enabled = false;
                txtma.Enabled = false;
              
                txtma.Text= ncc_sua.MaNhaCC;
                txtten.Text = ncc_sua.TenNhaCC;
                txtemail.Text = ncc_sua.Email;
                txtdt.Text = ncc_sua.DienThoai;
                txtdc.Text = ncc_sua.DiaChi;
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (h == DialogResult.Yes)
                this.Close();
        }
    }
}
