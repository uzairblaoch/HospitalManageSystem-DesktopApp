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
    public partial class checkout : UserControl
    {
        public checkout()
        {
            InitializeComponent();
        }
        public void clear()
        {
            patientno.Text ="";
            fname.Text = "";
            lname.Text = "";
            cnic.Text = "";
            gender.Text = "";
            dob.Text = "";
            house.Text = "";
            street.Text = "";
            colony.Text = "";
            city.Text = "";
            postalcode.Text = "";
            contact.Text = "";
            admitteddate.Text = "";
            disease.Text = "";
            statusofdisease.Text = "";
            roomno.Text = "";
            roomtype.Text = "";
            finalfee.Text = "";
            checkoutstatus.Text = "";
        }
        void LoadAdmitPatients()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from PatientInfo where CID=20 ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string a = rdr.GetValue(1).ToString();
                            string b = rdr.GetValue(2).ToString();
                            string c = a + " " + b;
                            listBox1.Items.Add(c);

                        }
                    }
                }
            }
        }
        private void Checkout_Load(object sender, EventArgs e)
        {
            btncheckout.Enabled = false;
            LoadAdmitPatients();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {

                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("select pi.*,pc.Contact,pd.Disease,pd.StatusOfDisease from PatientInfo pi JOIN PatientContact pc ON pi.PateintID=pc.PateintID  JOIN PatientDisease pd ON pi.PateintID=pd.PatientID where CID=20 and Fname+' '+Lname='" + listBox1.Text + "'", con))
                        {
                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    patientno.Text = rdr.GetValue(0).ToString();
                                    fname.Text = rdr.GetValue(1).ToString();
                                    lname.Text = rdr.GetValue(2).ToString();
                                    cnic.Text = rdr.GetValue(3).ToString();
                                    gender.Text = rdr.GetValue(4).ToString();
                                    DateTime dobdate = (DateTime)rdr["DOB"];
                                    dob.Text = dobdate.ToString("dd/MM/yyyy");
                                    house.Text = rdr.GetValue(6).ToString();
                                    street.Text = rdr.GetValue(7).ToString();
                                    colony.Text = rdr.GetValue(8).ToString();
                                    city.Text = rdr.GetValue(9).ToString();
                                    postalcode.Text = rdr.GetValue(10).ToString();
                                    contact.Text = rdr.GetValue(14).ToString();
                                    DateTime admitdate = (DateTime)rdr["CheckupDate"];
                                    admitteddate.Text = admitdate.ToString("dd/MM/yyyy");
                                    disease.Text = rdr.GetValue(15).ToString();
                                    statusofdisease.Text = rdr.GetValue(16).ToString();
                                }

                            }

                        }
                        using (SqlCommand cmd = new SqlCommand("select RoomID From AdmitInfo where PatientID=(select PateintID From PatientInfo where CID=20 and Fname+' '+Lname='" + listBox1.Text + "')", con))
                        {
                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    hidden.Text = rdr.GetValue(0).ToString();
                                }
                            }

                        }
                        using (SqlCommand cmd = new SqlCommand("select RoomNo From RoomInfo where RoomID='" + hidden.Text + "'", con))
                        {
                            using (SqlDataReader rdr =cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    roomno.Text = rdr.GetValue(0).ToString();
                                }
                            }
                        }
                        using (SqlCommand cmd = new SqlCommand("select RoomType From RoomCategory where RoomTypeID=(select RoomTypeID From RoomInfo where RoomID='"+hidden.Text+"')",con))
                        {
                            using(SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    roomtype.Text = rdr.GetValue(0).ToString();
                                }
                            }
                        }
                        using(SqlCommand cmd = new SqlCommand("select price/2 as finalfee from RoomInfo where RoomID='"+hidden.Text+"'",con))
                        {
                            using(SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    finalfee.Text = rdr.GetValue(0).ToString();
                                }
                            }
                        }
                        using (SqlCommand cmd = new SqlCommand("select CheckoutStatus from AdmitInfo where PatientID=(select PateintID From PatientInfo where CID=20 and Fname+' '+Lname='" + listBox1.Text + "')", con))
                        {
                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    checkoutstatus.Text = rdr.GetValue(0).ToString();
                                }
                            }
                        }
                    }
                    btncheckout.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btnunselect_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            clear();
            btncheckout.Enabled = false;
        }

        private void Btncheckout_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlDataAdapter da= new SqlDataAdapter("update RoomInfo set Status='FREE' where RoomNo='"+roomno.Text+"'", con))
                {
                    da.SelectCommand.ExecuteNonQuery();
                }
                using (SqlDataAdapter da = new SqlDataAdapter("update AdmitInfo set CheckoutStatus='Checkout' where PatientID=(select PateintID From PatientInfo where CID=20 and Fname+' '+Lname='"+listBox1.Text+"')", con))
                {
                    da.SelectCommand.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Patient Checkout Successfully!", "Successful Message",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.ClearSelected();
            clear();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            LoadAdmitPatients();
        }
    }
}
