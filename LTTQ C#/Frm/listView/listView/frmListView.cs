using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listView
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNhap_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if(ktratrung() == true)
            {
              if(MessageBox.Show("Bạn nhập họ tên đã tồn tại. Bạn có tiếp tục nhập vào không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    txtName.Focus();
                    return;
                }
            }
            lstA.Items.Add(txtName.Text);
            kiemtraEnable();
        }
        bool ktratrung()
        {
            for (int i = 0; i < lstA.Items.Count; i++)
                if (lstA.Items[i].ToString().Equals(txtName.Text) == true)
                    return true;
            return false;
        }
        void kiemtraEnable()
        {
            if(lstA.Items.Count <= 0)
            {
                cmdA1B.Enabled = false;
                cmdAB.Enabled = false;
            }
            else
            {
                cmdA1B.Enabled = true;
                cmdAB.Enabled = true;
            }
            if (lstB.Items.Count <= 0)
            {
                cmdB1A.Enabled = false;
                cmdBA.Enabled = false;
            }
            else
            {
                cmdB1A.Enabled = true;
                cmdBA.Enabled = true;
            }
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            kiemtraEnable();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa trắng lớp A không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstA.Items.Clear();
                kiemtraEnable();
            }
        }

        private void cmdA1B_Click(object sender, EventArgs e)
        {
            lstB.Items.Clear();
           lstB.Items.Add(lstA.SelectedItem.ToString());
            kiemtraEnable();
        }

        private void cmdB1A_Click(object sender, EventArgs e)
        {
            lstA.Items.Clear();
            lstA.Items.Add(lstA.SelectedItem.ToString());
            kiemtraEnable();
        }

        private void cmdAB_Click(object sender, EventArgs e)
        {
            //lstB.Items.Clear();
        }
    }
}
