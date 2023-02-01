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
    //clasa Form1 mosteneste clasa Form - LOGIN / CREATE AN ACCOUNT
    public partial class Form1 : Form
    {
        //cream o variabila care contine numele serverului si numele bazei de date
        //string Conn = ("Data Source = WINDOWSDEPOZITU\\SQLEXPRESS;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");
        string Conn = ("Data Source = DESKTOP-7CO9K5K;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");

        Form2 form2 = new Form2();  //MENIU (INSERT, UPDATE, DELETE, SEARCH)
        Form4 form4 = new Form4();  //CREATE AN ACCOUNT

        //constructor fara parametrii pentru clasa Form1
        public Form1()
        {
            InitializeComponent();  //define, create, designe all the components of the form (Labels, Buttons and TextBoxes)
        }

        //sender provides a reference to the object that raised the event
        //e  passes an object specific to the event that is being handled
        private void button1_Click(object sender, EventArgs e)  //login (button1); An event handler is a method that is bound to an event. When the event is raised, the code within the event handler is executed.
        {
            try
            {
                if(txtUname.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("Please enter your User Name and Password");
                }
                else
                {
                    //conexiunea este posibila
                    SqlConnection con = new SqlConnection(Conn);
                    //comanda pe care o transmit
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @UserName and Password = @UserPass", con);

                    //transmitem parametrii
                    cmd.Parameters.AddWithValue("@UserName", txtUname.Text);
                    cmd.Parameters.AddWithValue("@UserPass", txtPass.Text);


                    //deschidem conexiunea
                    con.Open();
                    //adpt is like a bridge between a DataSet and data from the database to retrive data
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);  
                    DataSet ds = new DataSet();
                    //introducem obiectul ds in adpt - the dataset will storage the data from the database
                    adpt.Fill(ds);
                    //inchidem conexiunea
                    con.Close();


                    //we count how many rows has the dataset retrived from the database
                    int count = ds.Tables[0].Rows.Count;

                    //daca s-a gasit o inregistrare identica cu datele introduse => user-ul este prezent in baza de date
                    if(count == 1)
                    {
                        MessageBox.Show("Succesfully login");
                        this.Hide(); //se ascunde fereastra cu mesajul "Succesfully login"
                        form2.Show(); //si apare form-ul 2 (Meniu)
                    }
                    else //daca nu exista o inregistrare corespunzatoare datelor introduse => user neinregistrat
                    {
                        MessageBox.Show("Invalid User Name or Password");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Create an account (button2); An event handler is a method that is bound to an event. When the event is raised, the code within the event handler is executed.
        {
            form4.Show();   //si apare form-ul 4 (CREATE AN ACCOUNT)
        }
    }
}
