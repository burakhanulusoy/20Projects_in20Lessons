using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project18_SuperStoreDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Db17_SuperStoreEntities db = new Db17_SuperStoreEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region İnfos




            var productCount = db.superstore.Count();
                                 

            lbl_productcount.Text = productCount.ToString();



            var orderCount=db.superstore.Sum(m=>m.Quantity);
            lbl_ordercount.Text = orderCount.ToString();


            var cityCount = db.superstore
                                 .Select(p => p.City)
                                 .Distinct()
                                 .Count();
            lbl_citycount.Text = cityCount.ToString();




            var TurkeyorderCount = db.superstore.Where(x=>x.Country=="Turkey").Sum(m => m.Quantity);
            lbl_turkey.Text = TurkeyorderCount.ToString();
            #endregion

            #region Chart1

            var countryData = db.superstore
    .GroupBy(x => x.Country)
    .Select(g => new
    {
        Country = g.Key,
        TotalQuantity = g.Sum(x => x.Quantity)
    })
    .OrderByDescending(g => g.TotalQuantity) // En çok sipariş veren ülkeler
    .Take(5)
    .ToList();

            foreach (var item in countryData)
            {
                chart1.Series["Series1"].Points.AddXY(item.Country, item.TotalQuantity);
            }

            #endregion

            #region Chart2
            var countryData2 = db.superstore
           .GroupBy(x => x.Country)
           .Select(g => new
           {
               Country = g.Key,
               TotalQuantity = g.Sum(x => x.Quantity)
           }
          ).OrderBy(g=>g.TotalQuantity)
           .Take(5)
           .ToList();

            foreach (var item in countryData2)
            {
                chart2.Series["Series2"].Points.AddXY(item.Country, item.TotalQuantity);
            }



            #endregion


            #region Chart3


            var priorityData = db.superstore
    .GroupBy(x => x.Order_Priority)
    .Select(g => new
    {
        Priority = g.Key,
        TotalOrders = g.Sum(x => x.Quantity)
    })
    .OrderByDescending(p => p.TotalOrders)
    .ToList();


            foreach (var item in priorityData)
            {
                chart3.Series["Series3"].Points.AddXY(item.Priority, item.TotalOrders);
            }

            #endregion








        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
