using Newtonsoft.Json;
using System.Text;
using WineShop.Models;

namespace WineShop.Services
{
    public class SaskiaService : ISaskiaService
    {
        private Uri rutaTodos = new Uri("https://localhost:7049/api/SaskiaAlea/");
        private readonly IArdoaService _ardoaService;
        public SaskiaService(IArdoaService ardoaService)
        {
            _ardoaService = ardoaService;
        }
        public async Task SaskiaGehitu(int ardoaId, string saskiaId)
        {
            //Saskia existitzen den begiratu
            Uri rutasaskia = new Uri(rutaTodos, saskiaId);
            List<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutasaskia))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    saskiaAleaList = JsonConvert.DeserializeObject<List<SaskiaAlea>>(apiResponse);
                }
            }
            SaskiaAlea cartitem = new SaskiaAlea();
            cartitem = null;
            if (saskiaAleaList != null)
            {
                cartitem = saskiaAleaList.FirstOrDefault(s => s.ArdoaId == ardoaId);
            }
            if (saskiaAleaList == null || cartitem == null)
            {
                // Karrito berria sortu
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(new SaskiaAlea
                    {
                        ArdoaId = ardoaId,
                        SaskiaId = saskiaId,
                        Kantitatea = 1,
                        Data = DateTime.Now
                    }), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(rutaTodos, content);
                    response.EnsureSuccessStatusCode();
                }
            }
            else
            {
                cartitem.Kantitatea++;
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(cartitem), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(rutasaskia, content);
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        public async Task SaskiaKendu(int ardoaId, string saskiaId)
        {
            //Saskia lortu
            Uri rutasaskia = new Uri(rutaTodos, saskiaId);
            List<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            // Saskia lortu API deitik 
            using (var httpClient = new HttpClient())
            {
                // Saskia aleak lortu API deitik
                using (var response = await httpClient.GetAsync(rutasaskia))
                {
                    // Read the API response as a string
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    saskiaAleaList = JsonConvert.DeserializeObject<List<SaskiaAlea>>(apiResponse);
                }
            }
            // Ardoa bilatu saskian 
            SaskiaAlea cartitem = saskiaAleaList.FirstOrDefault(s => s.ArdoaId == ardoaId);
            // Ardoa aurkitu bada 
            if (cartitem != null)
            {
                // Kantitatea 1 baino handiagoa bada, gutxitu kantitatea
                if (cartitem.Kantitatea > 1)
                {
                    // Kantitatea gutxitu eta eguneratu API deian
                    cartitem.Kantitatea--;
                    using (var httpClient = new HttpClient())
                    {
                        // Eguneratu saskia alea API deian
                        StringContent content = new StringContent(JsonConvert.SerializeObject(cartitem), Encoding.UTF8, "application/json");
                        var response = await httpClient.PutAsync(rutasaskia, content);
                        response.EnsureSuccessStatusCode();
                    }
                }
                else
                {
                    // Kantitatea 1 bada, kendu saskiatik
                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.DeleteAsync(new Uri(rutasaskia, ardoaId.ToString()));
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
        }
        public async Task<List<SaskiaAlea>> SaskiaLortuAleak(string saskiaId)
        {
            //Saskia lortu
            Uri rutasaskia = new Uri(rutaTodos, saskiaId);
            List<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutasaskia))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    saskiaAleaList = JsonConvert.DeserializeObject<List<SaskiaAlea>>(apiResponse);
                }
            }
            return saskiaAleaList;
        }
    }
}
