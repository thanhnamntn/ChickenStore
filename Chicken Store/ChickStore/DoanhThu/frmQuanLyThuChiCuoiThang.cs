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
    public partial class frmQuanLyThuChiCuoiThang : Form
    {
        DBDoanhThu db = new DBDoanhThu();
        
        public frmQuanLyThuChiCuoiThang()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTongDoanhThu.Text = "";
            int nextMonth = Int32.Parse(cboThang.SelectedItem.ToString()) + 1;
            string CuoiThang = cboNam.SelectedItem.ToString()+ "-" + nextMonth+"-1"  ;
            string DauThang = cboNam.SelectedItem.ToString() + "-" + cboThang.SelectedItem.ToString() + "-1";
            dgvBangThuChiCuoiThang.DataSource = db.getDoanhThuThang(CuoiThang, DauThang).Tables[0];

            if(!db.checkExist(cboThang.SelectedItem.ToString(),cboNam.SelectedItem.ToString())){
                if (dgvBangThuChiCuoiThang.Rows.Count >1)
                {

                    string err = "";
                    string MSBaoCaoThang = db.TaoMa_DoanhThuThang("DTT", 5);
                    int Nam = Int32.Parse(cboNam.SelectedItem.ToString());
                    int Thang = Int32.Parse(cboThang.SelectedItem.ToString());
                    //string ss = db.getTongDoanhThuThang(CuoiThang, DauThang).Tables[0].Rows[0]["TongDT"].ToString();
                    Double total = Double.Parse(db.getTongDoanhThuThang(CuoiThang, DauThang).Tables[0].Rows[0]["TongDT"].ToString());
                    float t = 0;
                    if (!db.insertDoanhThuThang(ref err, MSBaoCaoThang, Nam, Thang, t))
                    {
                        MessageBox.Show(err);
                    }
                    else
                    {
                        lblTongDoanhThu.Text = db.getTongDoanhThuThang(CuoiThang, DauThang).Tables[0].Rows[0]["TongDT"].ToString();

                    }
                }
                else
                {
                    return;
                }

            }
            else{

                lblTongDoanhThu.Text = db.getTongDoanhThuThang(CuoiThang, DauThang).Tables[0].Rows[0]["TongDT"].ToString();
            }
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {

        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
