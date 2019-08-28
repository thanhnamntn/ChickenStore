using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickStore.QuanLyChung
{
    public partial class frmTrungTamQuanLy : Form
    {
        public frmTrungTamQuanLy()
        {
            InitializeComponent();
        }

        private void bntTiepNhanNV_Click(object sender, EventArgs e)
        {
            NhanVien.frmTiepNhanNhanVien frm = new NhanVien.frmTiepNhanNhanVien();
            frm.Show();
        }

        private void bntTraCuuNV_Click(object sender, EventArgs e)
        {

            NhanVien.frmTraCuuNhanVien frm = new NhanVien.frmTraCuuNhanVien();
            frm.Show();
        }

        private void bntTKCCa_Click(object sender, EventArgs e)
        {
            DoanhThu.frmQuanLyThuChiCuoiCa frm = new DoanhThu.frmQuanLyThuChiCuoiCa();
            frm.Show();
        }

        private void bntTKCThang_Click(object sender, EventArgs e)
        {
            DoanhThu.frmQuanLyThuChiCuoiThang frm = new DoanhThu.frmQuanLyThuChiCuoiThang();
            frm.Show();
        }

        private void bntChamCong_Click(object sender, EventArgs e)
        {
            CongVaLuong.frmChamCong frm = new CongVaLuong.frmChamCong();
            frm.Show();
        }

        private void bntTinhLuong_Click(object sender, EventArgs e)
        {
            CongVaLuong.frmTinhLuong frm = new CongVaLuong.frmTinhLuong();
            frm.Show();
        }

        private void bntQLNhapWG_Click(object sender, EventArgs e)
        {
            KhoWetGoods.frmQuanLyWetGoods frm = new KhoWetGoods.frmQuanLyWetGoods();
            frm.Show();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
