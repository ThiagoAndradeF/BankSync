namespace BankSynce.Entities
{
    public class OCS_TRANSACOES
    {
        public int CD_TRANSACAO { get; set; }
        public int CD_CONTA_ENTRADA { get; set; }
        public OCS_CONTA  CONTA_ENTRADA {  get; set; } = default!;
        public int CD_CONTA_SAIDA {get;set; }
        public OCS_CONTA CONTA_SAIDA {  get; set; } = default!;
        public int CD_CLIENTE { get; set; }
        public PES_CLIENTE CLIENTE { get; set; } = default!;
        public int CD_FORNECEDOR { get; set; }
        public PES_FORNECEDOR FORNECEDOR {get;set;} = default!;
        public DateTime DT_TRANSACAO { get; set; }
        public string DS_TRANSACAO { get; set; } = string.Empty;
        public int VL_TRANSACAO { get; set; }
        public int ID_TRANSACAO { get; set; }//(entrada=1/saida=2)
    }
}
