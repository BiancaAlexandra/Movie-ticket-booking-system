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
    //clasa Form7 mosteneste clasa Form - UPDATE (CLIENTI, USERS, REDUCERI)
    public partial class Form7 : Form
    {
        Form8 form8 = new Form8(); //UPDATE CLIENTI
        Form9 form9 = new Form9(); //UPDATE USERS
        Form10 form10 = new Form10(); //UPDATE REDUCERI

        //constructor fara parametrii pentru clasa Form7
        public Form7()
        {
            InitializeComponent(); //define, create, designe all the components of the form
        }

        //sender provides a reference to the object that raised the event
        //e  passes an object specific to the event that is being handled
        private void button1_Click(object sender, EventArgs e)
        {
            form8.Show(); //apare form-ul 8 (UPDATE CLIENTI)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form9.Show(); //apare form-ul 9 (UPDATE USERS)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form10.Show(); //apare form-ul 10 (UPDATE REDUCERI)
        }
    }
}
