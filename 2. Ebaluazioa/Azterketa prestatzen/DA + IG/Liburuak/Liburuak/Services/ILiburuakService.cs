using Liburuak.Models;

namespace Liburuak.Services
{
    public interface ILiburuakService
    {
        Task<List<Liburua>> getLiburuak();
        Task<List<Liburua>> getLiburuakByAuthor(string autorId);
        Task addLiburua(Liburua liburua);
    }
}