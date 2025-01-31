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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;
        private void Registration_Load(object sender, EventArgs e)
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

        private void register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTBox.Text) ||
               string.IsNullOrWhiteSpace(passTBox.Text) ||
               string.IsNullOrWhiteSpace(GenderCBox.Text) ||
               string.IsNullOrWhiteSpace(nameTBox.Text) ||
               string.IsNullOrWhiteSpace(poCovide.Text) ||
               string.IsNullOrWhiteSpace(NicTBox.Text))
            {
                MessageBox.Show("Prosíme Vás o vyplnenie údajov");
            }


            else
            {
                MyUsers user1 = new MyUsers()
                {
                    Username = usernameTBox.Text,
                    Password = passTBox.Text,
                    Gender = GenderCBox.Text,
                    Fullname = nameTBox.Text,
                    PoCovide = poCovide.Text,
                    Number = NicTBox.Text
                };

                SetResponse set = client.Set(@"Users/" + usernameTBox.Text, user1);

                MessageBox.Show("Boli ste registrovaný a nahodený do systému.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUcet test = new AddUcet();
            test.ShowDialog();
        }
    }
}
