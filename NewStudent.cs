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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO students (stu_name, stu_parent, stu_address, stu_city, stu_phone, stu_cell, stu_email, stu_contactTime, stu_contactHow, stu_allergies, stu_birthdate, stu_age, stu_groupWith, stu_crew) VALUES (@name, @parent, @address, @city, @phone, @cell, @email, @contactTime, @contactHow, @allergies, @birthdate, @age, @groupWith, @crew)", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@parent", txtParent.Text);
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
            cmd.Parameters.AddWithValue("@groupWith", txtGroupWith.Text);
            cmd.Parameters.AddWithValue("@crew", cmbCrew.Text);
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
            txtParent.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtCell.Text = "";
            txtEmail.Text = "";
            txtContactTime.Text = "";
            txtContactHow.Text = "";
            txtAllergies.Text = "";
            txtAge.Text = "";
            txtGroupWith.Text = "";
        }

        private void btnAutoCrew_Click(object sender, EventArgs e)
        {

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM crews", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string crewName = reader["crw_name"].ToString();
                cmbCrew.Items.Add(crewName);
            }
            conn.Close();
        }
    }
}
