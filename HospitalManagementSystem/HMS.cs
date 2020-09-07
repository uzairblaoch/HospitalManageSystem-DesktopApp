using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HospitalManagementSystem
{
    public partial class mainform : Form
    {
        Appointment ap = new Appointment();
        PatientRegistration r = new PatientRegistration();
        RoomInformation i = new RoomInformation();
        checkout ch = new checkout();
        Wellcome wc = new Wellcome();
        MedicineInfo mi = new MedicineInfo();
        DoctorInformation di = new DoctorInformation();
        PatientInformation pi = new PatientInformation();


        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }


        /// <summary>
        /// /////////Drage Window through Panel//////////

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /// ////////////////////
        /// </summary>


        public mainform()
        {
            
            InitializeComponent();
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (slidepanel.Width == 44)
            {
                slidepanel.Visible = false;
                slidepanel.Width = 240;
                panelanimator.ShowSync(slidepanel);
                logoanimator.ShowSync(logo);
            }
            else
            {
                logoanimator.Hide(logo);
                slidepanel.Visible = false;
                slidepanel.Width = 44;
                panelanimator.ShowSync(slidepanel);
            }
        }

       

        private void mainform_Load(object sender, EventArgs e)
        {
            // WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);
            panel2.Controls.Add(wc);
            wc.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pi.Hide();
            di.Hide();
            mi.Hide();
            ap.Hide();
            wc.Hide();
            ch.Hide();
            i.Hide();
            panel2.Controls.Add(r);
            r.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            di.Hide();
            mi.Hide();
            ap.Hide();
            wc.Hide();
            r.Hide();
            i.Hide();
            ch.Hide();
            panel2.Controls.Add(pi);
            pi.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            pi.Hide();
            di.Hide();
            mi.Hide();
            ap.Hide();
            wc.Hide();
            r.Hide();
            i.Hide();
            panel2.Controls.Add(ch);
            ch.Show();
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {
            pi.Hide();
            ch.Hide();
            di.Hide();
            mi.Hide();
            wc.Hide();
            r.Hide();
            i.Hide();
            panel2.Controls.Add(ap);
            ap.Show();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pi.Hide();
            di.Hide();
            mi.Hide();
            ap.Hide();
            wc.Hide();
            ch.Hide();
            r.Hide();
            panel2.Controls.Add(i);
            i.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            pi.Hide();
            i.Hide();
            di.Hide();
            ap.Hide();
            wc.Hide();
            ch.Hide();
            r.Hide();
            panel2.Controls.Add(mi);
            mi.Show();
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            pi.Hide();
            i.Hide();
            mi.Hide();
            ap.Hide();
            wc.Hide();
            ch.Hide();
            r.Hide();
            panel2.Controls.Add(di);
            di.Show();
        }
    }
}
