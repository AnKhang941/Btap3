
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Btap3
{
    public partial class frmNhanVien : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void lblBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
