using AutoMapper;
using BankSynce.DbContexts;
using BankSynce.Models;

namespace BankSynce.Repositories{
    public class Usuario : IUsuario
    {

        private readonly BankSynceContext _context;
        private readonly IMapper _mapper;

        public Usuario(BankSynceContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CriarUsuarioCompleto(UsuarioFull usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fornecedor>> ListarFornecedoresComContasPorIdCliente(int idCliente)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}