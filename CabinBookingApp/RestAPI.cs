using CabinBookingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CabinBookingApp
{
    public class RestAPI
    {
        public async Task<List<Cabin>> GetCabins(string email)
        {
            //Skicka GET request till /cabins
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://xn--webbtjnsterprojekt2pihlnikl20201013215447-gpd.azurewebsites.net/cabins/" + email);
            HttpContent content = response.Content;
            string jsonObject = await content.ReadAsStringAsync();

            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Deserialize<List<Cabin>>(jsonObject);
        }

        public async Task<List<Service>> GetServices()
        {
            //Skicka GET request till /services
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://xn--webbtjnsterprojekt2pihlnikl20201013215447-gpd.azurewebsites.net/services");
            HttpContent content = response.Content;
            string jsonObject = await content.ReadAsStringAsync();

            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Deserialize<List<Service>>(jsonObject);
        }


        public async Task<List<Reservation>> GetReservation()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://xn--webbtjnsterprojekt2pihlnikl20201013215447-gpd.azurewebsites.net/reservations/");
            HttpContent content = response.Content;
            string jsonObject = await content.ReadAsStringAsync();

            JavaScriptSerializer js = new JavaScriptSerializer();

            return js.Deserialize<List<Reservation>>(jsonObject);
        }

        public async Task SaveReservation(Reservation reservation)
        {
            HttpClient client = new HttpClient();

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonObj = js.Serialize(reservation);

            StringContent body = new StringContent(jsonObj, Encoding.UTF8, "application/json");
            await client.PostAsync("https://xn--webbtjnsterprojekt2pihlnikl20201013215447-gpd.azurewebsites.net/reservations", body);
        }

        public async Task UpdateReservation(Reservation reservation, int id)
        {
            HttpClient client = new HttpClient();

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonObj = js.Serialize(reservation);

            StringContent body = new StringContent(jsonObj, Encoding.UTF8, "application/json");
            await client.PutAsync("https://xn--webbtjnsterprojekt2pihlnikl20201013215447-gpd.azurewebsites.net/reservations/" + id, body);
        }

        public async Task DeleteReservation(string id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync("https://xn--webbtjnsterprojekt2pihlnikl20201013215447-gpd.azurewebsites.net/reservations/" + id);
        }
    }
}
