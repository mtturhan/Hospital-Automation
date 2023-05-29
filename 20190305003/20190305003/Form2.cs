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
using System.Xml.Linq;

namespace _20190305003
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-46D1KHQ\SQLEXPRESS02;Initial Catalog=hosp;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = @"Data Source=DESKTOP-46D1KHQ\SQLEXPRESS02;Initial Catalog=hosp;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();




            string query = @"INSERT INTO [dbo].[signup]
                ( [name], [surname], [phone], [gender], [birthdate], [identify], [password]) 
                Values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem + "','" + dateTimePicker1.Value + "','"+textBox4.Text+"','"+textBox5.Text+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("SignUp Successful");
            conn.Close();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
