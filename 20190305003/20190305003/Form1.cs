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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=DESKTOP-46D1KHQ\SQLEXPRESS02;Initial Catalog=hosp;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from signup where identify=@identify and password=@password", conn);
                    cmd.Parameters.AddWithValue("identify", textBox1.Text);
                    cmd.Parameters.AddWithValue("password", textBox2.Text);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Form3 frm = new Form3();
                        frm.Show();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Identify Num or Password incorrect");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
            }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
