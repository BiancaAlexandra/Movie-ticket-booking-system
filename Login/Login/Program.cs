using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Form1 - LOGIN/CREATE AN ACCOUNT
//Form2 - MENIU (INSERT, UPDATE, DELETE, SEARCH)
//Form3 - INSERT (CLIENTI, REDUCERI)
//Form4 - CREATE AN ACCOUNT
//Form5 - INSERT CLIENTI
//Form6 - INSERT REDUCERI
//Form7 - UPDATE (CLIENTI, USERS, REDUCERI)
//Form8 - UPDATE CLIENTI
//Form9 - UPDATE USERS
//Form10 - UPDATE REDUCERI
//Form11 - DELETE (CLIENTI, USERS, REDUCERI)
//Form12 - DELETE CLIENTI
//Form13 - DELETE USERS
//Form14 - DELETE REDUCERI
//Form15 - SEARCH (INTEROGARI SIMPLE/COMPLEXE)

namespace Login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //STAThreadAttribute = app with a single thread
        [STAThread]
        static void Main(string[] args)
        {
            //afisare in consola a mesajului
            Console.WriteLine("Start point of the application.");

            Application.EnableVisualStyles();   //EnableVisualStyles = to apply operating system styles to your application
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());   //Create an instance of the Form1 and run it
        }
    }
}
