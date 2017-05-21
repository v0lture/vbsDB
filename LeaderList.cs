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
    public partial class LeaderList : Form
    {
        public LeaderList()
        {
            InitializeComponent();
        }

        private void LeaderList_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnEditLeader_Click(object sender, EventArgs e)
        {
            editLeader();
        }

        public void editLeader()
        {
            string name = null, address = null, city = null, phone = null, cell = null, email = null, contactTime = null, contactHow = null, allergies = null, birthdate = null, age = null, helpWith = null, id = null;
            EditLeader editLeader = new EditLeader();
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM leaders WHERE ldr_id=@id", conn);
            cmd.Parameters.AddWithValue("@id", lstLeaders.SelectedItems[0].SubItems[12].Text);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name = reader["ldr_name"].ToString();
                address = reader["ldr_address"].ToString();
                city = reader["ldr_city"].ToString();
                phone = reader["ldr_phone"].ToString();
                cell = reader["ldr_cell"].ToString();
                email = reader["ldr_email"].ToString();
                contactTime = reader["ldr_contactTime"].ToString();
                contactHow = reader["ldr_contactHow"].ToString();
                allergies = reader["ldr_allergies"].ToString();
                age = reader["ldr_age"].ToString();
                birthdate = reader["ldr_birthdate"].ToString();
                helpWith = reader["ldr_helpWith"].ToString();
                id = reader["ldr_id"].ToString();
            }
            editLeader.Show();
            editLeader.txtName.Text = name;
            editLeader.txtAddress.Text = address;
            editLeader.txtCity.Text = city;
            editLeader.txtPhone.Text = phone;
            editLeader.txtCell.Text = cell;
            editLeader.txtEmail.Text = email;
            editLeader.txtContactTime.Text = contactTime;
            editLeader.txtContactHow.Text = contactHow;
            editLeader.txtAllergies.Text = allergies;
            editLeader.txtAge.Text = age;
            editLeader.birthdatePicker.Value = Convert.ToDateTime(birthdate);
            editLeader.cmbHelpWith.Text = helpWith;
            editLeader.lblId.Text = id;
        }

        private void btnDropLeader_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM leaders WHERE ldr_id=@id", conn);
            cmd.Parameters.AddWithValue("@id", lstLeaders.SelectedItems[0].SubItems[12].Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            loadForm();
        }
        public void loadForm()
        {
            lstLeaders.Items.Clear();
            lstLeaders.FullRowSelect = true;
            lstLeaders.GridLines = true;
            lstLeaders.Sorting = SortOrder.Ascending;
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM leaders", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["ldr_ID"].ToString();
                string name = reader["ldr_name"].ToString();
                string address = reader["ldr_address"].ToString();
                string city = reader["ldr_city"].ToString();
                string phone = reader["ldr_phone"].ToString();
                string cell = reader["ldr_cell"].ToString();
                string email = reader["ldr_email"].ToString();
                string contactTime = reader["ldr_contactTime"].ToString();
                string contactHow = reader["ldr_contactHow"].ToString();
                string allergies = reader["ldr_allergies"].ToString();
                string birthdate = Convert.ToDateTime(reader["ldr_birthdate"]).ToString("MM/dd/yyyy");
                string age = reader["ldr_age"].ToString();
                string helpWith = reader["ldr_helpWith"].ToString();
                string[] row = { name, address, city, phone, cell, email, contactTime, contactHow, allergies, birthdate, age, helpWith, id };
                var listViewItem = new ListViewItem(row);
                lstLeaders.Items.Add(listViewItem);

            }
            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
