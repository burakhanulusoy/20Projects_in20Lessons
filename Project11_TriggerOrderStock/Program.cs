using Project11_TriggerOrderStock.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11_TriggerOrderStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DB_11_project_sqlTriggerEntities context = new DB_11_project_sqlTriggerEntities();

            string number;

            Console.WriteLine("### SİPARİŞ STOK SİSTEMİ ###");
            Console.WriteLine();
            Console.WriteLine("1-Ürün Listesi");
            Console.WriteLine("2-Sipariş Listesi");
            Console.WriteLine("3-Kasa Yönetimi");
            Console.WriteLine("4-Yeni Ürün Satışı");
            Console.WriteLine("5-İşlem Sayacı ");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();


            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
            number = Console.ReadLine();

            if (number.Equals("1"))
            {
                Console.WriteLine("---Ürün Listesi---\n");
                Console.WriteLine("------------------");
                var values= context.tbl_product.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine("ID :"+item.Productid);
                    Console.WriteLine("Ürün Adı: " + item.name);
                    Console.WriteLine("Ürün Fiyatı: " + item.price+"$");
                    Console.WriteLine("Ürün Stok: " + item.stock);
                    Console.WriteLine("--------------------------");
                }

            }
            else if (number.Equals("2"))
            {
                Console.WriteLine("---Sipariş Listesi---\n");
                Console.WriteLine("---------------------");
                var values2 = context.tbl_order.ToList();
                foreach (var item in values2)
                {
                    Console.WriteLine("Sipariş ID :" + item.orderid);
                    Console.WriteLine("Müşteri Adı: " + item.customer);
                    Console.WriteLine("Ürün ID " +item.tbl_product.name);
                    Console.WriteLine("Adet Fiyatı : " + item.unitprice);
                    Console.WriteLine("Adet : " + item.quantity);
                    Console.WriteLine("Toplam Fiyatı : " + item.totalprice);

                    Console.WriteLine("--------------------------");
                }




            }
            else if (number.Equals("3"))
            {
                Console.WriteLine("---Kasa Durumu---\n");
                Console.WriteLine("---------------------");
                var values2 = context.tbl_cashRegister.Select(x=>x.balance).FirstOrDefault();
                Console.WriteLine("Kasa Bakiyesi: " + values2 + " $");

            }
            else if (number.Equals("4"))
            {
                Console.WriteLine("---Yeni Sipariş Girişi---\n");
                Console.WriteLine("--------------------------");
              
                Console.Write("Lütfen müşteri adını giriniz:");
                string customerName = Console.ReadLine();
              
                Console.Write("Lütfen ürün ID'sini giriniz:");
                int productId = Convert.ToInt32(Console.ReadLine());

                var m=context.tbl_product.Where(x=> x.Productid == productId).Select(y=>y.price).FirstOrDefault();
                var n = context.tbl_product.Where(x => x.Productid == productId).Select(y => y.name).FirstOrDefault();
                Console.WriteLine("Ürün Adı: " + n);
                Console.Write("Lütfen ürün adedini giriniz:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(  "birim fiyatı :"+m.ToString());
                decimal unitPrice = decimal.Parse(m.ToString());

                decimal totalPrice = unitPrice * quantity;
                Console.WriteLine("Toplam Fiyat: " + totalPrice + " $");

                tbl_order newOrder = new tbl_order();
                newOrder.customer = customerName;
                newOrder.product_id = productId;
                newOrder.unitprice = unitPrice;
                newOrder.quantity = quantity;
                newOrder.totalprice = totalPrice;


                context.tbl_order.Add(newOrder);
                context.SaveChanges();
                Console.WriteLine("Sipariş başarıyla eklendi!");





            }
            else if (number.Equals("5"))
            {
            
                var prosesCount=context.tbl_process.Select(x=>x.process).FirstOrDefault();
                Console.WriteLine("---İşlem Sayısı : " + prosesCount);



            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
            }






        }
    }
}
