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
using System.Globalization;

namespace ChickStore.CongVaLuong
{
    public partial class frmChamCong : Form
    {
        private DBChamCong db = new DBChamCong();
        private DataSet ds = new DataSet();
        private DataSet ds1 = new DataSet();
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBangChamCong()
        {
            ds = db.getChamCong("");
          
            dgvBangChamCong.DataSource = ds.Tables[0];
        
            DataTable dt = ds.Tables[0];
        
            lblThangChamCong.Text = lblThangChamCong.Text + DateTime.Now.ToString("MM") + "/" + DateTime.Now.Year.ToString();
          for (int i = 0; i < dt.Rows.Count; i++)
          {
             string sMSNV = dgvBangChamCong.Rows[i].Cells["MSNV"].Value.ToString();
             string sNgayThangLamViec = dgvBangChamCong.Rows[i].Cells["NgayThangLamViec"].Value.ToString();
             DateTime NgayThangLamViec = DateTime.Parse(sNgayThangLamViec).Date;
          }
      //   ds1 = db.tongGioCong("");
        // dgvTongGioCong.DataSource = ds1.Tables[0];
          
        }

        private void tongGioCong()
        {
            ds1 = db.tongGioCong("");
            dgvTongGioCong.DataSource = ds1.Tables[0];

        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            showBangChamCong();
            tongGioCong();
        }
    }
}
