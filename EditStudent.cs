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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("UPDATE students SET stu_name=@name, stu_parent=@parent, stu_address=@address, stu_city=@city, stu_phone=@phone, stu_cell=@cell, stu_email=@email, stu_contactTime=@contactTime, stu_contactHow=@contactHow, stu_allergies=@allergies, stu_birthdate=@birthdate, stu_age=@age, stu_groupWith=@groupWith, stu_crew=@crew WHERE stu_id=@id", conn);
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
            StudentList studentList = new StudentList();
            this.Hide();
            studentList.editStudent();  
        }

        private void EditStudent_Load(object sender, EventArgs e)
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
