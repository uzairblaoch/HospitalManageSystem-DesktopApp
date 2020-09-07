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
    public partial class login : Form
    {
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
        public login()
        {
            InitializeComponent();
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "admin")
            {
                this.Hide();
                mainform m = new mainform();
               
             
                m.ShowDialog();
                //this.Dispose();

                //Environment.Exit(1);
                //this.Hide();
            }
            if (txtuser.Text == "admin" && txtpass.Text != "admin")
            {
                 lbl2.Text = "* invalid password";
            }
            if (txtuser.Text != "admin" && txtpass.Text == "admin")
             {
                  lbl1.Text = "* invalid username";
             }
            if (txtuser.Text != "admin" && txtpass.Text != "admin")
            {
                lbl1.Text = "* invalid username";
                lbl2.Text = "* invalid password";
            }
            if (txtuser.Text == "admin")
            {
                lbl1.Text = "";
            }
            if (txtpass.Text == "admin")
            {
                lbl2.Text = "";
            }
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

       

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {
            txtpass.isPassword = true;
           
          //  txtpass.Text = string.Empty;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtpass.isPassword == true)
            {
                txtpass.isPassword = false;
            }
            else if (txtpass.isPassword == false)
            {
                txtpass.isPassword = true;
            }
        }

      


      /*  void HandleButtonDown(object sender, MouseButtonEventArgs e)
        {
            

            if (e.ButtonState == MouseButtonState.Pressed)
            {
                sourceStackPanel.Width = 200;
                sourceStackPanel.Height = 200;
            }
            else if (e.ButtonState == MouseButtonState.Released)
            {
                sourceStackPanel.Width = 100;
                sourceStackPanel.Height = 100;
            }
        }*/
       

     

       
       

       

      
        
       
    }
}
