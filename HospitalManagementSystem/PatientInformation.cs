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
    public partial class PatientInformation : UserControl
    {
        public PatientInformation()
        {
            InitializeComponent();
        }

        public void LoadCheckupPatients()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select pi.PateintID,pi.Fname+' '+pi.Lname as Name,pi.CNIC,pi.Gender,pi.DOB,pi.House+' '+pi.Street+' '+pi.Colony+' '+pi.City+','+pi.PostalCode as Address,pc.Contact,pd.Disease,pi.CheckupDate,p.DoctorFee From PatientInfo pi JOIN PatientContact pc ON pi.PateintID=pc.PateintID JOIN PatientDisease pd ON pi.PateintID=pd.PatientID JOIN Payment p ON pi.PateintID=p.PatientID where CID =10", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        public void LoadAdmitPatients()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select pi.PateintID,pi.Fname+' '+pi.Lname as Name,pi.CNIC,pi.Gender,pi.DOB,pi.House+' '+pi.Street+' '+pi.Colony+' '+pi.City+','+pi.PostalCode as Address,pc.Contact,pd.Disease,pi.CheckupDate,ri.RoomNo,rc.RoomType,ai.AdmitDate,p.DoctorFee From PatientInfo pi JOIN PatientContact pc ON pi.PateintID=pc.PateintID JOIN PatientDisease pd ON pi.PateintID=pd.PatientID JOIN Payment p ON pi.PateintID=p.PatientID JOIN AdmitInfo ai ON pi.PateintID=ai.PatientID JOIN RoomInfo ri ON ai.RoomID=ri.RoomID JOIN RoomCategory rc ON ri.RoomTypeID=rc.RoomTypeID where CID =20", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        public void LoadDataIntoPatientCategory()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from PatientCategory", con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            patientcatgDD.Items.Add(rdr.GetValue(1).ToString());
                        }
                    }

                }

            }
        }
        private void PatientInformation_Load(object sender, EventArgs e)
        {
            LoadDataIntoPatientCategory();
        }

        private void PatientcatgDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patientcatgDD.SelectedItem.ToString() == "CheckUp Patient")
            {
                LoadCheckupPatients();
            }
            if(patientcatgDD.SelectedItem.ToString() == "Admit Patient")
            {
                LoadAdmitPatients();
            }
        }
    }
}
