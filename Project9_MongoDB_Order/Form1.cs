using Project9_MongoDB_Order.Entity;
using Project9_MongoDB_Order.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDB_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        OrderOperation orderOperation = new OrderOperation();
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            var order = new Order
            {
                CustomerName = txt_ad.Text,
                District = txt_ilce.Text,
                City = txt_city.Text,
                TotalPrice = Convert.ToDecimal(txt_tutar.Text)
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Sipariş Eklendi");

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {

            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            string orderId = txt_sid.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Sipariş Silindi");



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id=txt_sid.Text;
            var order = new Order
            {
                CustomerName = txt_ad.Text,
                District = txt_ilce.Text,
                City = txt_city.Text,
                TotalPrice = Convert.ToDecimal(txt_tutar.Text),
                OrderId = id

            };

            orderOperation.updateOrder(order);




        }
    }
}
