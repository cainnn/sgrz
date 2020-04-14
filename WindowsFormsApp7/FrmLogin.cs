using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Qios.DevSuite.Components;

namespace WindowsFormsApp7
{
    public partial class FrmLogin : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            QGlobalColorScheme.Global.CurrentTheme = "LunaBlue";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            showBg_img();
        }

        private void showBg_img()
        {
            string img_no = "01";
            Random ran = new Random();
            int bg_index = ran.Next(1, 60);
            if (bg_index < 10)
            {
                img_no = "0" + bg_index.ToString();
            }
            else
            {
                img_no = bg_index.ToString();
            }

            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\bg_img\" + img_no + ".jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonSpecAnyUsr_Click(object sender, EventArgs e)
        {
            krytxtUsr.Text = string.Empty;
        }

        private void buttonSpecAnyPwd_Click(object sender, EventArgs e)
        {
            krytxtPwd.Text = string.Empty;
        }

        private void krybtnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting setting = new FrmSetting();
            setting.ShowDialog();
        }
    }
}