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
    //clasa Form2 mosteneste clasa Form - MENIU (INSERT, UPDATE, DELETE, SEARCH)
    public partial class Form2 : Form
    {
        //constructor fara parametrii pentru clasa Form2
        public Form2()
        {
            InitializeComponent();//define, create, designe all the components of the form (Buttons)
        }

        //cream o variabila care contine numele serverului si numele bazei de date
        //string Conn = ("Data Source = WINDOWSDEPOZITU\\SQLEXPRESS;Initial Catalog = Sistem de rezervare bilete;Integrated Security = true");

        Form3 form3 = new Form3(); //INSERT
        Form7 form7 = new Form7(); //UPDATE
        Form11 form11 = new Form11(); //DELETE
        Form15 form15 = new Form15(); //SEARCH

        //sender provides a reference to the object that raised the event
        //e  passes an object specific to the event that is being handled
        private void button1_Click(object sender, EventArgs e)//INSERT (button1); An event handler is a method that is bound to an event. When the event is raised, the code within the event handler is executed.
        {
            form3.Show(); //apare form-ul 3 (CREATE AN ACCOUNT)
        }

        private void button2_Click(object sender, EventArgs e)//UPDATE
        {
            form7.Show(); //apare form-ul 7 UPDATE (CLIENTI, USERS, REDUCERI)
        }

        private void button3_Click(object sender, EventArgs e)//DELETE
        {
            form11.Show(); //apare form-ul 11 DELETE (CLIENTI, USERS, REDUCERI)
        }

        private void button4_Click(object sender, EventArgs e)//SEARCH
        {
            form15.Show(); //apare form-ul 15 SEARCH (INTEROGARI SIMPLE/COMPLEXE)
        }
    }
}

