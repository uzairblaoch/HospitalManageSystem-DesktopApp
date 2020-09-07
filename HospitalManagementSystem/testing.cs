using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }
       

        private void Testing_Load(object sender, EventArgs e)
        {


            

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                con.Open();
                //using (SqlDataAdapter da = new SqlDataAdapter("select StaffID, Fname from StaffInformation",con))
                //{

                //    DataSet ds = new DataSet();
                //    da.Fill(ds);
                //    comboBox1.DataSource = ds.Tables[0];
                //    comboBox1.DisplayMember = "Fname";
                //    comboBox1.ValueMember = "StaffID";
                //    comboBox1.SelectedIndex = -1;
                //    //comboBox1.ValueMember = label1.Text;
                //    //if (comboBox1.SelectedValue != "") {
                //    //    MessageBox.Show(comboBox1.ValueMember);
                //    //}

                //}
                using (SqlCommand cmd = new SqlCommand("select * from StaffInformation ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string a = (rdr.GetValue(1).ToString()) + " " + (rdr.GetValue(2).ToString());

                            docnamedd.AddItem(a);

                        }
                    }
                }
            }

        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                con.Open();
                string quer = "select StaffID from StaffInformation CROSS APPLY(select fname+' '+lname as docname ) c where c.docname='" + docnamedd.selectedValue.ToString() + "'";
                using (SqlCommand cmd1 = new SqlCommand(quer, con))
                {
                   
                        using (SqlDataReader rdr = cmd1.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                label1.Text = rdr.GetValue(0).ToString();
                            }
                        }


                    
                }

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.ValueMember);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = listBox1.SelectedItem.ToString();
            textBox1.Text = value1;

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from StaffInformation where Fname+' '+Lname='" + listBox1.SelectedItem.ToString() + "'", con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string sname = (string)rdr["Fname"];
                            textBox1.Text = sname;
                            comboBox1.Items.Add(rdr.GetValue(1));
                        }
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
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

    }
}