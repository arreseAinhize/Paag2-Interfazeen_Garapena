using Newtonsoft.Json;
using System.Text;
using Liburuak.Models;
using Liburuak.ViewModels;

namespace Liburuak.Services
{
    public class LiburuakService : ILiburuakService
    {
        private Uri rutaTodos = new Uri("http://localhost:8081/liburua/");

        public async Task<List<Liburua>> getLiburuak()
        {
            List<Liburua> liburuaList = new List<Liburua>();
            Uri newUri = new Uri(rutaTodos, "all"); 
            //http://localhost:8081/liburua/all

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(newUri))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    liburuaList = JsonConvert.DeserializeObject<List<Liburua>>(apiResponse);
                }
            }
            return liburuaList;
        }

        public async Task<List<Liburua>> getLiburuakByAuthor(string autorId)
        {
            List<Liburua> liburuaList = new List<Liburua>();
            Uri newUri = new Uri(rutaTodos, "byAuthor");
            Uri authorUri = new Uri(newUri, $"?id={autorId}"); // http://localhost:8081/liburua/byAuthor?id=autorId

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(authorUri))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    liburuaList = JsonConvert.DeserializeObject<List<Liburua>>(apiResponse);
                }
            }
            return liburuaList;
        }

        public async Task addLiburua(Liburua liburuEskaera)
        {
            Uri newUri = new Uri(rutaTodos, "add");

            using (var httpClient = new HttpClient())
            {
                // LiburuEskaera objektua JSON formatuan sortu
                StringContent content = new StringContent(
                    JsonConvert.SerializeObject(liburuEskaera),
                    Encoding.UTF8,
                    "application/json"
                );
                // Sortutako LiburuEskaera  API-ra bidali
                var response = await httpClient.PostAsync(newUri, content);

                if (!response.IsSuccessStatusCode)
                {
                    // Errore kudeaketa --> API-ak bueltatzen duen errore mezua irakurri
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Error {response.StatusCode}: {errorContent}");
                }

                //METODOAK LIBURU ESKAERA BAT BUELTATU BEHARKO BALUKE:
                //Erantzun arrakastatsua jaso eta LiburuEskaera objektua deserializatu
                //string responseContent = await response.Content.ReadAsStringAsync();
                //Liburua createdLiburuEskaera = JsonConvert.DeserializeObject<Libutua>(responseContent);
                //return createdLiburuEskaera;
            }
        }
    }
}