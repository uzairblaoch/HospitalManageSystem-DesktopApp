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
    public partial class MedicineInfo : UserControl
    {
        public MedicineInfo()
        {
            InitializeComponent();
        }
        void LoadDoctors()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Drugs ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string a = rdr.GetValue(1).ToString();
                            listBox1.Items.Add(a);

                        }
                    }
                }
            }
        }
        public void clear()
        {
            drugname.Text = "";
            dosage.Text = "";
            drugtype.SelectedIndex = -1;
        }
        void PrimaryKey()
        {
            int num;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select Max(DrugID) from Drugs", con))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string val = rdr[0].ToString();
                        if (val == "")
                        {
                            drugID.Text = "01";
                        }
                        else
                        {
                            num = Convert.ToInt32(rdr[0].ToString());
                            num++;
                            drugID.Text = num.ToString();
                        }
                    }

                }
            }
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (!Test.IsEmpty(drugname.Text, dosage.Text))
            {
                try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("insert into Drugs Values(@drugID,@drugname) ", con))
                    {
                        cmd.Parameters.AddWithValue("@drugID", drugID.Text);
                        cmd.Parameters.AddWithValue("@drugname", drugname.Text.ToUpper());
                        cmd.ExecuteNonQuery();
                    }
                    using(SqlCommand cmd=new SqlCommand("insert into Dosages Values(@dosage,@drugID)",con))
                        {
                            cmd.Parameters.AddWithValue("@dosage", dosage.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@drugID", drugID.Text);
                            cmd.ExecuteNonQuery();
                        }
                        using (SqlCommand cmd = new SqlCommand("insert into DrugTypes Values(@drugtype,@dosageID)",con))
                        {
                            cmd.Parameters.AddWithValue("@drugtype", drugtype.SelectedItem.ToString().ToUpper());
                            using (SqlCommand cmd1 = new SqlCommand("select DosageID from Dosages where Dosage='" + dosage.Text + "'", con))
                            {
                                using (SqlDataReader rdr = cmd1.ExecuteReader())
                                {
                                    while (rdr.Read())
                                    {
                                        hidden.Text = rdr.GetValue(0).ToString();
                                    }
                                }
                            }
                            cmd.Parameters.AddWithValue("@dosageID", hidden.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                MessageBox.Show("Data inserted Successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                PrimaryKey();
                listBox1.Items.Clear();
                LoadDoctors();
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

        private void MedicineInfo_Load(object sender, EventArgs e)
        {
            PrimaryKey();
            LoadDoctors();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            if (listBox1.SelectedItem != null)
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {

                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("select d.DrugID, d.DrugName,ds.Dosage,dt.DrugTypeName from Drugs d JOIN Dosages ds ON d.DrugID=ds.DrugID JOIN DrugTypes dt ON ds.DosageID=dt.DosageID where DrugName='" + listBox1.Text + "'", con))
                        {
                            using (SqlDataReader rdr=cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    drugID.Text = rdr.GetValue(0).ToString();
                                    drugname.Text = rdr.GetValue(1).ToString();
                                    dosage.Text = rdr.GetValue(2).ToString();
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
            if (!Test.IsEmpty(drugname.Text, dosage.Text))
            {
                try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string update = "update Drugs set DrugName='" + drugname.Text.ToUpper() + "' where DrugID='" + drugID.Text + "'";

                    using (SqlDataAdapter da = new SqlDataAdapter(update, con))
                    {

                        da.SelectCommand.ExecuteNonQuery();
                    }
                    string update1 = "update Dosages set Dosage='" + dosage.Text.ToUpper() + "' where DrugID='" + drugID.Text + "'";
                    using (SqlDataAdapter da = new SqlDataAdapter(update1, con))
                    {

                        da.SelectCommand.ExecuteNonQuery();
                    }
                    string update2 = "update DrugTypes set DrugTypeName='" + drugtype.SelectedItem.ToString().ToUpper() + "' where DosageID=(select DosageID from Dosages where Dosage='" + dosage.Text + "')";
                    using (SqlDataAdapter da = new SqlDataAdapter(update2, con))
                    {

                        da.SelectCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data Update Succesfully", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Btnunselect_Click(object sender, EventArgs e)
        {
           
            listBox1.ClearSelected();
            clear();
            PrimaryKey();
            btnadd.Enabled = true;
        }
    }
}
