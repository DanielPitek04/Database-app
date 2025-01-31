using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace EdutageApp
{
    public partial class OdstranenieUctu : Form
    {
        public OdstranenieUctu()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;

        private void OdstranenieUctu_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(databaza);
            }
            catch
            {
                MessageBox.Show("Nastala v niečom chyba");
            }
        }

        private void účetDELETE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WARNING: Naozaj chcete vymazať tento účet?");
            FirebaseResponse set = client.Delete(@"Users/" + usernameTBox.Text);
            MessageBox.Show("Odstránený/á z databázy.");
        }
    }
}
