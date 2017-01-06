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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //public static byte[] encryptData(string data)
        //{
        //    System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
        //    byte[] hashedBytes;
        //    System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
        //    hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
        //    return hashedBytes;
        //}
        //public static string md5(string data)
        //{
        //    return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        //}
        void DangNhap()
        {
            if (txttaikhoan.Text.Trim() == string.Empty || txttaikhoan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttaikhoan.Focus();
            }
            else
            {

                List<Users> lst = new List<Users>();
                Users u = new Users();
                //TEST ts=new TEST();
                //ts.Close();
                lst = UserService.Check_Login(txttaikhoan.Text, txtmatkhau.Text);
                if (lst.Count == 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    HeThong ht = new HeThong();
                    string manv = UserService.Get_MaNV(txttaikhoan.Text);
                    HeThong.quyen = UserService.Get_Quyen(txttaikhoan.Text);
                    HeThong.taikhoan = txttaikhoan.Text;
                    ht.manv = manv;
                    this.Hide() ;
                    ht.Show();
                    MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h=MessageBox.Show("Bạn chắc muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

       
        private void txttaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
