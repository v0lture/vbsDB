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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            editStudent();
        }

        public void editStudent()
        {
            string name = null, parent = null, address = null, city = null, phone = null, cell = null, email = null, contactTime = null, contactHow = null, allergies = null, birthdate = null, age = null, groupWith = null, crew = null, id = null;
            EditStudent editStudent = new EditStudent();
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE stu_id=@id", conn);
            cmd.Parameters.AddWithValue("@id", lstStudents.SelectedItems[0].SubItems[14].Text);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["stu_name"].ToString();
                parent = reader["stu_parent"].ToString();
                address = reader["stu_address"].ToString();
                city = reader["stu_city"].ToString();
                phone = reader["stu_phone"].ToString();
                cell = reader["stu_cell"].ToString();
                email = reader["stu_email"].ToString();
                contactTime = reader["stu_contactTime"].ToString();
                contactHow = reader["stu_contactHow"].ToString();
                allergies = reader["stu_allergies"].ToString();
                birthdate = reader["stu_birthdate"].ToString();
                age = reader["stu_age"].ToString();
                groupWith = reader["stu_groupWith"].ToString();
                crew = reader["stu_crew"].ToString();
                id = reader["stu_id"].ToString();
            }  
            editStudent.Show();
            editStudent.txtName.Text = name;
            editStudent.txtParent.Text = parent;
            editStudent.txtAddress.Text = address;
            editStudent.txtCity.Text = city;
            editStudent.txtPhone.Text = phone;
            editStudent.txtCell.Text = cell;
            editStudent.txtEmail.Text = email;
            editStudent.txtContactTime.Text = contactTime;
            editStudent.txtContactHow.Text = contactHow;
            editStudent.txtAllergies.Text = allergies;
            editStudent.birthdatePicker.Value = Convert.ToDateTime(birthdate);
            editStudent.txtAge.Text = age;
            editStudent.txtGroupWith.Text = groupWith;
            editStudent.cmbCrew.Text = crew;
            editStudent.lblId.Text = id;
        }

        private void btnDropStudent_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM students WHERE stu_id=@id", conn);
            cmd.Parameters.AddWithValue("@id", lstStudents.SelectedItems[0].SubItems[14].Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadForm();
        }
        public void loadForm()
        {
            lstStudents.Items.Clear();
            lstStudents.FullRowSelect = true;
            lstStudents.GridLines = true;
            lstStudents.Sorting = SortOrder.Ascending;
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string parent = reader["stu_parent"].ToString();
                string address = reader["stu_address"].ToString();
                string city = reader["stu_city"].ToString();
                string phone = reader["stu_phone"].ToString();
                string cell = reader["stu_cell"].ToString();
                string email = reader["stu_email"].ToString();
                string contactTime = reader["stu_contactTime"].ToString();
                string contactHow = reader["stu_contactHow"].ToString();
                string allergies = reader["stu_allergies"].ToString();
                string birthdate = Convert.ToDateTime(reader["stu_birthdate"]).ToString("MM/dd/yyyy");
                string age = reader["stu_age"].ToString();
                string groupWith = reader["stu_groupWith"].ToString();
                string crew = reader["stu_crew"].ToString();
                string[] row = { name, parent, address, city, phone, cell, email, contactTime, contactHow, allergies, birthdate, age, groupWith, crew, id };
                var listViewItem = new ListViewItem(row);
                lstStudents.Items.Add(listViewItem);

            }
            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
