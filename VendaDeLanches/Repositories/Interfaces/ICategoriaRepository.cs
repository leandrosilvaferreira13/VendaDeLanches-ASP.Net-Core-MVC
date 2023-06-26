using VendaDeLanches.Models;

namespace VendaDeLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
