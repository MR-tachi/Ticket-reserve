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
using System.Globalization;

namespace conection_database
{
    public partial class Form1 : Form
    {
        SqlConnection Mycon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Acer\Documents\Ticket Reserve.mdf';Integrated Security = True; Connect Timeout = 30");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            try
            {


                if (FLName.Text == "" || ID.Text == "")
                    MessageBox.Show("Please fill out the fields!!");
                else
                {
                    SqlCommand insert = new SqlCommand("insert into Customer(C_id,C_name,Email_id) values(" +
                                                     ID.Text + ",' " + FLName.Text +
                                                     " ',' " + Email.Text + "')"
                                                     , Mycon);
                    Mycon.Open();

                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                    MessageBox.Show("You have been added!!\nPRESS Next Button to reserve.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Mycon.State == ConnectionState.Open)
                    Mycon.Close();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(ID.Text);
            f2.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rmore_Click(object sender, EventArgs e)
        {




        }
    }
}

