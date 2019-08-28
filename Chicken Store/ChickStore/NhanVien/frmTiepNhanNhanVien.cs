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
using System.Data;

namespace ChickStore.NhanVien
{
    public partial class frmTiepNhanNhanVien : Form
    {
        DBNhanVien db = new DBNhanVien();
        public frmTiepNhanNhanVien()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTiepNhanNhanVien_Load(object sender, EventArgs e)
        {
            
         
        }

        private void bntTiepNhan_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "" || txtQueQuan.Text == "")
            {
                MessageBox.Show("Please, sigh enough.Thank you!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpNgaySinhNV.Value > DateTime.Now)
            {

                MessageBox.Show("Please, Check your birthday again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string err = "";
                string MSNV = db.TaoMa_NhanVien("NV", 5);
            //    string GT = cboGioiTinhNV.SelectedItem.ToString();
                string BP = cboBoPhan.SelectedItem.ToString();
              
                string MaBoPhan=db.getMaBoPhan(BP).Tables[0].Rows[0]["MaBoPhan"].ToString();
                if (!db.insertNhanVien(ref err, MSNV,txtTenNV.Text,dtpNgaySinhNV.Value,cboGioiTinhNV.SelectedItem.ToString(),txtQueQuan.Text,MaBoPhan,dtpNgayTiepNhanNV.Value))
                {
                    MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }

        private void bntNhapLai_Click(object sender, EventArgs e)
        {
            txtQueQuan.Text = "";
            txtTenNV.Text = "";

        }
    }
}
