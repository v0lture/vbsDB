using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace vbsDB
{
    public partial class AllergyList : Form
    {
        public AllergyList()
        {
            InitializeComponent();
        }

        private void AllergyList_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM students WHERE stu_allergies<>''", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstAllergies.Items.Add(reader["stu_name"].ToString() + ": " + reader["stu_allergies"].ToString());
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM leaders WHERE ldr_allergies<>''", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstAllergies.Items.Add(reader["ldr_name"].ToString() + ": " + reader["ldr_allergies"].ToString());
            }
            conn.Close();
        }
    }
}
