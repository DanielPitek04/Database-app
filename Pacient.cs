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
    public partial class edutageApp : Form
    {
        public edutageApp()
        {
            InitializeComponent();
        }
        IFirebaseConfig databaza = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""

        };

        IFirebaseClient client;

        private  void hladat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pacient - Môžete si tu pozrieť dáta ohľadom coronavírusu po svete.");
        }
        List<data> dataList;
        private async void edutageApp_Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
