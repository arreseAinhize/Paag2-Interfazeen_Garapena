using Newtonsoft.Json;
using System.Text;
using WineShop.Models;
using WineShop.ViewModels;

namespace WineShop.Services
{
    public class AzterketarakoService : IAzterketarakoService
    {
        public async Task EskaeraGehitu(int bezeroaEskaeraId)
        {
            Uri rutaTodos = new Uri("https://localhost:7049/api/Erosketa/");

            // API-ko eskaerak egiteko HttpClient instantzia sortu
            using (var httpClient = new HttpClient())
            {
                // API-ra bidaltzeko eskaera objektua sortu JSON formatuan
                StringContent content = new StringContent(
                    JsonConvert.SerializeObject(new ErosketaViewModel
                    {
                        kantitatea = 23,
                        ardoaId = 32,
                        bezeroaEskaeraId = bezeroaEskaeraId // Usar el ID recibido
                    }),
                    Encoding.UTF8,            // Textua kodificatuu UTF-8 erabiliz
                    "application/json"        // JSON formatua erabiltzeko adierazi
                );

                // POST eskaera API-ra bidali eta erantzuna itxaron
                var response = await httpClient.PostAsync(rutaTodos, content);

                if (response.IsSuccessStatusCode)
                {
                    // Kontsola arrakasta mezua bistaratu
                    Console.WriteLine("Pedido enviado correctamente a la API.");
                }
                else
                {
                    // Zerbatit txarto atera bada: API-ak bueltatzen duen errore mezua irakurri
                    var error = await response.Content.ReadAsStringAsync();
                    // Errore kodea eta mezua kontsola bistaratu
                    Console.WriteLine($"Error al enviar pedido: {response.StatusCode} - {error}");
                }
            }
        }

        public async Task EskaeraBezeroaGehitu(BezeroaEskaera bezeroaEskaera)
        {
            Uri rutaBezeroEskaera = new Uri("https://localhost:7049/api/BezeroaEskaera/");

            using (var httpClient = new HttpClient())
            {
                // BezeroaEskaera objektua JSON formatuan sortu
                StringContent content = new StringContent(
                    JsonConvert.SerializeObject(bezeroaEskaera),
                    Encoding.UTF8,
                    "application/json"
                );
                // Sortutako BezeroEskaera API-ra bidali
                var response = await httpClient.PostAsync(rutaBezeroEskaera, content);

                if (!response.IsSuccessStatusCode)
                {
                    // Errore kudeaketa --> API-ak bueltatzen duen errore mezua irakurri
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Error {response.StatusCode}: {errorContent}");
                }

                //METODOAK BEZERO ESKAERA BAT BUELTATU BEHARKO BALUKE:
                //Erantzun arrakastatsua jaso eta BezeroaEskaera objektua deserializatu
                //string responseContent = await response.Content.ReadAsStringAsync();
                //BezeroaEskaera createdBezeroaEskaera = JsonConvert.DeserializeObject<BezeroaEskaera>(responseContent);
                //return createdBezeroaEskaera;
            }
        }

        public async Task<List<BezeroaEskaera>> getEskaeraBezeroaList()
        {
            // BezeroaEskaera objektu zerrenda bat sortu bertan lortutako BezeroEskaerak gordetzeko
            List<BezeroaEskaera> bezeroEskaeraList = new List<BezeroaEskaera>();
            Uri rutaBezeroEskaera = new Uri("https://localhost:7049/api/BezeroaEskaera/"); // API endpoint-a

            // HttpClient instantzia sortu API eskaerak egiteko
            using (var httpClient = new HttpClient())
            {
                // GET eskaera API-ra bidali eta erantzuna itxaron
                using (var response = await httpClient.GetAsync(rutaBezeroEskaera))
                {
                    // Erantzun arrakastatsua jaso bada
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    // Erantzuna BezeroaEskaera objektu zerrendara deserializatu eta itzuli
                    bezeroEskaeraList = JsonConvert.DeserializeObject<List<BezeroaEskaera>>(apiResponse);
                }
            }
            return bezeroEskaeraList;
        }
    }
}
