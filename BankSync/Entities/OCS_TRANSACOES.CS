namespace BankSynce.Entities
{
    public class OCS_TRANSACOES
    {
        public int CD_CONTA { get; set; }
        public OCS_CONTA CONTA {  get; set; } = default!;
        public int CD_USUARIO { get; set; }
        public USER_USUARIO USUARIO { get; set; } = default!;
        public int CD_TRANSACAO { get; set; }
        
        public OCS_TRANSACOES TRANSACAO { get; set; } = default!;

        public DateTime DT_TRANSACAO { get; set; }
        public string DS_TRANSACAO { get; set; } = string.Empty;
        public int VL_TRANSACAO { get; set; }
        
        public int ID_TRANSACAO { get; set; }
            //(entrada=1/saida=2)
    }
}
