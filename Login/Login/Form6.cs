using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ne conectam la baza de date
using System.Data.SqlClient;

namespace Login
{
    //clasa Form6 mosteneste clasa Form - INSERT REDUCERI
    public partial class Form6 : Form
    {
        //cream o variabila care contine numele serverului si numele bazei de date
        //string Conn = ("Data Source = WINDOWSDEPOZITU\\SQLEXPRESS;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");
        string Conn = ("Data Source = DESKTOP-7CO9K5K;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");

        public Form6()
        {
            InitializeComponent();//define, create, designe all the components of the form

            //conexiunea este posibila
            SqlConnection con1 = new SqlConnection(Conn);

            //deschidem conexiunea
            con1.Open();
            //comanda pe care o transmit
            SqlCommand cmd1 = new SqlCommand("select * from Reduceri", con1);

            //da2 is like a bridge between a DataSet and data from the database to retrive data
            SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
            DataTable dtbl2 = new DataTable();
            //introducem obiectul dtbl2 in da2 - the dataset will storage the data from the database
            da2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2;
            //inchidem conexiunea
            con1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conexiunea este posibila
            SqlConnection con = new SqlConnection(Conn);

            //deschidem conexiunea
            con.Open();

            //comanda pe care o transmit
            SqlCommand cmd = new SqlCommand("INSERT INTO Reduceri (Tip_reducere,Perioada,Procent_reducere,Valabila) VALUES (@Tip_reducere,@Perioada,@Procent_reducere,@Valabila)", con);
            
            //transmitem parametrii
            cmd.Parameters.AddWithValue("@Tip_reducere", textBox1.Text);
            cmd.Parameters.AddWithValue("@Perioada", textBox2.Text);
            cmd.Parameters.AddWithValue("@Procent_reducere", textBox3.Text);
            cmd.Parameters.AddWithValue("@Valabila", comboBox1.SelectedItem.ToString());
            
            cmd.ExecuteNonQuery(); //execute the sqlStatement
            
            MessageBox.Show("Succesfully insert");

            SqlCommand cmd2 = new SqlCommand("select * from Reduceri", con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            DataTable dtbl1 = new DataTable();
            da1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
            //inchidem conexiunea
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
