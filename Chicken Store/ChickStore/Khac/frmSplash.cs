using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickStore.Khac
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            // Hiệu ứng Fade in
            this.Opacity = 0;
            this.Show();
            for (float f = 0.0F; f < 1F; f = f + 0.04F)
            {
                this.Opacity = f;
                Thread.Sleep(10);
            }
            this.Opacity = 1;
        }

        private void prgTimer_Tick(object sender, EventArgs e)
        {
            // Loading (nhưng chưa thực tế)
            prgLoad.Visible = false;
            prgLoad.Increment(32);//32
            if (prgLoad.Value == 96)
            {
                // CHạy nhạc Intro
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.splashSND);
                simpleSound.PlaySync();
                tmrPrg.Stop();
                // Hiệu ứng Fade out
                for (float f = 0.0F; f < 1F; f = f + 0.03F)
                {
                    this.Opacity = 1 - f;
                    Thread.Sleep(10);
                }
                this.Opacity = 0;
                // Đóng Splash, hiện form đăng nhập
                var frm = new PhanAn.frmDangNhapNhanVien();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
        }
    }
}
