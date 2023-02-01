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
    //clasa Form5 mosteneste clasa Form - INSERT CLIENTI
    public partial class Form5 : Form
    {
        //cream o variabila care contine numele serverului si numele bazei de date
        //string Conn = ("Data Source = WINDOWSDEPOZITU\\SQLEXPRESS;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");
        string Conn = ("Data Source = DESKTOP-7CO9K5K;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");

        public Form5()
        {
            InitializeComponent();  //define, create, designe all the components of the form
            //conexiunea este posibila
            SqlConnection con1 = new SqlConnection(Conn);

            //deschidem conexiunea
            con1.Open();
            //comanda pe care o transmit
            SqlCommand cmd1 = new SqlCommand("select * from Clienti", con1);

            SqlDataAdapter da2 = new SqlDataAdapter(cmd1); //da2 is like a bridge between a DataTable and data from the database to retrive data
            DataTable dtbl2 = new DataTable();
            //introducem obiectul dtbl2 in da2 - the dataset will storage the data from the database
            da2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2; //afisez setul de date intr-un element de tip GridView
            //inchidem conexiunea
            con1.Close();
        }

        //sender provides a reference to the object that raised the event
        //e  passes an object specific to the event that is being handled
        private void button1_Click(object sender, EventArgs e)
        {
            
            //conexiunea este posibila
            SqlConnection con = new SqlConnection(Conn);

            //conexiunea este posibila
            con.Open();
            //comanda pe care o transmit
            SqlCommand cmd = new SqlCommand("INSERT INTO Clienti (Nume,Prenume,email,telefon,data_nasterii) VALUES (@Nume,@Prenume,@email,@telefon,@data_nasterii)", con);
            
            //transmitem parametrii
            cmd.Parameters.AddWithValue("@Nume", textBox1.Text);
            cmd.Parameters.AddWithValue("@Prenume", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox4.Text);
            cmd.Parameters.AddWithValue("@data_nasterii", textBox5.Text);

            cmd.ExecuteNonQuery(); //execute the sqlStatement
            
            MessageBox.Show("Succesfully insert");

            //comanda pe care o transmit
            SqlCommand cmd2 = new SqlCommand("select * from Clienti", con);

            //da1 is like a bridge between a DataTable and data from the database to retrive data
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            DataTable dtbl1 = new DataTable();
            //introducem obiectul dtbl1 in da1 - the dataset will storage the data from the database
            da1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1; //afisez setul de date intr-un element de tip GridView
            //inchidem conexiunea
            con.Close();
        }
    }
}
