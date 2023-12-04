
namespace BankSynce.Entities
{
    public class Cliente 
    { 
        public int IdCliente { get; set;} 
        public string Nome { get; set ; } = string.Empty;
        public Usuario Usuario {get;set;} = default!;
        public List<Conta>? Contas { get; set; }
        public List<Fornecedor> Fornecedores {get;set;} = default!;
        
        // public List<OCS_TRANSACOES> TRANSACOES {get;set;} = default!;
    }
}