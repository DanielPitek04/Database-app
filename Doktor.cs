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
    public partial class Doktor : Form
    {
        public Doktor()
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

        private void hladat_Click(object sender, EventArgs e)
        {

        }

        private void Ucitel_Load(object sender, EventArgs e)
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

            dataGridView1.Columns.Add("mesto", "mesto");
            dataGridView1.Columns.Add("adresa", "adresa");
            dataGridView1.Columns.Add("smerCislo", "smerCislo");
            foreach (data data in dataList)
            {
                dataGridView1.Rows.Add(data.mesto, data.adresa, data.smerCislo);
            }

        }

        private void zmenitUdajee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ZmenaUdajov zmena1 = new ZmenaUdajov();
            zmena1.ShowDialog();
            this.Visible = true;
        }

        private void spravaProjektov_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SpravaDatabazy spravaU = new SpravaDatabazy();
            spravaU.ShowDialog();
            this.Visible = true;
        }

        private void hladanieStudentov_Click(object sender, EventArgs e)
        {
            
        }
    }
}
