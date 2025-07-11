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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project13_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.DisplayMember = "CountryName";
            comboBox1.ValueMember = "CountryCode";
            comboBox1.DataSource = new List<Country>
            {
             new Country { CountryName = "Türkiye", CountryCode = "TR" },
             new Country { CountryName = "United States", CountryCode = "US" },
             new Country { CountryName = "Germany", CountryCode = "DE" },
              };
           

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string city = txt_city.Text.Trim();       // Şehir adı
            string country = comboBox1.SelectedValue.ToString();

            string fullCity = string.IsNullOrWhiteSpace(country) ? city : $"{city},{country}";
            MessageBox.Show(fullCity, "Selected City and Country");
            string encodedCity = Uri.EscapeDataString(fullCity); // Boşluk veya özel karakterleri düzgün encode eder

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://open-weather13.p.rapidapi.com/city?city={encodedCity}&lang=EN"),
                Headers =
    {
        { "x-rapidapi-key", "7fdc49d2efmshc7819949be8e35ep10538fjsn9132de7d9d84" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            string h;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var json = JObject.Parse(body);

                // Örnek veri: sıcaklık, hissedilen sıcaklık vs.
                var feelsLike = json["main"]?["feels_like"]?.ToString();
                label_fah.Text = feelsLike;
               
                h = json["weather"]?[0]?["description"]?.ToString() ?? "Açıklama yok";

              
                float tempC = ((float.Parse(label_fah.Text) - 32) / (1.8f) );
                label_d.Text = tempC.ToString("F1") + " °C";

                var humidity = json["main"]?["humidity"]?.ToString();
                label_mois.Text = humidity;
                var windSpeed = json["wind"]?["speed"]?.ToString();
                label_wind.Text = windSpeed;


            }

            // Hava durumu verilerini al ve göster
            label1.Text = txt_city.Text.ToUpper();
            label12.Text = comboBox1.SelectedValue.ToString().ToUpper();
            label2.Text = txt_city.Text.ToUpper();
            label13.Text = comboBox1.SelectedValue.ToString().ToUpper();

            MessageBox.Show(h);


       
                    
                    
                    
                    
                    
                    
                    
        }
    }

}
