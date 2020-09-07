using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HospitalManagementSystem
{
    public partial class Appointment : UserControl
    {
        public Appointment()
        {
            InitializeComponent();
        }
        void PrimaryKey()
        {
            int num;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select Max(AppointmentNo) from Appointment", con))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string val = rdr[0].ToString();
                        if (val == "")
                        {
                            appID.Text = "01";
                        }
                        else
                        {
                            num = Convert.ToInt32(rdr[0].ToString());
                            num++;
                            appID.Text = num.ToString();
                        }
                    }

                }
            }
        }
        public void LoadDataIntoDropdown()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select * from StaffInformation ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string a = (rdr.GetValue(1).ToString());
                            string b = (rdr.GetValue(2).ToString());
                            string c = a + " " + b;
                            docnamedd.Items.Add(c);

                        }
                    }
                }


            }
        }
        public void clear()
        {
            fname.Text = "";
            lname.Text = "";
            cnictxt.Text = "";
            docnamedd.SelectedIndex = -1;
        }
        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (!Test.IsEmpty(fname.Text, lname.Text,cnictxt.Text))
            {

                try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("insert into Appointment values(@appID,@fname,@lname,@cnic,@apptime,@appdate,@staffID)", con))
                    {
                        cmd.Parameters.AddWithValue("@appID", appID.Text);
                        cmd.Parameters.AddWithValue("@fname", fname.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@lname", lname.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@cnic", cnictxt.Text);
                        cmd.Parameters.AddWithValue("@apptime", apptime.Value.ToLongTimeString());
                        cmd.Parameters.AddWithValue("@appdate", appdate.Value.Date);



                        using (SqlCommand cmd1 = new SqlCommand("select StaffID from StaffInformation CROSS APPLY(select fname+' '+lname as docname ) c where c.docname='" + docnamedd.SelectedItem.ToString() + "'", con))
                        {
                            using (SqlDataReader rdr = cmd1.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    hidden.Text = rdr.GetValue(0).ToString();
                                }
                            }


                        }

                        cmd.Parameters.AddWithValue("@staffID", hidden.Text);
                        cmd.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Data inserted Successfully", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                PrimaryKey();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            else
            {
               
                MessageBox.Show("Please Fill All Boxes", "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void Appointment_Load(object sender, EventArgs e)
        {
            PrimaryKey();
            LoadDataIntoDropdown();
        }

        private void Cnictxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

    }
}



        