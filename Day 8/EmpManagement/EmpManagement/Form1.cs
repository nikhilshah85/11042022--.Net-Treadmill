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
namespace EmpManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataView _empView;
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder sqlCommandBuilder;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=tcp:p2project.database.windows.net,1433;Initial Catalog=toptypersDB;Persist Security Info=False;User ID=project2;Password=Password@4567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            adapter  = new SqlDataAdapter("select * from employeedetails", conn);
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();

            adapter.Fill(ds);
            _empView = ds.Tables[0].DefaultView;

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mumbai");
            comboBox1.Items.Add("Pune");
            comboBox1.Items.Add("Chennai");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _empView.RowFilter = "empName like '%" + textBox1.Text + "%'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _empView.RowFilter = "empCity='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Tables[0].WriteXml("employeedetails.xml");
            MessageBox.Show("Details Saved to XML File");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adapter.Update(ds);
            MessageBox.Show("Database Updated Successfully");
        }
    }
}
