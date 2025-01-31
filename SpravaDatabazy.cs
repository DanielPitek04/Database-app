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
    public partial class SpravaDatabazy : Form
    {
        public SpravaDatabazy()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;

        private void nadpisReg_Click(object sender, EventArgs e)
        {

        }

        private void SpravaProjektov_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prepínam do registračného poľa");
            Visible = false;
            Registration rr = new Registration();
            rr.ShowDialog();
            Visible = true;
        }
    }
}
