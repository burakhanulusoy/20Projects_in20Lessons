using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkProduct_DBfirst
{
    public partial class frm_product : Form
    {
        public frm_product()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        DB_2_project20Entities dB = new DB_2_project20Entities();

        private void frm_product_Load(object sender, EventArgs e)
        {
            //combobox kategori listeleme

            comboBox1.DataSource=dB.tbl_category.ToList();
            comboBox1.DisplayMember = "Category_name";
            comboBox1.ValueMember = "Category_id";

            Listele();



        }
        private void Listele()
        {
            var x = from item in dB.tbl_product
                    select new
                    {
                        item.Product_id,
                        item.Product_name,
                        item.Product_stock,
                        item.product_price,
                        item.tbl_category.Category_name
                    };
            dataGridView1.DataSource = x.ToList();
        }


        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_stok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); 





        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        void temizle()
        {
            Listele();
            txt_id.Clear();
            txt_ad.Clear();
            txt_stok.Clear();
            txt_price.Clear();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            tbl_product p = new tbl_product();
            p.Product_name = txt_ad.Text;
            p.Product_stock= int.Parse(txt_stok.Text);
            p.product_price = decimal.Parse(txt_price.Text);
            p.category_id = int.Parse(comboBox1.SelectedValue.ToString());
            dB.tbl_product.Add(p);
            dB.SaveChanges();
            MessageBox.Show("Ürün Eklendi");
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            var x=dB.tbl_product.Find(int.Parse(txt_id.Text));
            if (x != null)
            {
                dB.tbl_product.Remove(x);
                dB.SaveChanges();
                MessageBox.Show("Ürün Silindi");
                temizle();
            }
            else
            {
                MessageBox.Show("Silinecek ürün bulunamadı.");
            }



        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            var x=dB.tbl_product.Find(int.Parse(txt_id.Text));
            x.Product_name = txt_ad.Text;
            x.Product_stock = int.Parse(txt_stok.Text);
            x.product_price = decimal.Parse(txt_price.Text);
            x.category_id = int.Parse(comboBox1.SelectedValue.ToString());
            dB.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
            temizle();



        }

        private void btn_ara_Click(object sender, EventArgs e)
        {


            var x = dB.tbl_product.Where(m => m.Product_name.Equals(txt_ad.Text.ToLower()));
            dataGridView1.DataSource=x.ToList();


        }
    }
}
