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
    public partial class frmNhapWetGoods : Form
    {
        private DBKhoWetGoods db = new DBKhoWetGoods();
        private DataSet ds = new DataSet();
        public frmNhapWetGoods()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            frmQuanLyWetGoods frmQLWetGoods = new frmQuanLyWetGoods();
            frmQLWetGoods.Show();
            this.Close();
        }
        private void show()
        {
            ds = db.getMatHang("");
            cboMaHang.DataSource = ds.Tables[0];
            cboMaHang.ValueMember = "MaHang";
            cboMaHang.DisplayMember = "MaHang";

            cboTenHang.DataSource = ds.Tables[0];
            cboTenHang.ValueMember = "MaHang";
            cboTenHang.DisplayMember = "TenHang";

        }

        private void bntChonHang_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = cboMaHang.SelectedItem.ToString();
            txtTenHang.Text = cboTenHang.SelectedItem.ToString();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaHangValue = cboMaHang.SelectedItem.ToString();
            int MaHangIndex = cboMaHang.SelectedIndex;

            cboTenHang.SelectedIndex = MaHangIndex;
        }

        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenHangValue = cboTenHang.SelectedItem.ToString();
            int TenHangIndex = cboTenHang.SelectedIndex;

            cboMaHang.SelectedIndex = TenHangIndex;
        }

        private void bntNhapHang_Click(object sender, EventArgs e)
        {
            DateTime NgayNhap = Convert.ToDateTime(dtpNgayNhap.Text);
            DateTime HSD = Convert.ToDateTime(dtpHSD.Text);

            if (txtMaHang.Text == "" || txtMaHang.Text == null || txtTenHang.Text == "" || txtTenHang.Text == null)
            {
                MessageBox.Show("Please choose Tên Hàng or Mã Hàng.Thank you!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSLGiao.Value == 0 || numThucNhan.Value == 0)
            {
                MessageBox.Show("Please inrease SLGiao or Thực Nhận.Thank you!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NgayNhap >= HSD)
            {
                MessageBox.Show("Expired products.Thank you!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int SL = int.Parse(numSLGiao.Value.ToString());
                int ThucNhan = int.Parse(numThucNhan.Value.ToString());
                string err = "";
                string MaNhap = db.TaoMa_NhapHang("NW", 5);

               

                    if (!db.insertNhapKhoWetGoods(ref err, MaNhap, txtMaHang.Text, NgayNhap, SL, ThucNhan, HSD))
                    {
                        MessageBox.Show(err);
                    }
                    else
                    {
                        MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaHang.Text = "";
                        txtTenHang.Text = "";
                        numSLGiao.Value = 0;
                        numThucNhan.Value = 0;
                    }
                
           


            }
        }
    }
}
