using VendaDeLanches.Context;
using VendaDeLanches.Models;
using VendaDeLanches.Repositories.Interfaces;

namespace VendaDeLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
