
namespace BankSynce.Entities
{
    public class PES_CLIENTE 
    { 
        public List<PES_FORNECEDOR> FORNECEDORES {get;set;} = default!;
        public int CD_CLIENTE { get; set;} 
        public string NM_CLIENTE { get; set ; } = string.Empty;
        public List<OCS_CONTA>? CONTAS { get; set; }
        
        public USER_USUARIO USUARIO {get;set;} = default!;

        public int CD_USUARIO { get;set;}
        
        public List<OCS_TRANSACOES> TRANSACOES {get;set;} = default!;
    }
}