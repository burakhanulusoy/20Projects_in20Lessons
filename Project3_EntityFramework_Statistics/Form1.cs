using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFramework_Statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //connection to the database
        DB_3_20ProjectsEntities DB = new DB_3_20ProjectsEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TOPLAM KATAGORİ SAYISI   
            lbl_kategori_sayisi.Text=DB.tbl_category.Count().ToString();

            
            // TOPLAM ÜRÜN SAYİSİ   
            lbl_toplam_urun.Text=DB.TBLproduct.Count().ToString();

            
            // TOPLAM MÜŞTERİ SAYISI
            lnl_toplam_musteri.Text=DB.TBLcustomer.Count().ToString();

            
            // TOPLAM SİPARİŞ SAYISI
            lbl_toplam_satis.Text=DB.TBLorder.Count().ToString();
            
            
            //toplam elma sayisi
            lbl_elma.Text=DB.TBLproduct.Where(x=>x.product_name=="Elma").Sum(y=>y.product_stock).ToString();

            
            //toplam stok  sayiis
            lbl_toplam_stok.Text=DB.TBLproduct.Sum(x => x.product_stock).ToString();

            
            //ortalama urun fiyatı
            lbl_ortUrunFiyat.Text=DB.TBLproduct.Average(x => x.product_price).ToString()+" TL";

           
            //toplam meyve sayısı
            lbl_toplam_meyve.Text=DB.TBLproduct.Where(x=>x.category_id==1).Sum(y=>y.product_stock).ToString();

            
            //gazoz getirisi
            lbl_gazoz_getiri.Text=DB.TBLproduct.Where(x => x.product_name == "Gazoz").Sum(y => y.product_price * y.product_stock).ToString() + " TL";

            
            //stok sayısı 100 den az olan ürünler
            lbl_100azstok.Text=DB.TBLproduct.Where(x=>x.product_stock<100).Count().ToString();

            
            //sebzeler
            lbl_sebzeler.Text=DB.TBLproduct.Where(x=>x.category_id==2 && x.product_status==true).Sum(y=>y.product_stock).ToString();

          
            //tr den olan siparişler
            var tr=DB.TBLcustomer.Where(x=>x.customer_country == "TÜRKİYE").Select(y => y.customer_id).ToList();
            var sayi=DB.TBLorder.Where(x => tr.Contains(x.customer_id.Value)).Count();
            lbl_tr_sip.Text = sayi.ToString();

           
            //meyve satisi getiriisi
            label_meyve_Satıs_kar.Text=DB.TBLorder.Where(x=>x.TBLproduct.category_id==1).Sum(y=>y.Totalprice).ToString()+" TL";

          
            //son eklenen ürün
            label_en_son_ekl.Text=DB.TBLproduct.OrderByDescending(x=>x.productId).Select(y=>y.product_name).FirstOrDefault();

           
            //en son eklenen kategori
            label_en_son_kat.Text = DB.TBLproduct.OrderByDescending(x => x.productId).Select(y => y.tbl_category.categoryname).FirstOrDefault().ToString();

           
            //aktif ürün sayısı
            label_aktif.Text=DB.TBLproduct.Where(x=>x.product_status==true).Count().ToString(); 

           
            //cola getirisi
            label_cola.Text=DB.TBLproduct.Where(x=>x.product_name.Equals("COLA")).Sum(y=>y.product_price*y.product_stock).ToString()+" TL";

          
            //son müseteri
            label_sonmusteri.Text=DB.TBLorder.OrderByDescending(x=>x.order_id).Select(y=>y.TBLcustomer.customer_name).FirstOrDefault().ToString();

          
            //farklı ülkes sayısı
            label_ulkesayisi.Text=DB.TBLcustomer.Select(x=>x.customer_country).Distinct().Count().ToString();

          
            //farklı şehir sayısı
            label_farklısehir.Text=DB.TBLcustomer.Select(x=>x.customer_city).Distinct().Count().ToString();



        }

    }
}
