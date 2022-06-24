using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class frmTienDien : Form
    {
        public frmTienDien()
        {
            InitializeComponent();
        }

        private void cmd_TinhTienDien_Click(object sender, EventArgs e)
        {
            int csc, csm; 
            csc = Int32.Parse(txtCsc.Text);
            csm = Int32.Parse(txtCsm.Text);
            txtSoDienTieuThu.Text = (csm - csc).ToString();
        }
    }
}
