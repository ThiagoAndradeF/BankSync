using BankSynce.Models;
using BankSynce.Entities;

namespace BankSynce.Repositories
{
    public interface ICliente{
        Task<IEnumerable<Fornecedor>> ListarFornecedoresComContasPorIdCliente( int idCliente);
        Task<IEnumerable<TransacaoFull>> ListarTodasTransacoesIdCliente(int idCliente);
    }
}