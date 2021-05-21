using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MQHULP0G;Initial Catalog=master;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into tbl_insertion(id,name,age,gender,address,contactnumber) VALUES ('" + textBox6.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted successfully!!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from tbl_insertion";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from tbl_insertion where id= '1'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Deleted successfully!!!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
