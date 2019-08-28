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

namespace ChickStore.DoanhThu
{
    public partial class frmQuanLyThuChiCuoiCa : Form
    {
        DBDoanhThu db = new DBDoanhThu();
        private DataSet ds = new DataSet();
        public frmQuanLyThuChiCuoiCa()
        {
            InitializeComponent();
        }
        private void showTable()
        {
            ds = db.getThuChiCuoiCa("");
            dgvBangThuChiCuoiCa.DataSource = ds.Tables[0];

        }
        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyThuChiCuoiCa_Load(object sender, EventArgs e)
        {

           
            showTable();
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

            ds = db.getThuChiCuoiCa(dtpNgayNhap.Value.ToString("yyyy-MM-dd"));
            dgvBangThuChiCuoiCa.DataSource = ds.Tables[0];
        }
    }
}
