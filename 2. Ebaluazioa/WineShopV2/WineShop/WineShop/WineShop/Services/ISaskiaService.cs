using WineShop.Models;

namespace WineShop.Services
{
    public interface ISaskiaService
    {
        Task SaskiaGehitu(int ardoaId, string saskiaId);

        // SaskiaKendu funtzioa gehitu interface-ra
        Task SaskiaKendu(int ardoaId, string saskiaId);

        Task<List<SaskiaAlea>> SaskiaLortuAleak(string saskiaId);

        Task<BezeroaEskaera> EskaeraBezeroaGehitu(BezeroaEskaera bezeroaEskaera);
        Task EskaeraSortu(BezeroaEskaera bezeroaEskaera, string saskiaId);

    }
}
