using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

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
            //Checking if the input field is empty or NO INPUT is written
            String input = addressinput.Text;
            if (input != "NO INPUT")
            {
                if (input != String.Empty)
                {
                    //Geolocation API request and Display Data on to the Textboxes
                    String geolocation = "https://api.myptv.com/geocoding/v1/locations/by-text?searchText=" + input + "&apiKey=MGUxZGNjZGM1NTlkNDFhMjgxYjkzZGIwZTU5NjMyYmU6ZTFjZjE5OGMtMTRhYi00MTY5LThjMDItOGMxOTJmZTAzODRj";

                    HttpClient geoClient = new HttpClient();
                    stationDict = new Dictionary<string, string>();

                    string geoRes = await geoClient.GetStringAsync(geolocation);
                    var geoJsonDataSingle = JObject.Parse(geoRes);

                    textBox1.Text = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["latitude"];
                    textBox2.Text = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["longitude"];

                    String resLatitude = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["latitude"];
                    String resLongitude = (string)geoJsonDataSingle["locations"][0]["referencePosition"]["longitude"];



                    String weather = "https://api.tomorrow.io/v4/timelines?location=" + resLatitude + "," + resLongitude + "&fields=temperature,precipitationIntensity,precipitationProbability,precipitationType&timesteps=1m&units=metric&apikey=aw5TpIHGOpwXGncccwayTkiVZ2IyYrZ2";



                    HttpClient weatherClient = new HttpClient();

                    string weatherRes = await weatherClient.GetStringAsync(weather);
                    var weatherJsonDataSingle = JObject.Parse(weatherRes);

                    textBox3.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["temperature"];

                    pIntensity.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationIntensity"];
                    pProbability.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationProbability"];
                    pType.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationType"];
                    textBox4.Text = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["startTime"];


                    int pIntensityInt = (int)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationIntensity"];
                    int pProbabilityInt = (int)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationProbability"];



                    String resDescription = "";
                    String pSwitchStringType = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationType"];
                    int pSwitchType = Int32.Parse(pSwitchStringType);
                    if (pIntensityInt == 0 && pProbabilityInt == 0)
                    {
                        pSwitchType = 0;
                        pType.Text = "0";
                    }
                    else if (pIntensityInt != 0 && pProbabilityInt != 0)
                    {

                    }
                    switch (pSwitchType)
                    {
                        case 0:
                            resDescription = "Not Any";
                            pDescription.Text = resDescription;
                            break;
                        case 1:
                            resDescription = "Rain";
                            pDescription.Text = resDescription;
                            break;
                        case 2:
                            resDescription = "Snow";
                            pDescription.Text = resDescription;
                            break;
                        case 3:
                            resDescription = "Freezing Rain";
                            pDescription.Text = resDescription;
                            break;
                        case 4:
                            resDescription = "Ice Pellets";
                            pDescription.Text = resDescription;
                            break;
                        default:
                            break;
                    }


                    String resTemperature = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["temperature"];
                    String resTime = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["startTime"];
                    String resPIntensity = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationIntensity"];
                    String resPProbability = (string)weatherJsonDataSingle["data"]["timelines"][0]["intervals"][0]["values"]["precipitationProbability"];


                    


                    JsonAppData postJson = new JsonAppData { latitude = resLatitude, longitude = resLongitude, temperature = resTemperature, utcTime = resTime, pIntensity = resPIntensity, pProbability = resPProbability, pType = pSwitchStringType, description = resDescription };
                    string postToAzure = JsonConvert.SerializeObject(postJson);
                    /*using (StreamWriter writer = new StreamWriter("../../../testing.txt"))
                    {
                        String test = "testing"; 
                        DateTime now = DateTime.Now;
                        writer.WriteLine(test + " " + now.ToLocalTime().ToString());
                    }*/

                    HttpWebRequest webRequest;

                    string requestParams = postToAzure; //format information you need to pass into that string ('info={ "EmployeeID": [ "1234567", "7654321" ], "Salary": true, "BonusPercentage": 10}');

                    webRequest = (HttpWebRequest)WebRequest.Create("https://prod-28.switzerlandnorth.logic.azure.com:443/workflows/62c68877cff445a68d7ad0d484e40885/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=-Wnjg42KsgRhh5DDjXnMu0Ad9j4jYC6CrG3rYy5puzA");

                    webRequest.Method = "POST";
                    webRequest.ContentType = "application/json";

                    byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
                    webRequest.ContentLength = byteArray.Length;
                    using (Stream requestStream = webRequest.GetRequestStream())
                    {
                        requestStream.Write(byteArray, 0, byteArray.Length);
                    }

                    // Get the response.
                    using (WebResponse response = webRequest.GetResponse())
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                            string lARes = rdr.ReadToEnd(); // response from server
                            DateTime now = DateTime.Now;

                            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                            //textBox5.Text = now.ToLocalTime().ToString();

                            using (StreamWriter writer = new StreamWriter("../../../Logfile.txt", true))
                            {
                                writer.WriteLine(lARes + " " + now.ToLocalTime().ToString());
                            }
                        }
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        class JsonAppData
        {
            public String latitude;
            public String longitude;
            public String temperature;
            public String utcTime;
            public String pIntensity;
            public String pProbability;
            public String pType;
            public String description;
        }
    }
}
