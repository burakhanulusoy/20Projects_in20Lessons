#region MenüBaşlangıcı

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

Console.WriteLine("     Api Consume İşlemine Hoşgeldiniz!");
Console.WriteLine();
Console.WriteLine("###  Yapmak İstediğiniz İşlemi Seçiniz  ###");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesiniz Getirin");
Console.WriteLine("2-Şehir Ekleyin");
Console.WriteLine("3-Şehir Silin");
Console.WriteLine("4-Şehir Güncelleyin");
Console.WriteLine("5-Id'ye göre şehir listesi getirin");
Console.WriteLine();

#endregion

Console.Write("Seçiminiz: ");
string number= Console.ReadLine();
Console.WriteLine();

//6.proje ile aynı anda çalışacak

if (number.Equals("1"))
{
    string url = "https://localhost:7280/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response =await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jarray=JArray.Parse(responseBody);
        foreach(var item in jarray)
        {
            string cityName = item["cityNAME"].ToString();
            string weather = item["cityTemp"].ToString();
            Console.WriteLine($"Şehir Adı: {cityName} ve hava durumu {weather}");
            Console.WriteLine("------------------------------------------");
        }

    }



}


else if (number.Equals("2"))
{

    Console.WriteLine("###  YENİ VERİ GİRİŞİ  ###");
    Console.WriteLine();
    Console.Write("Şehir adı? :");
    string city= Console.ReadLine();
    Console.Write("Şehir sıcaklığı? :");
    string cityTemp = Console.ReadLine();
    Console.Write("Ülke adı? :");
    string country = Console.ReadLine();
    Console.Write("detay? :");
    string detail = Console.ReadLine();


    string url = "https://localhost:7280/api/Weathers";
    var newValue = new
    {
        CityNAME =city,
        CityTemp =decimal.Parse(cityTemp),
        Country=country,
        Detail= detail
    };

    using (HttpClient client = new HttpClient())
    {
          string json=JsonConvert.SerializeObject(newValue);
          StringContent stringContent = new StringContent(json,Encoding.UTF8, "application/json");
          HttpResponseMessage httpResponseMessage = await client.PostAsync(url, stringContent);
          httpResponseMessage.EnsureSuccessStatusCode();

    }



}

else if (number.Equals("3"))
{
    string url = "https://localhost:7280/api/Weathers?id=";//?id= ekledim
    Console.WriteLine("###  Şehir Silme İşlemi  ###");
    Console.Write("Silmek istediğiniz şehir Id'si: ");
    string id = Console.ReadLine();


    using (HttpClient client = new HttpClient())
    {
       HttpResponseMessage response = await client.DeleteAsync(url+id);
        response.EnsureSuccessStatusCode();


    }






}


else if (number.Equals("4"))
{
    
    
    
    Console.WriteLine("### VERİ GÜNCELLEME GİRİŞİ  ###");
    Console.WriteLine();
    Console.Write("Şehir adı? :");
    string city = Console.ReadLine();
    Console.Write("Şehir sıcaklığı? :");
    string cityTemp = Console.ReadLine();
    Console.Write("Ülke adı? :");
    string country = Console.ReadLine();
    Console.Write("detay? :");
    string detail = Console.ReadLine();
    Console.WriteLine();
    
    Console.Write("Güncellemek istediğiniz şehir Id'si: ");
    string id = Console.ReadLine();

    var newvalue = new
    {
        CityID= int.Parse(id),
        CityNAME = city,
        CityTemp = decimal.Parse(cityTemp),
        Country = country,
        Detail = detail


    };

    string url = "https://localhost:7280/api/Weathers?";


    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newvalue);
        StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage httpResponseMessage = await client.PutAsync(url,stringContent);
        httpResponseMessage.EnsureSuccessStatusCode();

    }



}




else if (number.Equals("5"))
{
    Console.WriteLine("###  İD'ye göre şehir listesi getirme  ###");
    Console.Write("Lütfen şehir Id'sini giriniz: ");
    int id =int.Parse( Console.ReadLine());



    string url = "https://localhost:7280/api/Weathers/İD YE Göre Şehir Getir?id=";
    using (HttpClient client = new HttpClient())
    {
       
        HttpResponseMessage response = await client.GetAsync(url + id.ToString());
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JObject jS = JObject.Parse(responseBody);//tek deger geldigiiçin object
        string cityName = jS["cityNAME"].ToString();
        string weather = jS["cityTemp"].ToString();
        string country = jS["country"].ToString();
        string detail = jS["detail"].ToString();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Şehir Adı: {cityName}");
        Console.WriteLine($"Şehir Sıcaklığı: {weather}");
        Console.WriteLine($"Ülke Adı: {country}");
        Console.WriteLine($"Detay: {detail}");
        Console.WriteLine("------------------------------------------");
    }





}
else
{
    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
}







Console.Read();


