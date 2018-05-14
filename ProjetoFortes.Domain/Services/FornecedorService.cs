using ProjetoFortes.Domain.Entities;
using ProjetoFortes.Domain.Interface.Services;
using ProjetoFortes.Domain.Interface.Repositories;

namespace ProjetoFortes.Dominio.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository) : base(fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }
    }
}
