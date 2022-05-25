using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abschlussprojekt
{
    public partial class Weather : Form
    {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = addressinput.Text;
            String geolocation = "https://api.myptv.com/geocoding/v1/locations/by-text?searchText=" + input + "&apiKey=MGUxZGNjZGM1NTlkNDFhMjgxYjkzZGIwZTU5NjMyYmU6ZTFjZjE5OGMtMTRhYi00MTY5LThjMDItOGMxOTJmZTAzODRj";
            textBox1.Text = input;
            textBox2.Text = geolocation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weather_Load(object sender, EventArgs e)
        {

        }
    }
}
