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

namespace ChickStore.CongVaLuong
{
    public partial class frmTinhLuong : Form
    {
        private DBTinhLuong db = new DBTinhLuong();
        private DataSet ds = new DataSet();


        private static float LCB = 14500;
        private static float PC = 3500;
   
        public frmTinhLuong()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBangTinhLuong()
        {
            ds = db.getTinhLuong();
            DateTime timeCreateSalary = DateTime.Now;

            dgvBangChamCong.DataSource = ds.Tables[0];
            //DataTable dt = ds.Tables[0];
        
           
         
          lblThangChamCong.Text = lblThangChamCong.Text + timeCreateSalary.ToString("MM")+"/"+  timeCreateSalary.Year.ToString();
     
        }

        private void frmTinhLuong_Load(object sender, EventArgs e)
        {
            showBangTinhLuong();

        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (dgvBangChamCong.Rows.Count > 0)
            {
                if (dgvBangChamCong.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Please,Choose a User", "Thông Báo");
                    return;

                }
                else
                {
                    lblTenNV.Text = dgvBangChamCong.CurrentRow.Cells["TenNV"].Value.ToString();

                    int NgayCongThuong =Int32.Parse(dgvBangChamCong.CurrentRow.Cells["NgayCongThuong"].Value.ToString());
                    int NgayCongLe = Int32.Parse(dgvBangChamCong.CurrentRow.Cells["NgayCongLe"].Value.ToString());
                    float TienLuong = (LCB + PC) *8* NgayCongThuong + (LCB * 3 + PC) *8* NgayCongLe;
                    lblTienLuong.Text = TienLuong.ToString() +"đ";
                }
            }
        }
        
    }
}
