using WineShop.Models;

namespace WineShop.Services
{
    public interface IAzterketarakoService
    {
        Task EskaeraGehitu(int bezeroaEskaeraId);
        Task EskaeraBezeroaGehitu(BezeroaEskaera bezeroaEskaera);
        Task<List<BezeroaEskaera>> getEskaeraBezeroaList();
    }
}