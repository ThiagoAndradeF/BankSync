namespace BankSynce.Entities
{
    public class OCS_CONTA
    {
        public int CD_CONTA { get; set; }
        public decimal VL_SALDO { get; set; }
        public string NR_CONTA { get; set; } = string.Empty;
        public string NR_AGENCIA { get; set; } = string.Empty;
        public DateTime DT_CADASTRO { get; set; }
        public int CD_BANCO { get; set; }
        public TAB_BANCO BANCO { get; set; } = default!;
        public int CD_PESSOA { get; set; }
        public PES_PESSOA PESSOA { get; set; } = default!;
    }
}
