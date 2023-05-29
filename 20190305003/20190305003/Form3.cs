using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _20190305003
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=DESKTOP-46D1KHQ\SQLEXPRESS02;Initial Catalog=hosp;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query = @"INSERT INTO [dbo].[appointment](identify, doctors, clinics, date) values(@identify, @doctors, @clinics, @date)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@identify", textBox1.Text);
                    cmd.Parameters.AddWithValue("@doctors", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@clinics", comboBox2.SelectedItem);
                    cmd.Parameters.AddWithValue("@date", monthCalendar1.SelectionRange.Start);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your registration has been successfully created.");
                    textBox1.Clear();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


    }
}
