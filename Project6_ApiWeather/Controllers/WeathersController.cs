using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_ApiWeather.Context;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        WeatherContext weather = new WeatherContext();


        [HttpGet]  //listeleme işlemi yapar
        public IActionResult WeatherCityList()
        {
            var values = weather.Cities.ToList();
            return Ok(values);
        }

        [HttpPost]// ekleme işlemi yapar
        public IActionResult WeatherCityAdd(City city)
        {
            weather.Cities.Add(city);
            weather.SaveChanges();
            return Ok("şehir eklendi");//mesajı döner
        }

        [HttpDelete] //silme işlemi yapar
        public IActionResult WeatherCityDelete(int id)
        {
            var value = weather.Cities.Find(id);
            if (value == null)
            {
                return NotFound("Şehir bulunamadı");
            }
            weather.Cities.Remove(value);
            weather.SaveChanges();
            return Ok("Şehir silindi");
        }



        [HttpPut] //güncelleme işlemi yapar

        public IActionResult WeatherCityUpdate(City city)
        {
            var value = weather.Cities.Find(city.CityID);
            if (value == null)
            {
                return NotFound("Şehir bulunamadı");
            }
            value.CityNAME = city.CityNAME;
            value.Country = city.Country;
            value.CityTemp = city.CityTemp;
            value.Detail = city.Detail;
            weather.SaveChanges();
            return Ok("Şehir güncellendi");
        }

        [HttpGet("İD YE Göre Şehir Getir")] //id ye göre şehir getirir

        public IActionResult WeatherCityGetById(int id)
        {
            var value = weather.Cities.Find(id);
            if (value == null)
            {
                return NotFound("Şehir bulunamadı");
            }
            return Ok(value);
        }


        [HttpGet("total city")]

        public IActionResult WeatherCityCount()
        {
            var count = weather.Cities.Count();
            return Ok("Toplam şehir sayısı: " + count);
        }

        [HttpGet("city temp max")]
        public IActionResult WeatherCityTempMax()
        {

            var maxTemp = weather.Cities.Max(C => C.CityTemp);
            return Ok("city temp max :"+maxTemp);
        }


        [HttpGet("city temp min")]
        public IActionResult weatherTempMin()
        {
            var minTemp= weather.Cities.Min(C => C.CityTemp);
            return Ok("city temp min :" + minTemp);


        }

    }
}
