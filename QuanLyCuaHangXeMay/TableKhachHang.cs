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
namespace QuanLyCuaHangXeMay
{
    public partial class TableKhachHang : Form
    {
        public delegate void Send_MaKH(string value);
        public Send_MaKH send;
        int start;
        private void loadData()
        {

            dtgrvkhachhang.DataSource = KhachHangService.PhanTrang_KhachHang(start, 10).Tables[0];
        }
        
        public TableKhachHang()
        {
            InitializeComponent();
            start=0;
            loadData();
        }
        public TableKhachHang(Send_MaKH sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",  
                    "đ",  
                    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",  
                    "í","ì","ỉ","ĩ","ị",  
                    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",  
                    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",  
                    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",  
                        "d",  
                        "e","e","e","e","e","e","e","e","e","e","e",  
                        "i","i","i","i","i",  
                        "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",  
                        "u","u","u","u","u","u","u","u","u","u","u",  
                        "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }  
        private void TableKhachHang_Load(object sender, EventArgs e)
        {
         //   dtgrvkhachhang.DataSource = KhachHangService.KhachHang_GetByTop("", "", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (send != null)
            {
                string strChuoiCon = dtgrvkhachhang.CurrentRow.Cells["Column1"].Value.ToString();
                send(strChuoiCon);
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgrvkhachhang.DataSource = KhachHangService.KhachHang_Search(RemoveUnicode(txttenkh.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtgrvkhachhang.DataSource = KhachHangService.KhachHang_Search(RemoveUnicode(txttenkh.Text));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            start = start + 10;

            if (start > KhachHangService.TongSoLuong_KhachHang() - 1)
            {
                start = 0;
            }

            dtgrvkhachhang.DataSource = KhachHangService.PhanTrang_KhachHang(start, 10).Tables[0];
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            start = start - 10;
            if (start < 0)
            {
                start = 0;

            }
            dtgrvkhachhang.DataSource = KhachHangService.PhanTrang_KhachHang(start, 10).Tables[0];
        }
    }
}
