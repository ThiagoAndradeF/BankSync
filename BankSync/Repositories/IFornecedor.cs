using BankSynce.Models;
using BankSynce.Entities;

namespace BankSynce.Repositories{
    public interface IFornecedor{
        Task<bool> CriarFornecedor(FornecedorDto informacoesFornecedor);
        Task<IEnumerable<TransacaoFull>> ListarTransacoesFornecedorIdFornecedor(int idFornecedor);
    }
}