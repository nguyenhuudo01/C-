using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ListViewFile
{
    public partial class frmQLSV : Form
    {
        ListViewItem itmelv;
        List<HoSo> arr = new List<HoSo>();
        HoSo hs;
        ListViewItem itemLV;
        String data;
        int i, vt = -1;
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            if (File.Exists("CSDL.txt") == false)
                TaoDLMacDinh();
            DocTapTin();
            HienThiListview();
          }
        void TaoDLMacDinh()
        {
            arr = new List<HoSo>();

            hs = new HoSo();
            hs.masv = "SV01"; hs.hoten = "Nguyễn Hữu Đô";
            hs.ngaysinh = "12/12/2002"; hs.lop = "HT21";
            hs.dienthoai = "0927156613"; hs.diachi = "Hà Nội";
            arr.Add(hs);
            
            hs = new HoSo();
            hs.masv = "SV02"; hs.hoten = "Vũ Trung Kiên";
            hs.ngaysinh = "19/02/2002"; hs.lop = "HT21";
            hs.dienthoai = "098776657"; hs.diachi = "Hà Nội";
            arr.Add(hs);

            GhiTapTin();

        }
        public void DocTapTin()
        {
            arr = new List<HoSo>();
            StreamReader fR = new StreamReader("CSDL.txt");
            while((data = fR.ReadLine()) != null)
            {
                hs = new HoSo();
                hs.masv = data;
                data = fR.ReadLine(); hs.hoten = data;
                data = fR.ReadLine(); hs.ngaysinh = data;
                data = fR.ReadLine(); hs.lop = data;
                data = fR.ReadLine(); hs.dienthoai = data;
                data = fR.ReadLine(); hs.diachi = data;
                arr.Add(hs);
            }
            fR.Close();
        }
        public void GhiTapTin()
        {
            StreamWriter fW = new StreamWriter("CSDL.txt");
            for(i = 0; i< arr.Count; i++)
            {
                fW.WriteLine(arr[i].masv); fW.WriteLine(arr[i].hoten);
                fW.WriteLine(arr[i].ngaysinh); fW.WriteLine(arr[i].lop);
                fW.WriteLine(arr[i].dienthoai); fW.WriteLine(arr[i].diachi);
            }
            fW.Close();
        }

        public void HienThiListview()
        {
            lvwDanhSach.Items.Clear();
            for (i = 0; i < arr.Count; i++)
            {
                itemLV = new ListViewItem(new[]{ arr[i].masv, arr[i].hoten,
                arr[i].ngaysinh,arr[i].lop,arr[i].dienthoai,arr[i].diachi});
                lvwDanhSach.Items.Add(itemLV);
            }
        }

        private void lvwDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhSach.Items.Count <= 0) return;
               if (lvwDanhSach.SelectedItems.Count<= 0) return;
            itemLV = lvwDanhSach.SelectedItems[0];
            vt = itemLV.Index;
            txtMaSinhVien.Text = itemLV.Text;
            txtHoVaTen.Text = itemLV.SubItems[1].Text;
            txtNgaySinh.Text = itemLV.SubItems[2].Text;
            txtLop.Text = itemLV.SubItems[3].Text;
            txtDienThoai.Text = itemLV.SubItems[4].Text;
            txtDiaChi.Text = itemLV.SubItems[5].Text;
        }

        private void cmdXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = "";
            txtHoVaTen.Text = "";
            txtNgaySinh.Text = "";
            txtLop.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }
        public bool ktTrungMa(bool ktThem)
        {
            for (i = 0; i < arr.Count; i++)
                if (arr[i].masv.Equals(txtMaSinhVien.Text) == true)
                    if (ktThem == true)
                        return true;
                    else
                           if (i != vt)
                        return true;
            return false;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSinhVien.Focus();
                return;
            }
            if (txtHoVaTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return;
            }
            if(ktTrungMa(true) == true)
            {
                MessageBox.Show("Bạn nhập mã sinh viên đã tồn tại trong CSDL", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSinhVien.Focus();
                return;
            }
            if(MessageBox.Show("Bạn có muốn thêm sinh viên không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                hs = new HoSo();
                hs.masv = txtMaSinhVien.Text;
                hs.hoten = txtHoVaTen.Text;
                hs.ngaysinh =txtNgaySinh.Text;
                hs.lop = txtLop.Text;
                hs.dienthoai = txtDienThoai.Text;
                hs.diachi = txtDiaChi.Text;
                arr.Add(hs);

                GhiTapTin();
                HienThiListview();
            }
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            if (lvwDanhSach.Items.Count <= 0) return;
            if (vt < 0) return;
            if (txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSinhVien.Focus();
                return;
            }
            if (txtHoVaTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return;
            }
            if (ktTrungMa(false) == true)
            {
                MessageBox.Show("Bạn nhập mã sinh viên đã tồn tại trong CSDL", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSinhVien.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn cập nhật sinh viên "+ arr[vt].hoten +"không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hs = new HoSo();
                hs.masv = txtMaSinhVien.Text;
                hs.hoten = txtHoVaTen.Text;
                hs.ngaysinh = txtNgaySinh.Text;
                hs.lop = txtLop.Text;
                hs.dienthoai = txtDienThoai.Text;
                hs.diachi = txtDiaChi.Text;
                arr[vt] = hs;

                GhiTapTin();
                HienThiListview();
            }
        }

        private void cmdXoaBo_Click(object sender, EventArgs e)
        {
            if (lvwDanhSach.Items.Count <= 0) return;
            if (vt < 0) return;
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class HoSo
        {
            public string masv, hoten, ngaysinh, lop, dienthoai, diachi;
        }
    }
}
