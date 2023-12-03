
namespace BankSynce.Entities
{
    public class PES_FORNECEDOR : PES_PESSOA
    { 
        PES_CLIENTE CREDOR {get;set;} = default!;
        int PES_PESSOA.CD_PESSOA { get; set;}
        string PES_PESSOA.NM_PESSOA { get; set ; } = string.Empty;
        List<OCS_CONTA>? PES_PESSOA.CONTAS { get; set; }
    }
}