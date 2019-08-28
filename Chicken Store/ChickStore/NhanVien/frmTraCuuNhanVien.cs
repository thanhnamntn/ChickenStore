using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessAccessLayer;

namespace ChickStore.NhanVien
{
    public partial class frmTraCuuNhanVien : Form
    {
        DBNhanVien db = new DBNhanVien();
        public frmTraCuuNhanVien()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showNhanVien(string searchText)
        {
            dgvNhanVien.DataSource = db.getNhanVien(searchText).Tables[0];
            for (int i = 0; i < dgvNhanVien.RowCount; i++)
            {
                string MBP = dgvNhanVien.Rows[i].Cells["BoPhan"].Value.ToString();
                string TenBoPhan = db.getTenBoPhan(MBP).Tables[0].Rows[0]["TenBoPhan"].ToString();
                dgvNhanVien.Rows[i].Cells["BoPhan"].Value = TenBoPhan;

            }
        }

        private void frmTraCuuNhanVien_Load(object sender, EventArgs e)
        {
            showNhanVien("");
        }

        private void txtMSNV_TextChanged(object sender, EventArgs e)
        {
            showNhanVien(" Where MSNV LIKE '%"+txtMSNV.Text+"%' ");
							
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            showNhanVien(" Where HoTenNV LIKE '%" + txtTenNV.Text + "%'");
        }
    }
}
