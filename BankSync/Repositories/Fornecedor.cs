using BankSynce.Models;

namespace BankSynce.Repositories{
    public class Fornecedor : IFornecedor
    {
        public Task<bool> CriarFornecedor(FornecedorDto informacoesFornecedor)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransacaoFull>> ListarTransacoesFornecedorIdFornecedor(int idFornecedor)
        {
            throw new NotImplementedException();
        }
    }


}