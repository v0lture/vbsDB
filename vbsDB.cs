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
    public partial class vbsDB : Form
    {
        public vbsDB()
        {
            InitializeComponent();
        }

        private void btnAllergies_Click(object sender, EventArgs e)
        {
            AllergyList allergyList = new AllergyList();
            allergyList.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void btnCrews_Click(object sender, EventArgs e)
        {
            Crews crews = new Crews();
            crews.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            studentList.Show();
        }

        private void btnLeaders_Click(object sender, EventArgs e)
        {
            LeaderList leaderList = new LeaderList();
            leaderList.Show();
        }

        private void addLeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLeader newLeader = new NewLeader();
            newLeader.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            newStudent.Show();
        }

        private void editCrewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCrews editCrews = new EditCrews();
            editCrews.Show();
        }

        private void mailingLabelsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MailingLabels mailingLabels = new MailingLabels();
            mailingLabels.Show();
        }

        private void newYearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewYear newYear = new NewYear();
            newYear.Show();
        }

        private void setUpDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;UID=vbsDB;PASSWORD=password";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vbsdb", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password";
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS students (stu_ID INT(255) NOT NULL AUTO_INCREMENT, stu_name VARCHAR(50), stu_parent VARCHAR(50), stu_address VARCHAR(50), stu_city VARCHAR(50), stu_phone VARCHAR(25), stu_cell VARCHAR(25), stu_email VARCHAR(50), stu_contactTime VARCHAR(100), stu_contactHow VARCHAR(50), stu_allergies VARCHAR(1000),  stu_birthdate DATE, stu_age VARCHAR(50), stu_groupWith VARCHAR(100), stu_crew VARCHAR(100), PRIMARY KEY (stu_id))", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS leaders (ldr_ID INT(255) NOT NULL AUTO_INCREMENT, ldr_name VARCHAR(50), ldr_address VARCHAR(50), ldr_city VARCHAR(50), ldr_phone VARCHAR(25), ldr_cell VARCHAR(25), ldr_email VARCHAR(50), ldr_contactTime VARCHAR(100), ldr_contactHow VARCHAR(50), ldr_allergies VARCHAR(1000),  ldr_birthdate DATE, ldr_age VARCHAR(50), ldr_helpWith VARCHAR(100), PRIMARY KEY (ldr_id))", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS crews (crw_ID INT(255) NOT NULL AUTO_INCREMENT, crw_name VARCHAR(50), crw_color VARCHAR(50), crw_buddy VARCHAR(50), crw_day INT(255), PRIMARY KEY (crw_id))", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd = new MySqlCommand("CREATE TABLE IF NOT EXISTS attendance (atn_ID INT(255), atn_name VARCHAR(50), atn_day1 BIT, atn_day2 BIT, atn_day3 BIT, atn_day4 BIT, atn_day5 BIT, PRIMARY KEY (atn_ID))", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Database setup is complete");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Database setup may be incomplete. Please fix error and try again");
            }
        }
    }
}
