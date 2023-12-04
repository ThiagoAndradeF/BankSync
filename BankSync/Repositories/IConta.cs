using BankSynce.Models;
using BankSynce.Entities;

namespace BankSynce.Repositories{
    public interface IConta{
        Task<bool> CriarContaCompleta(ContaDto informacoesConta);
        Task<ContaParaPessoa> ListarContasPessoa(int idPessoa);

    }
}