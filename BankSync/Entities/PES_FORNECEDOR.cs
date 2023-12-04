
namespace BankSynce.Entities
{
    public class PES_FORNECEDOR 
    { 
        public int CD_FORNECEDOR {get;set;}
        public int CD_CLIENTE { get; set; }
        public PES_CLIENTE CLIENTE {get;set;} = default!;
        public string NM_FORNECEDOR { get; set ; } = string.Empty;
        public List<OCS_CONTA> CONTAS { get; set; } = default!;
        // public List<OCS_TRANSACOES> TRANSACOES {get;set;} = default!;
    }
}