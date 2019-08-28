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
    public partial class frmXuatWetGoods : Form
    {
        private DBKhoWetGoods db = new DBKhoWetGoods();
        private DataSet ds = new DataSet();
        public frmXuatWetGoods()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaHangValue = cboMaHang.SelectedItem.ToString();
            int MaHangIndex = cboMaHang.SelectedIndex;

            cboTenHang.SelectedIndex = MaHangIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenHangValue = cboTenHang.SelectedItem.ToString();
            int TenHangIndex = cboTenHang.SelectedIndex;

            cboMaHang.SelectedIndex = TenHangIndex;
        }

        private void bntChonHang_Click(object sender, EventArgs e)
        {
            grpNhapHang.Enabled = true;
            txtMaHang.Text = cboMaHang.SelectedItem.ToString();
            txtTenHang.Text = cboTenHang.SelectedItem.ToString();
            string MH = txtMaHang.Text;
           ds = db.thongtinXuatKho(MH);
           try
           {
               txtKhoCon.Text = ds.Tables[0].Rows[0]["KhoWetGoods"].ToString();
               DateTime dt = DateTime.Parse(ds.Tables[0].Rows[0]["NgayHetHan"].ToString()).Date;
               txtHSD.Text = dt.ToString("dd/MM/yyyy");

           

           }
           catch (Exception)
           {
               MessageBox.Show("Mã Hàng wasn't found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
         
        }

        private void bntNhapHang_Click(object sender, EventArgs e)
        {
            if (numSLXuat.Value > int.Parse(txtKhoCon.Text))
            {
                MessageBox.Show("The stogare isn't enought !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = "";
                string MaXuat = db.TaoMa_XuatHang("XW", 5);
                DateTime NgayXuat = DateTime.Parse(dtpNgayXuat.Text);
                int SLXuat = int.Parse(numSLXuat.Value.ToString());
                if (!db.UpdateNhap_XuatWetGoods(ref err, txtMaHang.Text, MaXuat, NgayXuat, SLXuat))
                {
                    MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHang.Text = "";
                    txtTenHang.Text = "";
                    numSLXuat.Value = 0;
                    txtKhoCon.Text = "";
                }
            }
        }

        private void frmXuatWetGoods_Load(object sender, EventArgs e)
        {
            grpNhapHang.Enabled = false;

        }

       
    }
}
