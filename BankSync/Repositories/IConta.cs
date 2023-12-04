using BankSynce.Models;

namespace BankSynce.Repositories{
    public interface IConta{
        Task<bool> CriarUsuarioCompleto(UsuarioFull usuario);
        


    }
}