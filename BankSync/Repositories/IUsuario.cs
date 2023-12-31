using BankSynce.Models;
using BankSynce.Entities;

namespace BankSynce.Repositories
{
    public interface IUsuario{

        Task<bool> CriarUsuarioCompleto(UsuarioFull usuario);
        Task<IEnumerable<Fornecedor>> ListarFornecedoresComContasPorIdCliente( int idCliente);

    }
}