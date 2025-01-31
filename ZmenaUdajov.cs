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
    public partial class ZmenaUdajov : Form
    {
        public ZmenaUdajov()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;

        private void ZmenaUdajov_Load(object sender, EventArgs e)
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

        private void zmenitUdaje_Click(object sender, EventArgs e)
        {
            MyUsers user1 = new MyUsers()
            {
                Username = usernameTBox.Text,
                Password = passTBox.Text,
                Gender = GenderCBox.Text,
                Fullname = nameTBox.Text,
                Number = NicTBox.Text
            };

            SetResponse set = client.Set(@"Users/" + usernameTBox.Text, user1);

            MessageBox.Show("Nové údaje boli úspešne nastavené.");
        }
    }
}
