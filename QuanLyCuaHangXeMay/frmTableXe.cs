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
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCuaHangXeMay
{
    public partial class frmTableXe : Form
    {
        public delegate void Send_MaNhaCC(string value1,string value2);
        public Send_MaNhaCC send;
        int start;
        private void loadData()
        {
            //SqlCommand cmd;
            //string sql = "SELECT * FROM Xe";
            //cmd = new SqlCommand(sql, con);
            //adapter.SelectCommand = cmd;
            //adapter.Fill(ds, start, 5, "Xe");

            //dtgrvxe.DataSource = ds.Tables[0];
            dtgrvxe.DataSource = MatHangService.PhanTrang_Xe(start, 10).Tables[0];
          //  btnback.Enabled = false;
        }
         public frmTableXe()
        {
            InitializeComponent();
            start = 0;
            loadData();
        }

         public frmTableXe(Send_MaNhaCC sender)
         {
             InitializeComponent();
             //this.send = sender;
         }
      
        private void frmTableXe_Load(object sender, EventArgs e)
        {
          
           // dtgrvxe.DataSource = MatHangService.MatHang_GetByTop("", "", "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (send != null)
            {
                string strChuoiCon = dtgrvxe.CurrentRow.Cells["Column1"].Value.ToString();
                string strChuoiCon1 = dtgrvxe.CurrentRow.Cells["Column7"].Value.ToString();
                send(strChuoiCon,strChuoiCon1);
                
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrvxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgrvxe.DataSource = MatHangService.MatHang_Search(RemoveUnicode(txtxe.Text));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void txtxe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgrvxe.DataSource = MatHangService.MatHang_Search(RemoveUnicode(txtxe.Text));
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void cmbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            start = start + 10;

            if (start > MatHangService.TongSoLuong_Xe()-1)
            {
                start = 0;
            }
            //ds.Clear();
            dtgrvxe.DataSource = MatHangService.PhanTrang_Xe(start, 10).Tables[0];
           // adapter.Fill(ds, start, 5, "Xe");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            start = start - 10;
            if (start<0)
            {
                start = 0;
              //  btnback.Enabled = false;
              

            }
            dtgrvxe.DataSource = MatHangService.PhanTrang_Xe(start, 10).Tables[0];
            
            //ds.Clear();
            //adapter.Fill(ds, start, 5, "Xe");
        }
    }
}
