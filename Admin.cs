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
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;

namespace EdutageApp
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;
        private List<data> dataList;

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(databaza);
            }
            catch
            {
                MessageBox.Show("Nastala v niečom chyba");
            }

            string jsonFilePath = "trala.json";

            string jsonData = File.ReadAllText(jsonFilePath);

            dataList = JsonConvert.DeserializeObject<List<data>>(JObject.Parse(jsonData)["data"].ToString());

            dataGridView1.Columns.Add("meno", "meno");
            dataGridView1.Columns.Add("adresa", "adresa");
            dataGridView1.Columns.Add("smerCislo", "smerCislo");
            foreach (data data in dataList)
            {
                dataGridView1.Rows.Add(data.mesto, data.adresa, data.smerCislo);
            }
        }

        private void menitUdaje_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ZmenaUdajov zmena = new ZmenaUdajov();
            zmena.ShowDialog();
            this.Visible = true;
        }

        private void spravaProjektov_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SpravaDatabazy spravaa = new SpravaDatabazy();
            spravaa.ShowDialog();
            this.Visible = true;
        }

        private void odstranitRolu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OdstranenieUctu odstranit = new OdstranenieUctu();
            odstranit.ShowDialog();
            this.Visible = true;
        }

        private void pridatUcitela_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddUcet ucitel = new AddUcet();
            ucitel.ShowDialog();
            this.Visible = true;
        }

        private void hladanieStudentov_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            string mesto = txtMesto.Text;
            string adresa = txtAdresa.Text;
            string smerCislo = txtSmerCislo.Text;

            
            dataGridView1.Rows.Add(mesto, adresa, smerCislo);

    
            txtMesto.Text = "";
            txtAdresa.Text = "";
            txtSmerCislo.Text = "";
        }
    }
}
