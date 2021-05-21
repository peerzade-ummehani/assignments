using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehical
{
    public partial class Form1 : Form
    {
        List<vehicle> lstvehicle = new List<vehicle>();
            private int year = 2020;
        vehicle objvehicle = new vehicle();

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void Pagevehicle_Click(object sender, EventArgs e)
        {
            DataColumn enginenumber = new DataColumn("enginenumber", typeof(string));
            dt.Columns.Add(enginenumber);
            DataColumn chessisnumber = new DataColumn("chessisnumber", typeof(string));
            dt.Columns.Add(chessisnumber);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            grdvehicle.DataSource = null;
            //lstvehicle.Add(objvehicle);
            grdvehicle.Refresh();
            grdvehicle.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdvehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {




                objvehicle.chessisnumber = txtchessisnumber.Text;
                objvehicle.enginenumber = txtchessisnumber.Text;
                objvehicle.make = txtmake.Text;
                objvehicle.model = txtmodel.Text;
                int.TryParse(txtyear.Text, out year);
                txtyear.Text = year.ToString();

                DataRow row = dt.NewRow();
                row["chessisnumber"] = txtchessisnumber.Text;
                row["enginenumber"] = txtenginenumber.Text;
                dt.Rows.Add(row);


                MessageBox.Show("row added in table");
                txtchessisnumber.Text = string.Empty;
                txtenginenumber.Text = string.Empty;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
