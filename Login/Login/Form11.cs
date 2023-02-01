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
    //clasa Form11 mosteneste clasa Form - DELETE (CLIENTI, USERS, REDUCERI)
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent(); //define, create, designe all the components of the form
        }

        Form12 form12 = new Form12(); //DELETE CLIENTI
        Form13 form13 = new Form13(); //DELETE USERS
        Form14 form14 = new Form14(); //DELETE REDUCERI

        private void button1_Click(object sender, EventArgs e)
        {
            form12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form13.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form14.Show();
        }
    }
}
