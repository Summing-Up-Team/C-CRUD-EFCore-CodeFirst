using C_CRUD_EFCore_CodeFirst.Core.Entidades;
using C_CRUD_EFCore_CodeFirst.Core.ViewModel;

namespace C_CRUD_EFCore_CodeFirst.Core.Repositorios
{   
    public interface IDesenvolvedorRepository
    {
        Desenvolvedor Create(DesenvolvedorViewModel request);
        List<Desenvolvedor> Read();
        void Update(Guid id,DesenvolvedorViewModel request);
        void Delete(Guid id);
    }
}
