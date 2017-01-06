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
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
namespace QuanLyCuaHangXeMay
{
    public partial class HeThong : Form
    {


       
    
        public static string taikhoan;
        public string manv;
        public static string quyen;
        bool them_nhaphang, them_xuathang,sua_nhaphanghd,sua_pn;
      
        int dong_px,dong_pn;
        string mahdpx,mapn;
        void HienThi_NhaCungCap()
        {
            dtgrvNhaCC.DataSource = NhaCungCapService.NhaCungCap_GetByTop("", "", "");
        }
        void HienThi_NhanVien()
        {
            dtgrvNhanVien.DataSource = NhanVienService.NhanVien_GetByTop("", "", "");
        
        }
      void HienThi_KhachHang()
        {
            dtgrvKhachHang.DataSource = KhachHangService.KhachHang_GetByTop("", "", "");    
        }
        void HienThi_Xe()
      {

          dtgrvxe.DataSource = MatHangService.MatHang_GetByTop("", "", "");
      }
        void HienThi_PhieuNhap()
        {
            dtgrvphieunhap.DataSource = PhieuNhapService.PhieuNhap_GetByTop("", "", "");
            
        }
        void HienThi_ChiTietPhieuNhap()
        {

            dtgrvctpn.DataSource = ChiTietPhieuNhapService.ChiTietPhieuNhap_GetByTop("", "", "");

        }
        void HienThi_PhieuXuat()
        {

            dtgrvphieuxuat.DataSource = PhieuXuatService.PhieuXuat_GetByTop("", "", "");

        }
        void HienThi_ChiTietPhieuXuat()
        {

            dtgrvchitietpx.DataSource = ChiTietPhieuXuatService.ChiTietPhieuXuat_GetByTop("", "", "");

        }
        public HeThong()
        {
            InitializeComponent();
        }

