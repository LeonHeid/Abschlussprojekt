using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
            pDescription.Text = String.Empty;
            pIntensity.Text = String.Empty;
            pProbability.Text = String.Empty;
            pType.Text = String.Empty;
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


                    HttpClient geoClient = new HttpClient();
                    stationDict = new Dictionary<string, string>();

                    string geoRes = await geoClient.GetStringAsync(geolocation);
                    var geoJsonDataSingle = JObject.Parse(geoRes);


                    textBox1.Text = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["latitude"];
                    textBox2.Text = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["longitude"];

                    String latitude = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["latitude"];
                    String longitude = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["longitude"];

                    String weather = "https://api.tomorrow.io/v4/timelines?location=" + latitude + "," + longitude + "&fields=temperature,precipitationIntensity,precipitationProbability,precipitationType&timesteps=1m&units=metric&apikey=aw5TpIHGOpwXGncccwayTkiVZ2IyYrZ2";

                    //textBox4.Text = weather;

                    HttpClient weatherClient = new HttpClient();

                    string weatherRes = await weatherClient.GetStringAsync(weather);
                    var weatherJsonDataSingle = JObject.Parse(weatherRes);

                    textBox3.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["temperature"];

                    pIntensity.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationIntensity"];
                    pProbability.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationProbability"];
                    pType.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationType"];
                    textBox4.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["startTime"];


                    int pIntensityString = (int)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationIntensity"];
                    int pProbabilityString = (int)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationProbability"];

                    //int pIntensityInt = Int32.Parse(pIntensityString);
                    //int pProbabilityInt = Int32.Parse(pProbabilityString);


                    String pSwitchStringType = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationType"];
                    int pSwitchType = Int32.Parse(pSwitchStringType);
                    if (pIntensityString == 0 && pProbabilityString == 0)
                    {
                        pSwitchType = 0;
                        pType.Text = "0";
                    }
                    else if (pIntensityString != 0 && pProbabilityString != 0)
                    {

                    }
                    switch (pSwitchType)
                    {
                        case 0:
                            pDescription.Text = "Not Any";
                            break;
                        case 1:
                            pDescription.Text = "Rain";
                            break;
                        case 2:
                            pDescription.Text = "Snow";
                            break;
                        case 3:
                            pDescription.Text = "Freezing Rain";
                            break;
                        case 4:
                            pDescription.Text = "Ice Pellets";
                            break;
                        default:
                            break;
                    }



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

        private void pIntensity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
