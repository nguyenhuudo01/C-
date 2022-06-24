using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            cboDanhSach.Items.Add(txtHoTen.Text);
        }

        private void cboDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCount.Text = cboDanhSach.Items.Count.ToString();
            lblIndex.Text = cboDanhSach.SelectedIndex.ToString();
            lblItem.Text = cboDanhSach.SelectedItem.ToString();
            lblText.Text = cboDanhSach.Text;
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa đối tượng "+ cboDanhSach.SelectedItem.ToString()+" Không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cboDanhSach.Items.Remove(cboDanhSach.SelectedItem);
                xoatrang();
            }
        }
        void xoatrang()
        {
            lblCount.Text = "";
            lblIndex.Text = "";
            lblItem.Text = "";
            lblText.Text = "";
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa toàn bộ danh sách không ", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cboDanhSach.Items.Clear();
                xoatrang();
            }
        }
    }
}
