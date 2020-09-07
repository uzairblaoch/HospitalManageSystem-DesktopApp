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
       
        registration r = new registration();
        information i = new information();
        checkout ch = new checkout();


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
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ch.Hide();
            i.Hide();
            panel2.Controls.Add(r);
            r.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ch.Hide();
            r.Hide();
            panel2.Controls.Add(i);
            i.Show();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
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

      
       
    }
}
