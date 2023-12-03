
namespace BankSynce.Entities
{
    public class PES_CLIENTE : PES_PESSOA
    { 
        List<PES_FORNECEDOR> FORNECEDORES {get;set;} = default!;
        int PES_PESSOA.CD_PESSOA { get; set;}
        string PES_PESSOA.NM_PESSOA { get; set ; } = string.Empty;
        List<OCS_CONTA>? PES_PESSOA.CONTAS { get; set; }
        public int CD_USUARIO { get;set;}
        public USER_USUARIO USUARIO {get;set;} = default!;
        
    }
}