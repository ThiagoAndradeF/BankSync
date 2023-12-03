namespace BankSynce.Entities
{
    public interface PES_PESSOA
    {
        public int CD_PESSOA { get; set; }
        public string NM_PESSOA { get;set; }
        public List<OCS_CONTA>? CONTAS {  get; set; }
        
    }
}
