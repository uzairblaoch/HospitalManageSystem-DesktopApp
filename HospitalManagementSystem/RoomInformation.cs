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
    public partial class RoomInformation : UserControl
    {
        public RoomInformation()
        {
            InitializeComponent();
        }
        void LoadRooms()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from RoomInfo ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            listBox1.Items.Add(rdr.GetValue(1).ToString());
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
                using (SqlCommand cmd = new SqlCommand("Select Max(RoomID) from RoomInfo", con))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string val = rdr[0].ToString();
                        if (val == "")
                        {
                            roomID.Text = "01";
                        }
                        else
                        {
                            num = Convert.ToInt32(rdr[0].ToString());
                            num++;
                            roomID.Text = num.ToString();
                        }
                    }

                }
            }
        }
        public void clearD()
        {
            roomDID.Text = "";
            roomDNo.Text = "";
            roomDType.Text = "";
            roomDPrice.Text = "";
            roomDStatus.Text = "";
        }
        public void clear()
        {
            roomNO.Text = "";
            roomType.SelectedIndex = -1;
            roomPrice.Text = "";
            roomStatus.SelectedIndex = -1;
        }
        public void LoadRoomCategory()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select * from RoomCategory ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            roomType.Items.Add(rdr.GetValue(1).ToString());
                        }
                    }
                }


            }
        }

        private void RoomInformation_Load(object sender, EventArgs e)
        {
            LoadRoomCategory();
            PrimaryKey();
            LoadRooms();
        }

        private void Btnunselect_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            clearD();
            btnadd.Enabled = true;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (!Test.IsEmpty(roomNO.Text, roomPrice.Text))
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("insert into RoomInfo Values(@roomID,@roomNo,@roomPrice,@roomStatus,@roomTypeID)", con))
                        {
                            cmd.Parameters.AddWithValue("@roomID", roomID.Text);
                            cmd.Parameters.AddWithValue("@roomNo", roomNO.Text);
                            cmd.Parameters.AddWithValue("@roomPrice", roomPrice.Text);
                            cmd.Parameters.AddWithValue("@roomStatus", roomStatus.SelectedItem.ToString().ToUpper());

                            using (SqlCommand cmd1=new SqlCommand("select RoomTypeID from RoomCategory where RoomType='"+ roomType.SelectedItem.ToString()+ "'",con))
                            {
                                using (SqlDataReader rdr=cmd1.ExecuteReader())
                                {
                                    while(rdr.Read())
                                    {
                                        hidden.Text = rdr.GetValue(0).ToString();
                                    }

                                }
                            }
                            cmd.Parameters.AddWithValue("@roomTypeID", hidden.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Data inserted Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    PrimaryKey();
                    listBox1.Items.Clear();
                    LoadRooms();
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
                        using (SqlCommand cmd = new SqlCommand("select r.RoomID,r.RoomNo, rc.RoomType, r.Price, r.Status from RoomInfo r Join RoomCategory rc ON rc.RoomTypeID=r.RoomTypeID  where RoomNo='" + listBox1.Text + "'", con))
                        {
                            using (SqlDataReader rdr = cmd.ExecuteReader())
                            {
                                while (rdr.Read())
                                {
                                    roomDID.Text = rdr.GetValue(0).ToString();
                                    roomDNo.Text = rdr.GetValue(1).ToString();
                                    roomDType.Text = rdr.GetValue(2).ToString();
                                    roomDPrice.Text = rdr.GetValue(3).ToString();
                                    roomDStatus.Text = rdr.GetValue(4).ToString();
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
            if (!Test.IsEmpty(roomDNo.Text,roomDPrice.Text))
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string update = "update RoomInfo set RoomNo='"+roomDNo.Text+"',Price='"+roomDPrice.Text+"',Status='"+roomDStatus.Text+"',RoomTypeID=(select RoomTypeID From RoomCategory where RoomType='"+roomDType.Text + "') where RoomID='" + roomDID.Text + "'";
                        using (SqlDataAdapter da = new SqlDataAdapter(update,con))
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
            listBox1.Items.Clear();
            LoadRooms();
                clearD();
            }
            else
            {
                MessageBox.Show("Please Fill All Boxes", "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RoomDType_OnValueChanged(object sender, EventArgs e)
        {
            roomTypeSet.Items.Clear();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select * from RoomCategory ", con))
                {

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            roomTypeSet.Items.Add(rdr.GetValue(1).ToString());
                        }
                    }
                }


            }
            
        }

        private void RoomTypeSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            roomDType.Text = roomTypeSet.SelectedItem.ToString();
            
        }
    }
}
