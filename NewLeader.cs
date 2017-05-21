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
    public partial class NewLeader : Form
    {      
        public NewLeader()
        {
            InitializeComponent();
        }

        private void btnAddLeader_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO leaders (ldr_name, ldr_address, ldr_city, ldr_phone, ldr_cell, ldr_email, ldr_contactTime, ldr_contactHow, ldr_allergies, ldr_birthdate, ldr_age, ldr_helpWith) VALUES (@name, @address, @city, @phone, @cell, @email, @contactTime, @contactHow, @allergies, @birthdate, @age, @helpWith)", conn);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtCell.Text = "";
            txtEmail.Text = "";
            txtContactTime.Text = "";
            txtContactHow.Text = "";
            txtAllergies.Text = "";
            txtAge.Text = "";
        }

    }
}
