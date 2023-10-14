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
    public partial class Form2 : Form
    {
        SqlConnection Mycon2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Acer\Documents\Ticket Reserve.mdf';Integrated Security = True; Connect Timeout = 30");

        public Form2(string id)
        {
            
            InitializeComponent();
            fillcombo();
            ID.Text = id;
        }
        //Tichet_no,T_name,Show_date,Seat_no,St_time,M_name,D_name,Price
        void fillcombo()
        {
            string query = "select Tichet_no from Ticket where fk_C_id is NULL";
            SqlCommand mycmd = new SqlCommand(query, Mycon2);
            SqlDataReader Myread;
            try
            {
                Mycon2.Open();
                Myread = mycmd.ExecuteReader();
                while (Myread.Read())
                {

                    string temp = Myread["Tichet_no"].ToString();
                    comboBox1.Items.Add(temp    );
          
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (Mycon2.State == ConnectionState.Open)
                    Mycon2.Close();
            }
           


        }
        private void reserve_Click(object sender, EventArgs e)
        {

            try {
                if (ID.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Please Fill out the Feilds!!!");
                }
                else
                {
                    string query = "update Ticket" +
                        " set fk_C_id=" + ID.Text + ",Booking_data='" + DateTime.Today.ToString("MM/dd/yyyy") +
                        "' where Tichet_no= " + comboBox1.Text;
                    SqlCommand mycmd2 = new SqlCommand(query, Mycon2);
                    Mycon2.Open();
                    mycmd2.CommandType = CommandType.Text;
                    mycmd2.ExecuteNonQuery();
                    MessageBox.Show("You Have a successfull Reserve!!");
                }
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                if (Mycon2.State == ConnectionState.Open)
                    Mycon2.Close();
                comboBox1.Items.Remove(comboBox1.Text);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          string query = " select Tichet_no,Price,Show_date,St_time,Hall_no,Seat_no,T_name,M_name" +
                          " from myview5" +
                          " where Tichet_no=" + comboBox1.Text +
                         " union" +
                         " select Tichet_no,Price, Show_date, St_time, Hall_no, Seat_no, T_name, D_name" +
                         " from myview6" +
                           " where Tichet_no=" + comboBox1.Text;

                         
            SqlCommand mycmd = new SqlCommand(query, Mycon2);
            SqlDataReader Myread;
            try
            {
                Mycon2.Open();
                Myread = mycmd.ExecuteReader();
                while (Myread.Read())
                {

                    label7.Text = Myread["Price"].ToString();
                    label4.Text = Myread["Show_date"].ToString();
                    label13.Text = Myread["St_time"].ToString();
                    label9.Text = Myread["Hall_no"].ToString();
                    label5.Text = Myread["Seat_no"].ToString();
                    label11.Text = Myread["T_name"].ToString();
                    label15.Text = Myread["M_name"].ToString();


                }

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            finally
            {
                if (Mycon2.State == ConnectionState.Open)
                    Mycon2.Close();
            }

        }

            private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
