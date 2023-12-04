using BankSynce.Models;

namespace BankSynce.Repositories{
    public class Usuario : IUsuario
    {
        public Task<bool> CriarUsuarioCompleto(UsuarioFull usuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fornecedor>> ListarFornecedoresComContasPorIdCliente(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}