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
    //clasa Form3 mosteneste clasa Form - INSERT (CLIENTI, REDUCERI)
    public partial class Form3 : Form
    {
        Form5 form5 = new Form5(); //INSERT CLIENTI
        Form6 form6 = new Form6(); //INSERT REDUCERI

        //constructor fara parametrii pentru clasa Form3
        public Form3()
        {
            InitializeComponent();//define, create, designe all the components of the form
        }

        //sender provides a reference to the object that raised the event
        //e  passes an object specific to the event that is being handled
        private void button1_Click(object sender, EventArgs e) //INSERT CLIENTI (button1); An event handler is a method that is bound to an event. When the event is raised, the code within the event handler is executed.
        {
            form5.Show(); //apare form-ul 5 INSERT CLIENTI
        }

        private void button2_Click(object sender, EventArgs e) //INSERT REDUCERI
        {
            form6.Show(); //apare form-ul 6 INSERT REDUCERI
        }
    }
}
