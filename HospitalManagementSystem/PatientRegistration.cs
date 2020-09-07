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
    public partial class PatientRegistration : UserControl
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }
        void LoadRoomsCategory()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd=new SqlCommand("select RoomType From RoomCategory",con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        { 
                            roomtypeDD.Items.Add(rdr.GetValue(0));
                        }
                    }
                }
            }

        }
        public void clear()
        {
            patientID.Text = "";
            appID.Text = "";
            fnametxt.Text = "";
            lnametxt.Text = "";
            genderDD.SelectedIndex = -1;
            cnic.Text = "";
            housetxt.Text = "";
            streettxt.Text = "";
            colonytxt.Text = "";
            citytxt.Text = "";
            postaltxt.Text = "";
            contact.Text = "";
            patientcatgDD.SelectedIndex = -1;
            diseasetxt.Text = "";
            statusdiseasetxt.Text = "";
            docfeetxt.Text = "";
            roomtypeDD.SelectedIndex = -1;
            roomnoDD.SelectedIndex = -1;
            advancepricetxt.Text = "";
            drugnameDD.SelectedIndex = -1;
            dosageDD.SelectedIndex = -1;
            drugtypeDD.SelectedIndex = -1;
            drugfreqDD.SelectedIndex = -1;

        }
        public void LoadDrugFreq()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from DrugFrequency", con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            drugfreqDD.Items.Add(rdr.GetValue(1).ToString());
                        }
                    }
                }
            }
        }
        public void LoadDrug()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using(SqlCommand cmd=new SqlCommand("select * from Drugs", con))
                {
                    using (SqlDataReader rdr=cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            drugnameDD.Items.Add(rdr.GetValue(1).ToString());
                        }
                    }
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
       public void PrimaryKey()
        {
            int num;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select Max(PateintID) from PatientInfo", con))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string val = rdr[0].ToString();
                        if (val == "")
                        {
                            patientID.Text = "01";
                        }
                        else
                        {
                            num = Convert.ToInt32(rdr[0].ToString());
                            num++;
                            patientID.Text = num.ToString();
                        }
                    }

                }
            }
        }
        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (!Test.IsEmpty(fnametxt.Text, lnametxt.Text,cnic.Text,
                housetxt.Text, streettxt.Text, colonytxt.Text, citytxt.Text,  postaltxt.Text, contact.Text,
                diseasetxt.Text,statusdiseasetxt.Text,docfeetxt.Text,advancepricetxt.Text))
            {
               try {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();


                using (SqlCommand cmd = new SqlCommand("insert into PatientInfo values(@PID,@fname,@lname,@cnic,@gender,@dob,@house,@street,@colony,@city,@postalcode,@checkupdate,@appointmentID,@patientcategory)", con))
                {
                    cmd.Parameters.AddWithValue("@PID", patientID.Text);
                    cmd.Parameters.AddWithValue("@fname", fnametxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@lname", lnametxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@cnic", cnic.Text);
                    cmd.Parameters.AddWithValue("@dob", dob.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", genderDD.SelectedItem.ToString().ToUpper());
                    cmd.Parameters.AddWithValue("@house", housetxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@street", streettxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@colony", colonytxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@city", citytxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@postalcode", postaltxt.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@checkupdate", checkupdate.Value.Date);
                    cmd.Parameters.AddWithValue("@appointmentID", appID.Text);
                    using (SqlCommand cmd3 = new SqlCommand("select CID  from PatientCategory where Cname ='" + patientcatgDD.SelectedItem.ToString() + "'", con))
                    {
                        using (SqlDataReader rdr1 = cmd3.ExecuteReader())
                        {
                                while (rdr1.Read())
                                {
                                    hidden.Text = rdr1.GetValue(0).ToString();
                                }
                        }

                    }
                    cmd.Parameters.AddWithValue("@patientcategory", hidden.Text);
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd1 = new SqlCommand("insert into Payment (PatientID,DoctorFee)Values(@PID,@doctorfee)", con))
                {
                    cmd1.Parameters.AddWithValue("@doctorfee", docfeetxt.Text);
                    cmd1.Parameters.AddWithValue("@PID", patientID.Text);
                    cmd1.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand("insert into PatientContact values(@PID,@contact)", con))
                {
                    cmd2.Parameters.AddWithValue("@PID", patientID.Text);
                    cmd2.Parameters.AddWithValue("@contact", contact.Text);
                    cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd4 = new SqlCommand("insert into PatientDisease values(@PID,@disease,@statusofdisease,@dignosedate)", con))
                {

                    cmd4.Parameters.AddWithValue("@disease", diseasetxt.Text.ToUpper());
                    cmd4.Parameters.AddWithValue("@statusofdisease", statusdiseasetxt.Text.ToUpper());
                    cmd4.Parameters.AddWithValue("@dignosedate", checkupdate.Text);
                    cmd4.Parameters.AddWithValue("@PID", patientID.Text);
                    cmd4.ExecuteNonQuery();
                }
                if (patientcatgDD.SelectedItem.ToString() == "Admit Patient")
                { 
                    using (SqlCommand cmd5 = new SqlCommand("insert into AdmitInfo Values(@PID,@admitdate,@roomID,@advancepayment,@CheckoutStatus)", con))
                    {
                        cmd5.Parameters.AddWithValue("@PID", patientID.Text);
                        cmd5.Parameters.AddWithValue("@admitdate", admitdate.Value.Date);
                        cmd5.Parameters.AddWithValue("@advancepayment", advancepricetxt.Text);
                        cmd5.Parameters.AddWithValue("@CheckoutStatus","Admit");
                        using (SqlCommand cmd6 = new SqlCommand("select RoomID From RoomInfo where RoomNo='" + roomnoDD.SelectedItem.ToString() + "'", con))
                        {
                            using (SqlDataReader rdr = cmd6.ExecuteReader())
                            {
                                    while (rdr.Read())
                                    {
                                        hidden2.Text = rdr.GetValue(0).ToString();
                                    }
                            }

                        }
                        cmd5.Parameters.AddWithValue("@roomID", hidden2.Text);
                        cmd5.ExecuteNonQuery();
                    }
                            using (SqlCommand cmd = new SqlCommand("update RoomInfo set Status='BUSY' where RoomID=(select RoomID From AdmitInfo where PatientID='"+patientID.Text+"')",con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                }
                using(SqlCommand cmd7 = new SqlCommand("insert into Prescription Values(@drugname,@dosage,@drugtype,@dfid,@startdate,@finishdate,@pid)", con))
                {
                    
                    cmd7.Parameters.AddWithValue("@startdate", startdate.Value.Date);
                    cmd7.Parameters.AddWithValue("@finishdate", startdate.Value.Date);
                    cmd7.Parameters.AddWithValue("@pid", patientID.Text);
                    using (SqlCommand cmddrugid=new SqlCommand("select DrugID From Drugs where DrugName='"+drugnameDD.SelectedItem.ToString()+"'",con))
                    {
                        using (SqlDataReader rdr = cmddrugid.ExecuteReader())
                        {
                                while (rdr.Read())
                                {
                                    drugid.Text = rdr.GetValue(0).ToString();
                                }
                        }
                    }
                    using (SqlCommand cmddosageid = new SqlCommand("select DosageID From Dosages where Dosage='" + dosageDD.SelectedItem.ToString() + "'", con))
                    {
                        using (SqlDataReader rdr = cmddosageid.ExecuteReader())
                        {
                                while (rdr.Read())
                                {
                                    dosageid.Text = rdr.GetValue(0).ToString();
                                }
                        }
                    }
                    using (SqlCommand cmddrugtypeid = new SqlCommand("select DrugTypeID From DrugTypes where DrugTypeName='" + drugtypeDD.SelectedItem.ToString() + "'", con))
                    {
                        using (SqlDataReader rdr = cmddrugtypeid.ExecuteReader())
                        {
                                while (rdr.Read())
                                {
                                    ddrugtypeid.Text = rdr.GetValue(0).ToString();
                                }
                        }
                    }
                    using (SqlCommand cmddfid = new SqlCommand("select DfID From DrugFrequency where DfType='" + drugfreqDD.SelectedItem.ToString() + "'", con))
                    {
                        using (SqlDataReader rdr = cmddfid.ExecuteReader())
                        {
                                while (rdr.Read())
                                {
                                    ddfreqid.Text = rdr.GetValue(0).ToString();
                                }
                        }
                    }
                     cmd7.Parameters.AddWithValue("@drugname", drugid.Text);
                     cmd7.Parameters.AddWithValue("@dosage", dosageid.Text);
                     cmd7.Parameters.AddWithValue("@drugtype", ddrugtypeid.Text);
                     cmd7.Parameters.AddWithValue("@dfid",  ddfreqid.Text);
                     cmd7.ExecuteNonQuery();
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
        
        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            alert.Hide();
            PrimaryKey();
            LoadDataIntoPatientCategory();
            LoadDrug();
            
            LoadRoomsCategory();

        }

       

        private void Housetxt_OnValueChanged(object sender, EventArgs e)
        {
            
        }


        private void PatientcatgDD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (patientcatgDD.SelectedIndex == -1)
            {
                roomtypeDD.Items.Clear();
                roomnoDD.Items.Clear();
                LoadRoomsCategory();
                roomtypeDD.Enabled = true;
                roomnoDD.Enabled = true;
                advancepricetxt.Enabled = true;
                admitdate.Enabled = true;
            }
            else if (patientcatgDD.SelectedItem.ToString() == "CheckUp Patient")
            {
                advancepricetxt.Text = "";
                roomtypeDD.Items.Clear();
                roomnoDD.Items.Clear();
                roomtypeDD.Enabled = false;
                roomnoDD.Enabled = false;
                advancepricetxt.Enabled = false;
                admitdate.Enabled = false;
            }
            else
            {
                roomtypeDD.Items.Clear();
                LoadRoomsCategory();
                roomtypeDD.Enabled = true;
                roomnoDD.Enabled = true;
                advancepricetxt.Enabled = true;
                admitdate.Enabled = true;
            }
            
        }

        private void DrugnameDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drugnameDD.SelectedIndex != -1)
            {
                dosageDD.Items.Clear();
                drugtypeDD.Items.Clear();
                drugfreqDD.Items.Clear();
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select Dosage from Dosages where DrugID=(select DrugID From Drugs where DrugName='" + drugnameDD.SelectedItem.ToString() + "')", con))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {

                                dosageDD.Items.Add(rdr.GetValue(0).ToString());
                            }
                        }

                    }

                }
            }
        }

        private void DosageDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dosageDD.SelectedIndex != -1)
            {
                drugtypeDD.Items.Clear();
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select DrugTypeName from DrugTypes where DosageID=(select DosageID From Dosages where Dosage='" + dosageDD.SelectedItem.ToString() + "')", con))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                drugtypeDD.Items.Add(rdr.GetValue(0).ToString());
                            }
                        }
                    }
                }
            }
        }

        private void RoomtypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomtypeDD.SelectedIndex != -1)
            {
                roomnoDD.Items.Clear();
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select RoomNo From RoomInfo where RoomTypeID=(select RoomTypeID From RoomCategory where Status='FREE' AND RoomType='" + roomtypeDD.SelectedItem.ToString() + "')", con))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                roomnoDD.Items.Add(rdr.GetValue(0));
                            }
                        }
                    }
                }
            }
        }

        private void RoomnoDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomnoDD.SelectedIndex != -1)
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select   Price/2 as AdvancePrice  from RoomInfo where RoomNo='" + roomnoDD.SelectedItem.ToString() + "'", con))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                advancepricetxt.Text = rdr.GetValue(0).ToString();
                            }
                        }
                    }
                }
            }
        }

        private void DrugtypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drugtypeDD.SelectedIndex != -1)
            {
                LoadDrugFreq();
            }
        }

        private void Housetxt_Enter(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select AppointmentNo from Appointment where CNIC='" + cnic.Text + "'", con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {

                            appID.Text = rdr.GetValue(0).ToString();
                        }
                        else
                        {
                            appID.Text = "";
                        }
                        if (appID.Text == "")
                        {
                            alert.Show();

                            streettxt.Enabled = false;
                            colonytxt.Enabled = false;
                            citytxt.Enabled = false;
                            postaltxt.Enabled = false;
                            contact.Enabled = false;
                            patientcatgDD.Enabled = false;
                            diseasetxt.Enabled = false;
                            statusdiseasetxt.Enabled = false;
                            docfeetxt.Enabled = false;
                            drugnameDD.Enabled = false;
                            dosageDD.Enabled = false;
                            drugtypeDD.Enabled = false;
                            drugfreqDD.Enabled = false;
                            MessageBox.Show("Please Take Appointment First", "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            alert.Hide();
                            streettxt.Enabled = true;
                            colonytxt.Enabled = true;
                            citytxt.Enabled = true;
                            postaltxt.Enabled = true;
                            contact.Enabled = true;
                            patientcatgDD.Enabled = true;
                            diseasetxt.Enabled = true;
                            statusdiseasetxt.Enabled = true;
                            docfeetxt.Enabled = true;
                            drugnameDD.Enabled = true;
                            dosageDD.Enabled = true;
                            drugtypeDD.Enabled = true;
                            drugfreqDD.Enabled = true;
                        }
                    }

                }
            }
        }
    }
}
