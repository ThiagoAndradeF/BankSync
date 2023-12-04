
using BankSynce.Models;

namespace BankSynce.Repositories{
    public interface ITransacao{
        Task<bool> AdicionarTransacao(TransacaoDto transacaoDto);
        
        
        
    }

}