using BankSynce.Models;

namespace BankSynce.Repositories{
    public class Conta : IConta
    {
        public Task<bool> CriarContaCompleta(ContaDto informacoesConta)
        {
            throw new NotImplementedException();
        }

        public Task<ContaParaPessoa> ListarContasPessoa(int idPessoa)
        {
            throw new NotImplementedException();
        }
    }


}