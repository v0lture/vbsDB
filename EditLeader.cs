using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace vbsDB
{
    public partial class EditLeader : Form
    {
        public EditLeader()
        {
            InitializeComponent();
        }

        private void btnEditLeader_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("UPDATE leaders SET ldr_name=@name, ldr_address=@address, ldr_city=@city, ldr_phone=@phone, ldr_cell=@cell, ldr_email=@email, ldr_contactTime=@contactTime, ldr_contactHow=@contactHow, ldr_allergies=@allergies, ldr_birthdate=@birthdate, ldr_age=@age, ldr_helpWith=@helpWith WHERE ldr_id=@id", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@cell", txtCell.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@contactTime", txtContactTime.Text);
            cmd.Parameters.AddWithValue("@contactHow", txtContactHow.Text);
            cmd.Parameters.AddWithValue("@allergies", txtAllergies.Text);
            cmd.Parameters.AddWithValue("@birthdate", birthdatePicker.Value);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@helpWith", cmbHelpWith.Text);
            cmd.Parameters.AddWithValue("@id", lblId.Text);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
             
        }

        private void EditLeader_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM crews", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string crewName = reader["crw_name"].ToString();
                cmbHelpWith.Items.Add(crewName);
            }
            conn.Close();
            
        }
    }
}
