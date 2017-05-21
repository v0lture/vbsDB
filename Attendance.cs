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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=1", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                attendanceCrew1.Text = reader["crw_name"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=2", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                attendanceCrew2.Text = reader["crw_name"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=3", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                attendanceCrew3.Text = reader["crw_name"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=4", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                attendanceCrew4.Text = reader["crw_name"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=5", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                attendanceCrew5.Text = reader["crw_name"].ToString();
            }
            conn.Close();
            cmd = new MySqlCommand("SELECT * FROM crews WHERE crw_ID=6", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                attendancePreschool.Text = reader["crw_name"].ToString();
            }
            conn.Close();

            //**********************************************************************************************

            cmd = new MySqlCommand("SELECT * FROM students WHERE stu_crew=@crew", conn);
            cmd.Parameters.AddWithValue("@crew", attendanceCrew1.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string[] row = { id, name };
                grd1.Rows.Add(row);
            }
            conn.Close();

            foreach (DataGridViewRow row in grd1.Rows)
            {
                string id = row.Cells[grdID1.Name].Value.ToString();
                bool day1 = false, day2 = false, day3 = false, day4 = false, day5 = false;
                cmd = new MySqlCommand("SELECT * FROM attendance WHERE atn_name=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetOrdinal("atn_day1");
                    day1 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day2");
                    day2 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day3");
                    day3 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day4");
                    day4 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day5");
                    day5 = reader.GetBoolean(i);
                }
                row.Cells[grd1Day1.Name].Value = day1;
                row.Cells[grd1Day2.Name].Value = day2;
                row.Cells[grd1Day3.Name].Value = day3;
                row.Cells[grd1Day4.Name].Value = day4;
                row.Cells[grd1Day5.Name].Value = day5;
                conn.Close();
            }
            
            cmd = new MySqlCommand("SELECT * FROM students WHERE stu_crew=@crew", conn);
            cmd.Parameters.AddWithValue("@crew", attendanceCrew2.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string[] row = { id, name };
                grd2.Rows.Add(row);
            }
            conn.Close();

            foreach (DataGridViewRow row in grd2.Rows)
            {
                string id = row.Cells[grdID2.Name].Value.ToString();
                bool day1 = false, day2 = false, day3 = false, day4 = false, day5 = false;
                cmd = new MySqlCommand("SELECT * FROM attendance WHERE atn_name=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetOrdinal("atn_day1");
                    day1 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day2");
                    day2 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day3");
                    day3 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day4");
                    day4 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day5");
                    day5 = reader.GetBoolean(i);
                }
                row.Cells[grd2Day1.Name].Value = day1;
                row.Cells[grd2Day2.Name].Value = day2;
                row.Cells[grd2Day3.Name].Value = day3;
                row.Cells[grd2Day4.Name].Value = day4;
                row.Cells[grd2Day5.Name].Value = day5;
                conn.Close();
            }

            cmd = new MySqlCommand("SELECT * FROM students WHERE stu_crew=@crew", conn);
            cmd.Parameters.AddWithValue("@crew", attendanceCrew3.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string[] row = { id, name };
                grd3.Rows.Add(row);
            }
            conn.Close();

            foreach (DataGridViewRow row in grd3.Rows)
            {
                string id = row.Cells[grdID3.Name].Value.ToString();
                bool day1 = false, day2 = false, day3 = false, day4 = false, day5 = false;
                cmd = new MySqlCommand("SELECT * FROM attendance WHERE atn_name=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetOrdinal("atn_day1");
                    day1 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day2");
                    day2 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day3");
                    day3 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day4");
                    day4 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day5");
                    day5 = reader.GetBoolean(i);
                }
                row.Cells[grd3Day1.Name].Value = day1;
                row.Cells[grd3Day2.Name].Value = day2;
                row.Cells[grd3Day3.Name].Value = day3;
                row.Cells[grd3Day4.Name].Value = day4;
                row.Cells[grd3Day5.Name].Value = day5;
                conn.Close();
            }

            cmd = new MySqlCommand("SELECT * FROM students WHERE stu_crew=@crew", conn);
            cmd.Parameters.AddWithValue("@crew", attendanceCrew4.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string[] row = { id, name };
                grd4.Rows.Add(row);
            }
            conn.Close();

            foreach (DataGridViewRow row in grd4.Rows)
            {
                string id = row.Cells[grdID4.Name].Value.ToString();
                bool day1 = false, day2 = false, day3 = false, day4 = false, day5 = false;
                cmd = new MySqlCommand("SELECT * FROM attendance WHERE atn_name=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetOrdinal("atn_day1");
                    day1 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day2");
                    day2 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day3");
                    day3 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day4");
                    day4 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day5");
                    day5 = reader.GetBoolean(i);
                }
                row.Cells[grd4Day1.Name].Value = day1;
                row.Cells[grd4Day2.Name].Value = day2;
                row.Cells[grd4Day3.Name].Value = day3;
                row.Cells[grd4Day4.Name].Value = day4;
                row.Cells[grd4Day5.Name].Value = day5;
                conn.Close();
            }

            cmd = new MySqlCommand("SELECT * FROM students WHERE stu_crew=@crew", conn);
            cmd.Parameters.AddWithValue("@crew", attendanceCrew5.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string[] row = { id, name };
                grd5.Rows.Add(row);
            }
            conn.Close();

            foreach (DataGridViewRow row in grd5.Rows)
            {
                string id = row.Cells[grdID5.Name].Value.ToString();
                bool day1 = false, day2 = false, day3 = false, day4 = false, day5 = false;
                cmd = new MySqlCommand("SELECT * FROM attendance WHERE atn_name=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetOrdinal("atn_day1");
                    day1 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day2");
                    day2 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day3");
                    day3 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day4");
                    day4 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day5");
                    day5 = reader.GetBoolean(i);
                }
                row.Cells[grd5Day1.Name].Value = day1;
                row.Cells[grd5Day2.Name].Value = day2;
                row.Cells[grd5Day3.Name].Value = day3;
                row.Cells[grd5Day4.Name].Value = day4;
                row.Cells[grd5Day5.Name].Value = day5;
                conn.Close();
            }

            cmd = new MySqlCommand("SELECT * FROM students WHERE stu_crew=@crew", conn);
            cmd.Parameters.AddWithValue("@crew", attendancePreschool.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["stu_ID"].ToString();
                string name = reader["stu_name"].ToString();
                string[] row = { id, name };
                grdPre.Rows.Add(row);
            }
            conn.Close();

            foreach (DataGridViewRow row in grdPre.Rows)
            {
                string id = row.Cells[grdIDPre.Name].Value.ToString();
                bool day1 = false, day2 = false, day3 = false, day4 = false, day5 = false;
                cmd = new MySqlCommand("SELECT * FROM attendance WHERE atn_name=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetOrdinal("atn_day1");
                    day1 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day2");
                    day2 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day3");
                    day3 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day4");
                    day4 = reader.GetBoolean(i);
                    i = reader.GetOrdinal("atn_day5");
                    day5 = reader.GetBoolean(i);
                }
                row.Cells[grdPreDay1.Name].Value = day1;
                row.Cells[grdPreDay2.Name].Value = day2;
                row.Cells[grdPreDay3.Name].Value = day3;
                row.Cells[grdPreDay4.Name].Value = day4;
                row.Cells[grdPreDay5.Name].Value = day5;
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "SERVER=localhost;DATABASE=vbsdb;UID=vbsDB;PASSWORD=password;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("", conn);
                foreach (DataGridViewRow row in grd1.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE atn_name=@id", conn);
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID1.Name].Value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count >= 1)
                    {
                        cmd = new MySqlCommand("UPDATE attendance SET atn_day1=@day1, atn_day2=@day2, atn_day3=@day3, atn_day4=@day4, atn_day5=@day5 WHERE atn_name=@id", conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO attendance (atn_name, atn_day1, atn_day2, atn_day3, atn_day4, atn_day5) VALUES (@id, @day1, @day2, @day3, @day4, @day5)", conn);
                    }
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID1.Name].Value);
                    cmd.Parameters.AddWithValue("@day1", row.Cells[grd1Day1.Name].Value);
                    cmd.Parameters.AddWithValue("@day2", row.Cells[grd1Day2.Name].Value);
                    cmd.Parameters.AddWithValue("@day3", row.Cells[grd1Day3.Name].Value);
                    cmd.Parameters.AddWithValue("@day4", row.Cells[grd1Day4.Name].Value);
                    cmd.Parameters.AddWithValue("@day5", row.Cells[grd1Day5.Name].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                foreach (DataGridViewRow row in grd2.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE atn_name=@id", conn);
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID2.Name].Value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count >= 1)
                    {
                        cmd = new MySqlCommand("UPDATE attendance SET atn_day1=@day1, atn_day2=@day2, atn_day3=@day3, atn_day4=@day4, atn_day5=@day5 WHERE atn_name=@id", conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO attendance (atn_name, atn_day1, atn_day2, atn_day3, atn_day4, atn_day5) VALUES (@id, @day1, @day2, @day3, @day4, @day5)", conn);
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID2.Name].Value);
                    cmd.Parameters.AddWithValue("@day1", row.Cells[grd2Day1.Name].Value);
                    cmd.Parameters.AddWithValue("@day2", row.Cells[grd2Day2.Name].Value);
                    cmd.Parameters.AddWithValue("@day3", row.Cells[grd2Day3.Name].Value);
                    cmd.Parameters.AddWithValue("@day4", row.Cells[grd2Day4.Name].Value);
                    cmd.Parameters.AddWithValue("@day5", row.Cells[grd2Day5.Name].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                foreach (DataGridViewRow row in grd3.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE atn_name=@id", conn);
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID3.Name].Value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count >= 1)
                    {
                        cmd = new MySqlCommand("UPDATE attendance SET atn_day1=@day1, atn_day2=@day2, atn_day3=@day3, atn_day4=@day4, atn_day5=@day5 WHERE atn_name=@id", conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO attendance (atn_name, atn_day1, atn_day2, atn_day3, atn_day4, atn_day5) VALUES (@id, @day1, @day2, @day3, @day4, @day5)", conn);
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID3.Name].Value);
                    cmd.Parameters.AddWithValue("@day1", row.Cells[grd3Day1.Name].Value);
                    cmd.Parameters.AddWithValue("@day2", row.Cells[grd3Day2.Name].Value);
                    cmd.Parameters.AddWithValue("@day3", row.Cells[grd3Day3.Name].Value);
                    cmd.Parameters.AddWithValue("@day4", row.Cells[grd3Day4.Name].Value);
                    cmd.Parameters.AddWithValue("@day5", row.Cells[grd3Day5.Name].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                foreach (DataGridViewRow row in grd4.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE atn_name=@id", conn);
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID4.Name].Value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count >= 1)
                    {
                        cmd = new MySqlCommand("UPDATE attendance SET atn_day1=@day1, atn_day2=@day2, atn_day3=@day3, atn_day4=@day4, atn_day5=@day5 WHERE atn_name=@id", conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO attendance (atn_name, atn_day1, atn_day2, atn_day3, atn_day4, atn_day5) VALUES (@id, @day1, @day2, @day3, @day4, @day5)", conn);
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID4.Name].Value);
                    cmd.Parameters.AddWithValue("@day1", row.Cells[grd4Day1.Name].Value);
                    cmd.Parameters.AddWithValue("@day2", row.Cells[grd4Day2.Name].Value);
                    cmd.Parameters.AddWithValue("@day3", row.Cells[grd4Day3.Name].Value);
                    cmd.Parameters.AddWithValue("@day4", row.Cells[grd4Day4.Name].Value);
                    cmd.Parameters.AddWithValue("@day5", row.Cells[grd4Day5.Name].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                foreach (DataGridViewRow row in grd5.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE atn_name=@id", conn);
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID5.Name].Value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count >= 1)
                    {
                        cmd = new MySqlCommand("UPDATE attendance SET atn_day1=@day1, atn_day2=@day2, atn_day3=@day3, atn_day4=@day4, atn_day5=@day5 WHERE atn_name=@id", conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO attendance (atn_name, atn_day1, atn_day2, atn_day3, atn_day4, atn_day5) VALUES (@id, @day1, @day2, @day3, @day4, @day5)", conn);
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdID5.Name].Value);
                    cmd.Parameters.AddWithValue("@day1", row.Cells[grd5Day1.Name].Value);
                    cmd.Parameters.AddWithValue("@day2", row.Cells[grd5Day2.Name].Value);
                    cmd.Parameters.AddWithValue("@day3", row.Cells[grd5Day3.Name].Value);
                    cmd.Parameters.AddWithValue("@day4", row.Cells[grd5Day4.Name].Value);
                    cmd.Parameters.AddWithValue("@day5", row.Cells[grd5Day5.Name].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                foreach (DataGridViewRow row in grdPre.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd = new MySqlCommand("SELECT COUNT(*) FROM attendance WHERE atn_name=@id", conn);
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdIDPre.Name].Value);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count >= 1)
                    {
                        cmd = new MySqlCommand("UPDATE attendance SET atn_day1=@day1, atn_day2=@day2, atn_day3=@day3, atn_day4=@day4, atn_day5=@day5 WHERE atn_name=@id", conn);
                    }
                    else
                    {
                        cmd = new MySqlCommand("INSERT INTO attendance (atn_name, atn_day1, atn_day2, atn_day3, atn_day4, atn_day5) VALUES (@id, @day1, @day2, @day3, @day4, @day5)", conn);
                    }
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", row.Cells[grdIDPre.Name].Value);
                    cmd.Parameters.AddWithValue("@day1", row.Cells[grdPreDay1.Name].Value);
                    cmd.Parameters.AddWithValue("@day2", row.Cells[grdPreDay2.Name].Value);
                    cmd.Parameters.AddWithValue("@day3", row.Cells[grdPreDay3.Name].Value);
                    cmd.Parameters.AddWithValue("@day4", row.Cells[grdPreDay4.Name].Value);
                    cmd.Parameters.AddWithValue("@day5", row.Cells[grdPreDay5.Name].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Save successful");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error saving");
            }
        }

    }
}
