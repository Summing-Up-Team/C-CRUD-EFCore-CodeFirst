using C_CRUD_EFCore_CodeFirst.Core.Context;
using C_CRUD_EFCore_CodeFirst.Core.Entidades;
using C_CRUD_EFCore_CodeFirst.Core.ViewModel;

namespace C_CRUD_EFCore_CodeFirst.Core.Repositorios
{
    public class DesenvolvedorRepository : IDesenvolvedorRepository
    {
        private readonly _DbContext _db;

        public DesenvolvedorRepository(_DbContext db)
        {
            _db = db;
        }

        public Desenvolvedor Create(DesenvolvedorViewModel request)
        {
            var desenvolvedor = new Desenvolvedor
            {
                Id = Guid.NewGuid(),
                Idade = request.Idade,
                Nome = request.Nome
            };

            _db.Desenvolvedor.Add(desenvolvedor);
            _db.SaveChanges();

            return desenvolvedor;
        }

        public void Delete(Guid id)
        {
            _db.Desenvolvedor.Remove(_db.Desenvolvedor.Find(id));
            _db.SaveChanges();
        }

        public List<Desenvolvedor> Read() => _db.Desenvolvedor.ToList();

        public void Update(Guid id, DesenvolvedorViewModel request)
        {
            var fromDb = _db.Desenvolvedor.Find(id);

            fromDb.Idade = request.Idade;
            fromDb.Nome = request.Nome;

            _db.SaveChanges();
        }
    }
}
