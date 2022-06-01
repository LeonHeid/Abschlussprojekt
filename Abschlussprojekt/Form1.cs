using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt
{
    public partial class Weather : Form
    {
        Dictionary<string, string> stationDict;
        public Weather()
        {
            InitializeComponent();
        }

        private void addressinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearinput_Click(object sender, EventArgs e)
        {
            addressinput.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String input = addressinput.Text;
            if (input != "NO INPUT")
            {
                if (input != String.Empty)
                {
                    String geolocation = "https://api.myptv.com/geocoding/v1/locations/by-text?searchText=" + input + "&apiKey=MGUxZGNjZGM1NTlkNDFhMjgxYjkzZGIwZTU5NjMyYmU6ZTFjZjE5OGMtMTRhYi00MTY5LThjMDItOGMxOTJmZTAzODRj";
                    //textBox1.Text = input;
                    //textBox2.Text = geolocation;


                    HttpClient client = new HttpClient();
                    stationDict = new Dictionary<string, string>();

                    string res = await client.GetStringAsync(geolocation);
                    var jsonDataSingle = JObject.Parse(res);


                    textBox1.Text = (string)jsonDataSingle["locations"][0]["referencePosition"]["latitude"];
                    textBox2.Text = (string)jsonDataSingle["locations"][0]["referencePosition"]["longitude"];
                }
                else if (input == String.Empty)
                {
                    addressinput.Text = "NO INPUT";
                }
            }
            else if (input == "NO INPUT")
            { 
            
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weather_Load(object sender, EventArgs e)
        {

        }
    }
}
