namespace BankSynce.Entities
{
    public class TAB_BANCO
    {
        public int CD_BANCO { get; set; }
        public string NM_BANCO { get; set; } = string.Empty;
        public List<OCS_CONTA>? OCS_CONTA { get; set; }
    }
}