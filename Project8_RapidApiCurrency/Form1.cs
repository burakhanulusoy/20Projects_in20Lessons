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

namespace Project8_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
                #region dolarKURU
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "7fdc49d2efmshc7819949be8e35ep10538fjsn9132de7d9d84" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
               // Console.WriteLine(body);
                var json=JObject.Parse(body);
                var values= json["result"].ToString();
                lbl_dolarsatis.Text = values;



            }

            #endregion

                #region euroKURU
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "7fdc49d2efmshc7819949be8e35ep10538fjsn9132de7d9d84" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                // Console.WriteLine(body);
                var json2 = JObject.Parse(body2);
                var values2 = json2["result"].ToString();
                lbl_euro_satis.Text = values2;



            }
            #endregion

                #region sterlinKURU
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "7fdc49d2efmshc7819949be8e35ep10538fjsn9132de7d9d84" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client3.SendAsync(request3))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                // Console.WriteLine(body);
                var json2 = JObject.Parse(body2);
                var values2 = json2["result"].ToString();
                lBL_STERLİN.Text = values2;



            }
            #endregion


        }

        private void button1_Click(object sender, EventArgs e)
        {

            double miktar = double.Parse(textBox_miktar.Text);
            if (radioButton_d.Checked)
            {
                textBox_toplam.Text = miktar * double.Parse(lbl_dolarsatis.Text) + " TL";
            }
            else if (radioButton_e.Checked)
            {
                textBox_toplam.Text = miktar * double.Parse(lbl_euro_satis.Text) + " TL";
            }
            else if (radioButton_s.Checked)
            {
                textBox_toplam.Text = miktar * double.Parse(lBL_STERLİN.Text) + " TL";
            }
            else
            {
                MessageBox.Show("Lütfen bir para birimi seçiniz.");

            }



        }
    }
}
