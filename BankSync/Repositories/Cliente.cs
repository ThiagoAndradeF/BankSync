using BankSynce.Models;

namespace BankSynce.Repositories{
    public class Cliente : ICliente
    {
        public Task<IEnumerable<Fornecedor>> ListarFornecedoresComContasPorIdCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransacaoFull>> ListarTodasTransacoesIdCliente(int idCliente)
        {
            throw new NotImplementedException();
        }
    }
}