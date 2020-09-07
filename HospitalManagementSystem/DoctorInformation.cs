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
    public partial class DoctorInformation : UserControl
    {
        public DoctorInformation()
        {
            InitializeComponent();
        }

        private void DoctorInformation_Load(object sender, EventArgs e)
        {
            PrimaryKey();
            LoadDoctors();
        }


        void LoadDoctors()
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
                            string a = rdr.GetValue(1).ToString();
                            string b = rdr.GetValue(2).ToString();
                            string c = a + " " + b;
                            listBox1.Items.Add(c);

                        }
                    }
                }
            }
        }

        void PrimaryKey()
        {
            int num;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select Max(StaffID) from StaffInformation", con))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string val = rdr[0].ToString();
                        if (val == "")
                        {
                            staffID.Text = "01";
                        }
                        else
                        {
                            num = Convert.ToInt32(rdr[0].ToString());
                            num++;
                            staffID.Text = num.ToString();
                        }
                    }

                }
            }
        }

        public void clear()
        {
            fnametxt.Text = "";
            lnametxt.Text = "";
            gender.SelectedIndex= -1;
            house.Text = "";
            street.Text = "";
            colony.Text = "";
            city.Text = "";
            province.Text = "";
            country.Text = "";
            postalcode.Text = "";
            contact.Text = "";
            job.Text = "";

        }


        private void Btnadd_Click_1(object sender, EventArgs e)
        {
            
            if (!Test.IsEmpty(fnametxt.Text, lnametxt.Text, house.Text, street.Text, colony.Text, city.Text, province.Text, country.Text, postalcode.Text, contact.Text, job.Text))
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("insert into StaffInformation values(@staffID,@fname,@lname,@gender,@house,@street,@colony,@city,@province,@country,@postalcode)", con))
                        {
                            cmd.Parameters.AddWithValue("@staffID", staffID.Text);
                            cmd.Parameters.AddWithValue("@fname", fnametxt.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@lname", lnametxt.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@gender", gender.SelectedItem.ToString().ToUpper());
                            cmd.Parameters.AddWithValue("@house", house.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@street", street.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@colony", colony.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@city", city.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@province", province.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@country", country.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@postalcode", postalcode.Text.ToUpper());

                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd1 = new SqlCommand("insert into StaffJob values(@staffID,@job,@hiredate)", con))
                        {
                            cmd1.Parameters.AddWithValue("@staffID", staffID.Text);
                            cmd1.Parameters.AddWithValue("@job", job.Text.ToUpper());
                            cmd1.Parameters.AddWithValue("@hiredate", hiredate.Value.Date);
                            cmd1.ExecuteNonQuery();
                        }
                        using (SqlCommand cmd2 = new SqlCommand("insert into StaffContact values(@staffID,@contact)", con))
                        {
                            cmd2.Parameters.AddWithValue("@staffID", staffID.Text);
                            cmd2.Parameters.AddWithValue("@contact", contact.Text);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Data inserted Successfully", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    PrimaryKey();
                    listBox1.Items.Clear();
                    LoadDoctors();
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


        private void Contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            if (listBox1.SelectedItem != null) { 
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {

                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("select si.*,sc.Contact,sj.Job,sj.Date from StaffInformation si JOIN StaffJob sj ON si.StaffID=sj.StaffID JOIN StaffContact sc ON si.StaffID=sc.StaffID  where Fname+' '+Lname='" + listBox1.Text + "'", con))
                        {
                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                  while (rdr.Read())
                                {
                                    staffID.Text = rdr.GetValue(0).ToString();
                                    fnametxt.Text = rdr.GetValue(1).ToString();
                                    lnametxt.Text = rdr.GetValue(2).ToString();
                                    house.Text = rdr.GetValue(4).ToString();
                                    street.Text = rdr.GetValue(5).ToString();
                                    colony.Text = rdr.GetValue(6).ToString();
                                    city.Text = rdr.GetValue(7).ToString();
                                    province.Text = rdr.GetValue(8).ToString();
                                    country.Text = rdr.GetValue(9).ToString();
                                    postalcode.Text = rdr.GetValue(10).ToString();
                                    contact.Text = rdr.GetValue(11).ToString();
                                    job.Text = rdr.GetValue(12).ToString();
                                    hiredate.Text = rdr.GetValue(13).ToString();
                                }
                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            if (!Test.IsEmpty(fnametxt.Text, lnametxt.Text, house.Text, street.Text, colony.Text, city.Text, province.Text, country.Text, postalcode.Text, contact.Text, job.Text))
            {
                try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string update = "update StaffInformation set Fname='" + fnametxt.Text.ToUpper() + "',Lname='" + lnametxt.Text.ToUpper() + "',Gender='" + gender.SelectedItem.ToString().ToUpper() + "',House='" + house.Text.ToUpper() + "',Street='" + street.Text.ToUpper() + "',Colony='" + colony.Text.ToUpper() + "',City='" + city.Text.ToUpper() + "',Province='" + province.Text.ToUpper() + "',Country='" + country.Text.ToUpper() + "',PostalCode='" + postalcode.Text.ToUpper() + "' where StaffID='" + staffID.Text + "'";

                    using (SqlDataAdapter da = new SqlDataAdapter(update, con))
                    {

                        da.SelectCommand.ExecuteNonQuery();
                    }
                    string update1 = "update StaffContact set Contact='"+contact.Text+"'where StaffID='"+staffID.Text+"'";
                    using (SqlDataAdapter da = new SqlDataAdapter(update1, con))
                    {

                        da.SelectCommand.ExecuteNonQuery();
                    }
                    string update2 = "update StaffJob set Job='"+job.Text+"',Date='"+hiredate.Value.Date+"'where StaffID='" + staffID.Text + "'";
                    using (SqlDataAdapter da = new SqlDataAdapter(update2, con))
                    {

                        da.SelectCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Update Succesfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox1.ClearSelected();
                    clear();
                }
                catch(Exception ex)
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

        private void Btnunselect_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            clear();
            PrimaryKey();
            btnadd.Enabled = true;
        }
    }
}
