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
    public partial class edutageLogin : Form
    {
        public edutageLogin()
        {
            InitializeComponent();
        }

        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;

        private void edutageLogin_Load(object sender, EventArgs e)
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

        private void registerr_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration reg = new Registration();
            reg.ShowDialog();
            this.Visible = true;
        }

        private void login_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Users/" + usernameTBox.Text);
            MyUsers ResUser = res.ResultAs<MyUsers>();
            doktorUcet ResUser1 = res.ResultAs<doktorUcet>();
            adminUcet ResUser2 = res.ResultAs<adminUcet>();

            MyUsers CurUser = new MyUsers()
            {
                Username = usernameTBox.Text,
                Password = passTBox.Text,
            };
            doktorUcet CurUser1 = new doktorUcet()
            {
                Username1 = usernameTBox.Text,
                Password1 = passTBox.Text,
            };
            adminUcet CurUser2 = new adminUcet()
            {
                Username2 = usernameTBox.Text,
                Password2 = passTBox.Text,
            };


            if (MyUsers.IsEqual(ResUser, CurUser))
            {
                this.Visible = false;
                edutageApp real = new edutageApp();
                real.ShowDialog();
                this.Visible = true;

            }
            else if (doktorUcet.IsEqual(ResUser1, CurUser1))
            {
                this.Visible = false;
                Doktor real1 = new Doktor();
                real1.ShowDialog();
                this.Visible = true;

            }
            else if (adminUcet.IsEqual(ResUser2, CurUser2))
            {
                this.Visible = false;
                Admin real3 = new Admin();
                real3.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MyUsers.UkazChybu();
            }

        }

        private void hesloOdkryt_Click(object sender, EventArgs e)
        {
            if (passTBox.PasswordChar == '\0')
            {
                hesloSchovat.BringToFront();
                passTBox.PasswordChar = '*';
            }
        }

        private void hesloSchovat_Click(object sender, EventArgs e)
        {
            if(passTBox.PasswordChar == '*')
            {
                hesloOdkryt.BringToFront();
                passTBox.PasswordChar = '\0';
            }
        }
    }
}
