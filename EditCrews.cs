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
    public partial class EditCrews : Form
    {
        public EditCrews()
        {
            InitializeComponent();
        }

        private void EditCrews_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=1", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCrew1.Text = reader["crw_name"].ToString();
                txtColor1.Text = reader["crw_color"].ToString();
                txtBuddy1.Text = reader["crw_buddy"].ToString();
                txtDay1.Text = reader["crw_day"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=2", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCrew2.Text = reader["crw_name"].ToString();
                txtColor2.Text = reader["crw_color"].ToString();
                txtBuddy2.Text = reader["crw_buddy"].ToString();
                txtDay2.Text = reader["crw_day"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=3", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCrew3.Text = reader["crw_name"].ToString();
                txtColor3.Text = reader["crw_color"].ToString();
                txtBuddy3.Text = reader["crw_buddy"].ToString();
                txtDay3.Text = reader["crw_day"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=4", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCrew4.Text = reader["crw_name"].ToString();
                txtColor4.Text = reader["crw_color"].ToString();
                txtBuddy4.Text = reader["crw_buddy"].ToString();
                txtDay4.Text = reader["crw_day"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=5", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCrew5.Text = reader["crw_name"].ToString();
                txtColor5.Text = reader["crw_color"].ToString();
                txtBuddy5.Text = reader["crw_buddy"].ToString();
                txtDay5.Text = reader["crw_day"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=6", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtCrewPre.Text = reader["crw_name"].ToString();
                txtColorPre.Text = reader["crw_color"].ToString();
                txtBuddyPre.Text = reader["crw_buddy"].ToString();
                txtDayPre.Text = reader["crw_day"].ToString();
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //Update "loop"
            MySqlCommand cmd = new MySqlCommand("UPDATE crews SET crw_name= @name, crw_color= @color, crw_buddy= @buddy, crw_day= @day WHERE crw_ID=1", conn);
            cmd.Parameters.AddWithValue("@name", txtCrew1.Text);
            cmd.Parameters.AddWithValue("@color", txtColor1.Text);
            cmd.Parameters.AddWithValue("@buddy", txtBuddy1.Text);
            cmd.Parameters.AddWithValue("@day", txtDay1.Text);
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
            cmd = new MySqlCommand("UPDATE crews SET crw_name= @name, crw_color= @color, crw_buddy= @buddy, crw_day= @day WHERE crw_ID=2", conn);
            cmd.Parameters.AddWithValue("@name", txtCrew2.Text);
            cmd.Parameters.AddWithValue("@color", txtColor2.Text);
            cmd.Parameters.AddWithValue("@buddy", txtBuddy2.Text);
            cmd.Parameters.AddWithValue("@day", txtDay2.Text);
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
            cmd = new MySqlCommand("UPDATE crews SET crw_name= @name, crw_color= @color, crw_buddy= @buddy, crw_day= @day WHERE crw_ID=3", conn);
            cmd.Parameters.AddWithValue("@name", txtCrew3.Text);
            cmd.Parameters.AddWithValue("@color", txtColor3.Text);
            cmd.Parameters.AddWithValue("@buddy", txtBuddy3.Text);
            cmd.Parameters.AddWithValue("@day", txtDay3.Text);
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
            cmd = new MySqlCommand("UPDATE crews SET crw_name= @name, crw_color= @color, crw_buddy= @buddy, crw_day= @day WHERE crw_ID=4", conn);
            cmd.Parameters.AddWithValue("@name", txtCrew4.Text);
            cmd.Parameters.AddWithValue("@color", txtColor4.Text);
            cmd.Parameters.AddWithValue("@buddy", txtBuddy4.Text);
            cmd.Parameters.AddWithValue("@day", txtDay4.Text);
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
            cmd = new MySqlCommand("UPDATE crews SET crw_name= @name, crw_color= @color, crw_buddy= @buddy, crw_day= @day WHERE crw_ID=5", conn);
            cmd.Parameters.AddWithValue("@name", txtCrew5.Text);
            cmd.Parameters.AddWithValue("@color", txtColor5.Text);
            cmd.Parameters.AddWithValue("@buddy", txtBuddy5.Text);
            cmd.Parameters.AddWithValue("@day", txtDay5.Text);
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
            cmd = new MySqlCommand("UPDATE crews SET crw_name= @name, crw_color= @color, crw_buddy= @buddy, crw_day= @day WHERE crw_ID=6", conn);
            cmd.Parameters.AddWithValue("@name", txtCrewPre.Text);
            cmd.Parameters.AddWithValue("@color", txtColorPre.Text);
            cmd.Parameters.AddWithValue("@buddy", txtBuddyPre.Text);
            cmd.Parameters.AddWithValue("@day", txtDayPre.Text);
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
    }
}
