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
    public partial class AddUcet : Form
    {
        public AddUcet()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;
        private void AddUcitel_Load(object sender, EventArgs e)
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

        private void pridaťUCITEL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameUCITEL.Text) ||
               string.IsNullOrWhiteSpace(passwordUCITEL.Text) ||
               string.IsNullOrWhiteSpace(genderUCITEL.Text) ||
               string.IsNullOrWhiteSpace(FullNameUCITEL.Text) ||
               string.IsNullOrWhiteSpace(numberUCITEL.Text))
            {
                MessageBox.Show("Prosíme Vás o vyplnenie údajov");
            }


            else
            {
                doktorUcet userQ = new doktorUcet()
                {
                    Username1 = usernameUCITEL.Text,
                    Password1 = passwordUCITEL.Text,
                    Gender1 = genderUCITEL.Text,
                    Fullname1 = FullNameUCITEL.Text,
                    Number1 = numberUCITEL.Text
                };

                SetResponse set = client.Set(@"Users/" + usernameUCITEL.Text, userQ);

                MessageBox.Show("Doktor bol nahodený do systému");
            }
        }

        private void pridatAdmina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adminmenoTX.Text) ||
               string.IsNullOrWhiteSpace(adminhesloTX.Text) ||
               string.IsNullOrWhiteSpace(adminpohlavieTX.Text) ||
               string.IsNullOrWhiteSpace(admincelemenoTX.Text) ||
               string.IsNullOrWhiteSpace(adminnumberTX.Text))
            {
                MessageBox.Show("Prosíme Vás o vyplnenie údajov");
            }


            else
            {
                adminUcet userGG = new adminUcet()
                {
                    Username2 = adminmenoTX.Text,
                    Password2 = adminhesloTX.Text,
                    Gender2 = adminpohlavieTX.Text,
                    Fullname2 = admincelemenoTX.Text,
                    Number2 = adminnumberTX.Text
                };

                SetResponse set = client.Set(@"Users/" + adminmenoTX.Text, userGG);
                MessageBox.Show("NAHADZUJETE NEBEZPECNE PRAVA! STALE AVSAK MOZETE UCET VYMAZAT V PRIPADE POTREBY.");
                MessageBox.Show("Admin bol nahodený do systému");
            }
        }
    }
}
