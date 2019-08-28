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

namespace ChickStore.KhoWetGoods
{
    public partial class frmQuanLyWetGoods : Form
    {
        DBKhoWetGoods db = new DBKhoWetGoods();
        DataSet ds = new DataSet();
        public frmQuanLyWetGoods()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntNhapWG_Click(object sender, EventArgs e)
        {
            frmNhapWetGoods frmNhapW = new frmNhapWetGoods();
            frmNhapW.Show();
            this.Hide();
        }

        private void bntXuatWG_Click(object sender, EventArgs e)
        {
            frmXuatWetGoods frmXuatW = new frmXuatWetGoods();
            frmXuatW.Show();
            this.Hide();
        }

        private void frmQuanLyWetGoods_Load(object sender, EventArgs e)
        {
            ds = db.QLKho("");
            dgvKhoWG.DataSource = ds.Tables[0];

        }
    }
}
