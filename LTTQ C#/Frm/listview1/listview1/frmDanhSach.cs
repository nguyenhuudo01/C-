using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview1
{
    public partial class frmDanhSach : Form
    {
        ListViewItem itemLV;
        int vt = -1;
        public frmDanhSach()
        {
            InitializeComponent();
        }

        private void frmDanhSach_Load(object sender, EventArgs e)
        {
            TaoDSMacDinh();
        }
        void TaoDSMacDinh()
        {
            lvwDanhSach.Items.Clear();
            itemLV = new ListViewItem(new[] { "1", "Nguyễn Văn A", "01/01/2002", "HT21", "0123", "Hà Nội" });
            lvwDanhSach.Items.Add(itemLV);
            itemLV = new ListViewItem(new[] { "2", "Nguyễn Văn B", "01/01/2003", "HT22", "01234", "Quảng Bình" });
            lvwDanhSach.Items.Add(itemLV);
            itemLV = new ListViewItem(new[] { "3", "Nguyễn Văn C", "01/01/2004", "HT23", "01235", "Nghệ An" });
            lvwDanhSach.Items.Add(itemLV);
            itemLV = new ListViewItem(new[] { "4", "Nguyễn Văn D", "01/01/2005", "HT24", "01236", "Thanh Hóa" });
            lvwDanhSach.Items.Add(itemLV);
            itemLV = new ListViewItem(new[] { "5", "Nguyễn Văn E", "01/01/2006", "HT25", "01237", "Nam Định" });
            lvwDanhSach.Items.Add(itemLV);
            itemLV = new ListViewItem(new[] { "6", "Nguyễn Văn G", "01/01/2007", "HT26", "01238", "Bắc Ninnh" });
            lvwDanhSach.Items.Add(itemLV);

        }

        private void lvwDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhSach.Items.Count <= 0) return; //nếu DS rỗng thì không làm gì
            if (lvwDanhSach.SelectedItems.Count <= 0) return; //nếu chưa chọn item nào thì cũng không làm gì
            itemLV = lvwDanhSach.SelectedItems[0];
            // lấy thông tin từ dòng đang chọn : vị trí, text (colum1), subitemtext (colum...)
            vt = itemLV.Index;
            txtMaSinhVien.Text = itemLV.Text;
            txtHoVaTen.Text = itemLV.SubItems[1].Text;
            txtNgaySinh.Text = itemLV.SubItems[2].Text;
            txtLop.Text = itemLV.SubItems[3].Text;
            txtDienThoai.Text = itemLV.SubItems[4].Text;
            txtDiaChi.Text = itemLV.SubItems[5].Text;
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if(txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSinhVien.Focus();
                return;
            }
            itemLV = new ListViewItem(new[] { txtMaSinhVien.Text, txtHoVaTen.Text, txtNgaySinh.Text,
                                                txtLop.Text, txtDienThoai.Text, txtDiaChi.Text });
            lvwDanhSach.Items.Add(itemLV);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;

        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            if (lvwDanhSach.Items.Count <= 0) return;
            if (vt < 0) return;
            if(txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSinhVien.Focus();
                return;
            }
            if(MessageBox.Show("Bạn có muốn cập nhật sinh viên "+ lvwDanhSach.Items[vt].SubItems[1].Text+" không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvwDanhSach.Items[vt].Text = txtMaSinhVien.Text;
                lvwDanhSach.Items[vt].SubItems[1].Text = txtHoVaTen.Text;
                lvwDanhSach.Items[vt].SubItems[2].Text = txtNgaySinh.Text;
                lvwDanhSach.Items[vt].SubItems[3].Text = txtLop.Text;
                lvwDanhSach.Items[vt].SubItems[4].Text = txtDienThoai.Text;
                lvwDanhSach.Items[vt].SubItems[5].Text = txtDiaChi.Text;
            }
        }

        private void cmdXoaBo_Click(object sender, EventArgs e)
        {
            if (lvwDanhSach.Items.Count <= 0) return;
            if (vt < 0) return;
            if(MessageBox.Show("Bạn có muôn xóa sinh viên "+ lvwDanhSach.Items[vt].SubItems[1].Text+"không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvwDanhSach.Items.RemoveAt(vt);
                vt = -1;
                cmdXoaBo_Click(sender, e);
            }
        }

        private void cmdXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = "";txtHoVaTen.Text = "";txtNgaySinh.Text = "";txtLop.Text = "";txtDienThoai.Text = "";

            txtDiaChi.Text = "";

        }

        private void frmDanhSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn kết thúc không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