        private void thayĐổiMậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        void Search_KH()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            SqlDataReader reader = KhachHangService.Select_TenKH();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto.Add(reader["TenKH"].ToString());
                }
            }

            txttenkh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txttenkh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttenkh.AutoCompleteCustomSource = auto;

        }
        void Load_NhapHang()
        {
            txtmanv.Text = manv;
            txtmanv.Enabled = false;
            DataTable dt= NhaCungCapService.Load_NhaCC().Tables[0];
            cbbmanhacc.DataSource=dt;
            cbbmanhacc.ValueMember = dt.Columns[0].ToString();
            cbbmanhacc.DisplayMember = dt.Columns[1].ToString() ;
           
                
        }
        void Load_ChiTietNhapHang()
        {
            DataTable dt = MatHangService.Load_Xe().Tables[0];
            cbbmaxe.DataSource = dt;
            cbbmaxe.ValueMember = dt.Columns[0].ToString();
            cbbmaxe.DisplayMember = dt.Columns[1].ToString();
        }
        void Phan_Quyen()
        {
            if(String.Compare(quyen,"nhanvien")==0)
            {
                tabControl1.TabPages.Remove(tabPage2);
                nhânViênToolStripMenuItem.Visible = false;
                tồnKhoToolStripMenuItem.Visible = false;
            }
           
        }
        private void HeThong_Load(object sender, EventArgs e)
        {
          
            HienThi_NhanVien();
            HienThi_KhachHang();
            HienThi_NhaCungCap();
            HienThi_Xe();
            HienThi_PhieuNhap();
            HienThi_ChiTietPhieuNhap();
            HienThi_ChiTietPhieuXuat();
            HienThi_PhieuXuat();
            Phan_Quyen();
            txtmanv.Text = manv;
            txtmanv.Enabled = false;
            txtmanvpx.Text = manv;
            label25.Text = taikhoan;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xoá không? ", "Thông báo",  MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
           if(h==DialogResult.Yes)
           {
                 NhanVien nv = new NhanVien();
                nv.MaNhanVien = dtgrvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                NhanVienService.NhanVien_Delete(nv);
                HienThi_NhanVien();
           }

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public  void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frmNhanVien.them = true;
            frm.ShowDialog();
        
            HienThi_NhanVien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frmNhanVien.them = false;

            frm.nv_sua.MaNhanVien = dtgrvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            frm.nv_sua.TenNhanVien = dtgrvNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            frm.nv_sua.NgaySinh = dtgrvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            frm.nv_sua.GioiTinh = dtgrvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            frm.nv_sua.DiaChi = dtgrvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            frm.nv_sua.DienThoai = dtgrvNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();

            frm.nv_sua.ChucVu = dtgrvNhanVien.CurrentRow.Cells["Chucvu"].Value.ToString();
            frm.nv_sua.Ngayvaolam = dtgrvNhanVien.CurrentRow.Cells["Ngayvaolam"].Value.ToString();
            frm.nv_sua.Luong = dtgrvNhanVien.CurrentRow.Cells["LuongCoBan"].Value.ToString();
            frm.nv_sua.LuongCoBan = dtgrvNhanVien.CurrentRow.Cells["Luong"].Value.ToString();
            
            frm.ShowDialog();
            HienThi_NhanVien();
        }

        private void dtgrvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearchnv_TextChanged(object sender, EventArgs e)
        {

                   
        }

        private void txtsearchnv_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void txtsearchnv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgrvNhanVien.DataSource = NhanVienService.NhanVien_Search(RemoveUnicode(txtsearchnv.Text));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThi_NhanVien();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xoá không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                
                KhachHang kh = new KhachHang();
                kh.MaKH = dtgrvKhachHang.CurrentRow.Cells["Column1"].Value.ToString();
                KhachHangService.KhachHang_Delete(kh);
                HienThi_KhachHang();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HienThi_KhachHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frmKhachHang.them = true;
            frm.ShowDialog();
            HienThi_KhachHang();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frmKhachHang.them = false;

            frm.kh_sua.DiaChi = dtgrvKhachHang.CurrentRow.Cells["Column4"].Value.ToString();
            frm.kh_sua.DienThoai = dtgrvKhachHang.CurrentRow.Cells["Column5"].Value.ToString();
            frm.kh_sua.NgaySinh = dtgrvKhachHang.CurrentRow.Cells["Column3"].Value.ToString();
            frm.kh_sua.Email = dtgrvKhachHang.CurrentRow.Cells["Column6"].Value.ToString();
            frm.kh_sua.TenKH = dtgrvKhachHang.CurrentRow.Cells["Column2"].Value.ToString();
            frm.kh_sua.MaKH = dtgrvKhachHang.CurrentRow.Cells["Column1"].Value.ToString();

          
            frm.ShowDialog();
            HienThi_KhachHang();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            HienThi_NhaCungCap();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.them = true;
            frm.ShowDialog();
          
            HienThi_NhaCungCap();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           

            frmNhaCungCap frm = new frmNhaCungCap();
            frm.them = false;

            frm.ncc_sua.MaNhaCC = dtgrvNhaCC.CurrentRow.Cells["Column7"].Value.ToString();
            frm.ncc_sua.TenNhaCC = dtgrvNhaCC.CurrentRow.Cells["Column8"].Value.ToString();
            frm.ncc_sua.DiaChi = dtgrvNhaCC.CurrentRow.Cells["Column9"].Value.ToString();
            frm.ncc_sua.DienThoai = dtgrvNhaCC.CurrentRow.Cells["Column10"].Value.ToString();
            frm.ncc_sua.Email = dtgrvNhaCC.CurrentRow.Cells["Column11"].Value.ToString();

            frm.ShowDialog();
            HienThi_NhaCungCap();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xoá không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCC = dtgrvNhaCC.CurrentRow.Cells["Column7"].Value.ToString();
                NhaCungCapService.NhaCungCap_Delete(ncc);
                HienThi_NhaCungCap();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xoá không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                MatHang mh = new MatHang();
                mh.MaXe = dtgrvxe.CurrentRow.Cells["Column12"].Value.ToString();
                MatHangService.MatHang_Delete(mh);
                HienThi_Xe();
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dtgrvxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmXeMay frm = new frmXeMay();
            frmXeMay.them = true;
            frm.ShowDialog();
            HienThi_Xe();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmXeMay frm = new frmXeMay();
            frmXeMay.them = false;
            frm.mh_sua.MaXe = dtgrvxe.CurrentRow.Cells["Column12"].Value.ToString();
            frm.mh_sua.TenXe = dtgrvxe.CurrentRow.Cells["Column13"].Value.ToString();
            frm.mh_sua.SoLuong = dtgrvxe.CurrentRow.Cells["Column14"].Value.ToString();
            frm.mh_sua.ThongTinBaoHanh = dtgrvxe.CurrentRow.Cells["Column15"].Value.ToString();
            frm.mh_sua.NhaSX = dtgrvxe.CurrentRow.Cells["Column16"].Value.ToString();
            frm.mh_sua.TenHangXe = dtgrvxe.CurrentRow.Cells["Column17"].Value.ToString();
            frm.mh_sua.DonGia = dtgrvxe.CurrentRow.Cells["Column18"].Value.ToString();
            frm.ShowDialog();
            HienThi_Xe();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HienThi_Xe();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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
        private void txttenkh_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           {
               dtgrvKhachHang.DataSource = KhachHangService.KhachHang_Search(RemoveUnicode(txttenkh.Text));
           }
        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sua_pn == true)
            {
                bool kiemtra;
                PhieuNhap pn = new PhieuNhap();
                pn.MaNhanVien = txtmanv.Text;
                pn.MaNhaCungCap = cbbmanhacc.Text;
                pn.MaPN = txtmapn.Text;

                pn.NgayNhap = dtpkngaynhappn.Value.ToString("yyyy-MM-dd");
                kiemtra = PhieuNhapService.PhieuNhap_Update(pn);
                if (kiemtra == true)
                {
                    MessageBox.Show("Sửa thành công!!");
                }
                else
                {
                    MessageBox.Show("Bạn hay kiểm tra lại");
                }
                txtmapn.Enabled = true;
                sua_pn = false;
            }
            else
            {
                if (txtmapn.Text == ""||cbbmanhacc.Text=="")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!");
                    return;
                }
                else
                {
                    bool kiemtra;
                    PhieuNhap pn = new PhieuNhap();
                    pn.MaNhanVien = txtmanv.Text;
                    pn.MaNhaCungCap = cbbmanhacc.Text;
                    pn.MaPN = txtmapn.Text;

                    pn.NgayNhap = dtpkngaynhappn.Value.ToString("yyyy-MM-dd");
                    kiemtra = PhieuNhapService.PhieuNhap_Insert(pn);
                    if (kiemtra == true)
                    {
                        MessageBox.Show("Nhập thành công!!");
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập trùng khoá chính!!!");
                        return;
                    }
                  
                }
            }
            txtmapn.Text = "";
            cbbmanhacc.Text = "";
            txtmapx.Focus();
            dtpkngaynhappn.ResetText();
            HienThi_PhieuNhap();
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sua_pn = true;
            txtmapn.Enabled = false;
            //dataGridViewTextBoxColumn1
            txtmapn.Text = dtgrvphieunhap.CurrentRow.Cells["Column19"].Value.ToString();
            cbbmanhacc.Text = dtgrvphieunhap.CurrentRow.Cells["Column22"].Value.ToString();
            //  DateTime date = DateTime.ParseExact(kh_sua.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            // dtpkngaysinhKH.Value = date;
            DateTime date = DateTime.ParseExact(dtgrvphieunhap.CurrentRow.Cells["Column20"].Value.ToString(), "dd/MM/yyyy", null);
            dtpkngaynhappn.Value = date;
        }

        private void dtgrvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(them_nhaphang!=false)
            {
                txtpn.Text = dtgrvphieunhap.Rows[e.RowIndex].Cells["Column19"].Value.ToString();
            }
            dong_pn = e.RowIndex;
            mahdpx = dtgrvphieunhap.CurrentRow.Cells["Column19"].Value.ToString();
            dtgrvctpn.DataSource = ChiTietPhieuNhapService.ChiTietPhieuNhap_GetByTop("", " MaPN like '%" + mahdpx + "%'","");
          
        }

        private void cbbmaxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void HienThiMaXe(string maxe,string dongia)
        {
            cbbmaxe.Text= maxe;
            cbbmaxexh.Text = maxe;
            txtdongiaxh.Text = dongia;
            txtdongia.Text = dongia;
        }
        
        private void cbbmaxe_Click(object sender, EventArgs e)
        {

            frmTableXe tb = new frmTableXe();
            tb.send = new frmTableXe.Send_MaNhaCC(HienThiMaXe);
            
            
            tb.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            them_nhaphang = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
           
                
          
        }

        private void cbbmanhacc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         private void button21_Click(object sender, EventArgs e)
        {
           
            
        }
        private void button19_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            them_nhaphang = false;
            cbbmaxe.Enabled = false;
            txtpn.Text = dtgrvctpn.CurrentRow.Cells["Column23"].Value.ToString();
            cbbmaxe.Text = dtgrvctpn.CurrentRow.Cells["Column24"].Value.ToString();
            nmrudsoluong.Value = Int32.Parse(dtgrvctpn.CurrentRow.Cells["Column25"].Value.ToString());
            txtdongia.Text = dtgrvctpn.CurrentRow.Cells["Column26"].Value.ToString();
            txtthue.Text = dtgrvctpn.CurrentRow.Cells["Column27"].Value.ToString();
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xoá không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                ChiTietPhieuNhap ncc = new ChiTietPhieuNhap();
                ncc.MaPN = dtgrvctpn.CurrentRow.Cells["Column23"].Value.ToString();
                ncc.MaHang = dtgrvctpn.CurrentRow.Cells["Column24"].Value.ToString();
                ChiTietPhieuNhapService.ChiTietPhieuNhap_Delete(ncc);
                MessageBox.Show("Xoá thành công", "Thông báo");
                HienThi_ChiTietPhieuNhap();
                HienThi_PhieuNhap();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            bool kiemtra;
            if (nmrudsoluong.Value == 0 || txtpn.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!");
                return;
            }
            else
            {
                if (them_nhaphang == true)
                {
                    if (txtpn.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn phải chọn bảng  phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                        ctpn.MaPN = txtpn.Text;
                        ctpn.MaHang = cbbmaxe.Text;
                        ctpn.SLNhap = nmrudsoluong.Value.ToString();
                        ctpn.Thue = txtthue.Text;
                        ctpn.DonGiaNhap = txtdongia.Text;
                        kiemtra = ChiTietPhieuNhapService.ChiTietPhieuNhap_Insert(ctpn);
                        if (kiemtra == true)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            HienThi_ChiTietPhieuNhap();
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã nhập trùng khoá chính hoặc nhập chưa đầy đủ !!!", "Thông báo");
                        }

                    }
                }
                else
                {
                    ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                    ctpn.MaPN = txtpn.Text;
                    ctpn.MaHang = cbbmaxe.Text.Trim();
                    ctpn.SLNhap = nmrudsoluong.Value.ToString();
                    ctpn.Thue = txtthue.Text;
                    ctpn.DonGiaNhap = txtdongia.Text;
                    ChiTietPhieuNhapService.ChiTietPhieuNhap_Update(ctpn);
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    HienThi_ChiTietPhieuNhap();
                    btnthem.Enabled = true;
                    btnxoa.Enabled = true;

                }
            }
           
        }

        public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        
        }
        private void HienThiMaNCC(string maNCC)
        {
            cbbmanhacc.Text = maNCC;
        }
        
        private void cbbmanhacc_Click(object sender, EventArgs e)
        {
            TableNhaCC tb = new TableNhaCC();
            tb.send = new TableNhaCC.Send_MaNhaCC(HienThiMaNCC);
            tb.ShowDialog();
        }

        private void dtgrvphieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LamMoi_HoaDon()
        {
            txtmapx.Text = "";
            cbbmakhpx.Text = "";
            dtpkngayxuat.ResetText();
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            if (sua_nhaphanghd == true)
            {
                PhieuXuat pn = new PhieuXuat();
                pn.MaNhanVien = txtmanvpx.Text;
                pn.MaKhachHang = cbbmakhpx.Text;
                pn.MaPhieuXuat = txtmapx.Text;

                pn.NgayXuat = dtpkngayxuat.Value.ToString("yyyy-MM-dd");
                bool check = PhieuXuatService.PhieuXuat_Update(pn);
                if (check == false)
                {
                    MessageBox.Show("Lỗi: Bạn hãy kiểm tra lại ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sửa thành công!!!");
                }
                txtmapx.Enabled = true;
                sua_nhaphanghd = false;
            }
            else
            {
                if (txtmapx.Text == ""||cbbmakhpx.Text=="")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!", "Thông báo");
                    return;
                }
                else
                {
                    PhieuXuat pn = new PhieuXuat();
                    pn.MaNhanVien = txtmanvpx.Text;
                    pn.MaKhachHang = cbbmakhpx.Text;
                    pn.MaPhieuXuat = txtmapx.Text;

                    pn.NgayXuat = dtpkngayxuat.Value.ToString("yyyy-MM-dd");
                    bool check = PhieuXuatService.PhieuXuat_Insert(pn);
                    if (check == false)
                    {
                        MessageBox.Show("Lỗi: Bạn đã nhập trùng khoá chính ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!!!");
                    }


                }



            }
            LamMoi_HoaDon();
            HienThi_PhieuXuat();
         
        }
       
        private void HienThiMaKhachHang(string makh)
        {
            cbbmakhpx.Text = makh;
        }
        private void cbbmakhpx_Click(object sender, EventArgs e)
        {
            TableKhachHang tb = new TableKhachHang();
            tb.send = new TableKhachHang.Send_MaKH(HienThiMaKhachHang);
            tb.ShowDialog();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            sua_nhaphanghd = true;
            txtmapx.Enabled = false;
            //dataGridViewTextBoxColumn1
            txtmapx.Text = dtgrvphieuxuat.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            cbbmakhpx.Text = dtgrvphieuxuat.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
            //  DateTime date = DateTime.ParseExact(kh_sua.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
           // dtpkngaysinhKH.Value = date;
            DateTime date = DateTime.ParseExact(dtgrvphieuxuat.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString(), "dd/MM/yyyy", null);
            dtpkngayxuat.Value = date;
        }

        private void dtgrvphieuxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbbmaxexh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbbmaxexh_Click(object sender, EventArgs e)
        {



            frmTableXe tb = new frmTableXe();
            tb.send = new frmTableXe.Send_MaNhaCC(HienThiMaXe);
            
            tb.ShowDialog();
      

        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtpx.Text = dtgrvphieuxuat.Rows[dong_px].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            them_xuathang = true;
            btnsuaxh.Enabled = false;
            btnxoaxh.Enabled = false;
            btnthem.Enabled = false;
        }
        bool CheckSoLuong_Hang()
        {
           int SoLuong= MatHangService.Get_SoLuong(cbbmaxexh.Text);
           int ktra;
           ktra = SoLuong - Convert.ToInt32(nmrudsoluongxh.Value.ToString());
           if(ktra<=0)
           {
              
               return false;
           }
           return true;

        }
        private void btnluuxh_Click(object sender, EventArgs e)
        {
           
            if (cbbmaxexh.Text == ""||nmrudsoluongxh.Value==0)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!!!");
            }
            else
            {
                if (them_xuathang == true)
                {
                    if (CheckSoLuong_Hang() == false)
                    {
                        MessageBox.Show("Số lượng hàng ko đủ ");
                        return;
                    }
                    else if (txtpx.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn phải chọn bảng  phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        //txtpx.Text.Trim();
                        ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                        ctpx.MaPX = txtpx.Text;
                        ctpx.MaXe = cbbmaxexh.Text;


                        ctpx.SLXuat = nmrudsoluongxh.Value.ToString();
                        ctpx.Thue = txtthuexh.Text;
                        ctpx.DonGiaXuat = txtdongiaxh.Text;
                        bool ktra;
                        ktra = ChiTietPhieuXuatService.ChiTietPhieuXuat_Insert(ctpx);
                        if (ktra == true)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            HienThi_ChiTietPhieuXuat();
                            btnsuaxh.Enabled = true;
                            btnxoaxh.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã nhập trùng khoá chính", "Thông báo");
                        }

                    }
                }
                else
                {
                    if (CheckSoLuong_Hang() == false)
                    {
                        MessageBox.Show("Số lượng hàng ko đủ ");
                        return;
                    }
                    else
                    {
                        ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                        ctpx.MaPX = txtpx.Text;
                        ctpx.MaXe = cbbmaxexh.Text;

                        cbbmaxexh.Enabled = false;
                        ctpx.SLXuat = nmrudsoluongxh.Value.ToString();
                        ctpx.Thue = txtthuexh.Text;
                        ctpx.DonGiaXuat = txtdongiaxh.Text;
                        ChiTietPhieuXuatService.ChiTietPhieuXuat_Update(ctpx);
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        HienThi_ChiTietPhieuXuat();
                        btnthemxh.Enabled = true;
                        btnxoaxh.Enabled = true;
                    }


                }
            }
           
        }

        private void btnsuaxh_Click(object sender, EventArgs e)
        {
            btnxoaxh.Enabled = false;
            btnthemxh.Enabled = false;
            them_xuathang = false;
            cbbmaxexh.Enabled = false;
           txtpx.Text = dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
            cbbmaxexh.Text = dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            nmrudsoluongxh.Value = Int32.Parse(dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString());
            txtdongiaxh.Text = dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
            txtthuexh.Text = dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
        }

        private void btnxoaxh_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xoá không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat() ;
                ctpx.MaPX = dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                ctpx.MaXe = dtgrvchitietpx.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                ChiTietPhieuXuatService.ChiTietPhieuXuat_Delete(ctpx);
                MessageBox.Show("Xoá thành công", "Thông báo");
                HienThi_ChiTietPhieuXuat();
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            dtgrvNhanVien.DataSource = NhanVienService.NhanVien_Search(RemoveUnicode(txtsearchnv.Text));
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
           
                dtgrvKhachHang.DataSource = KhachHangService.KhachHang_Search(RemoveUnicode(txttenkh.Text));
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgrvNhaCC.DataSource = NhaCungCapService.NhaCungCap_Search(RemoveUnicode(txttenncc.Text));
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            dtgrvNhaCC.DataSource = NhaCungCapService.NhaCungCap_Search(RemoveUnicode(txttenncc.Text));
        }

        private void txttenxe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgrvxe.DataSource = MatHangService.MatHang_Search(RemoveUnicode(txttenxe.Text));
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            dtgrvxe.DataSource = MatHangService.MatHang_Search(RemoveUnicode(txttenxe.Text));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dtgrvchitietpx.DataSource = ChiTietPhieuXuatService.ChiTietPhieuXuat_GetByTop("", "", "");
            cbbmaxexh.Text = "";
            txtdongiaxh.Text = "";
            txtthuexh.Text = "";
            nmrudsoluongxh.ResetText();
            btnluuxh.Enabled = true;
            btnthemxh.Enabled = true;
            btnxoaxh.Enabled = true;
            btnsuaxh.Enabled = true;
            cbbmaxexh.Enabled = true;

        }
        HoaDonKH kh;
        private void button25_Click(object sender, EventArgs e)
        {
           
            if (kh==null||kh.IsDisposed)
            {
                kh = new HoaDonKH();
                //HoaDonKH.makh=dtgrvphieuxuat.CurrentCell.
                HoaDonKH.mahd = dtgrvphieuxuat.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                kh.Show();
            }
            else
            {
                kh.Activate();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            //dtgrvNhanVien.DataSource = NhanVienService.NhanVien_Search(RemoveUnicode(txtsearchnv.Text));
            dtgrvphieuxuat.DataSource = PhieuXuatService.PhieuXuat_Search(RemoveUnicode(txtmahdpx.Text));
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            txtmapx.Text = "";
            cbbmakhpx.Text = "";
            txtmapx.Focus();
            HienThi_PhieuXuat();
            txtmapx.Enabled = true;
            txtmapx.Select();

            sua_nhaphanghd = false;
         
        }

        private void txtmahdpx_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                dtgrvphieuxuat.DataSource = PhieuXuatService.PhieuXuat_Search(RemoveUnicode(txtmahdpx.Text));
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void nhậpHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void xuấtHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void xuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.XuatHang xh = new Report.XuatHang();
            xh.ShowDialog();
        }

        private void dtgrvphieuxuat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dong_px = e.RowIndex;
            if (them_xuathang != false)
            {
                txtpx.Text = dtgrvphieuxuat.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            }
            mahdpx = dtgrvphieuxuat.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            dtgrvchitietpx.DataSource = ChiTietPhieuXuatService.ChiTietPhieuXuat_Search("", "  MaPhieuXuat like '%" + mahdpx + "%'", "");
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.DoanhThu dt = new Report.DoanhThu();
            dt.ShowDialog();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            dtgrvphieunhap.DataSource = PhieuNhapService.PhieuNhap_GetByTop("", " MaPN like '%" + txtsearchmapn.Text + "%'", "");
        }

        private void txtsearchmapn_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void button29_Click(object sender, EventArgs e)
        {
            HienThi_PhieuNhap();

            txtmapn.Text = "";
            cbbmanhacc.Text = "";
            txtmapn.Enabled = true;
        }

        private void txtsearchmapn_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dtgrvphieunhap.DataSource = PhieuNhapService.PhieuNhap_GetByTop("", " MaPN like '%" + txtsearchmapn.Text + "%'", "");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            dtgrvctpn.DataSource = ChiTietPhieuXuatService.ChiTietPhieuXuat_GetByTop("", "", "");
            cbbmaxe.Enabled = true;
            txtpn.Focus();
            txtdongia.Text = "";
            txtthue.Text = "";
            nmrudsoluong.Value = 0;
            cbbmaxe.Text = "";
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void dtgrvphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void tồnKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.TonKho tonkho = new Report.TonKho();
            tonkho.ShowDialog();
        }
    }
}
