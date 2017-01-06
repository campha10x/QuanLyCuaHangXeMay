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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mk1, mk2;
            mk1 = txtmatkhaumoi1.Text;
            mk2 = txtmatkhaumoi2.Text;
            List<Users> lst = new List<Users>();
            lst = UserService.Check_Password(txtmatkhaucu.Text);
            if(lst.Count>0&&String.Compare(mk1,mk2)==0)
            {
                HeThong ht=new HeThong();
               Users us=new Users();
               us.User = HeThong.taikhoan;
               us.MatKhauMoi = txtmatkhaumoi1.Text;
               
               us.MatKhauCu = txtmatkhaucu.Text;
               UserService.User_Update(us);
               MessageBox.Show("Đổi mật khẩu thành công!!!");
               this.Close();
                
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng!!!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc muốn huỷ  không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
