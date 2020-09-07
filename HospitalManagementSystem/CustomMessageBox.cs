using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string _message)
        {
            InitializeComponent();
            customdialoglbl.Text = _message;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void BunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }

        private void Icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
            btnok.Visible = true;
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void ShowDialog(string message)
        {

            CustomMessageBox cmd = new CustomMessageBox(message);
            cmd.ShowDialog();
        }
    }
}
