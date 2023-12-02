namespace BankSynce.Entities
{
    public class USER_USUARIO
    {
        public int CD_USUARIO { get; set; }
        public string NM_PESSOA { get; set; } = String.Empty;
        public string DS_EMAIL { get; set; } = String.Empty;
        public string DS_SENHA { get; set; } = String.Empty;
        public DateTime DT_CADASTRO { get; set; }
        public List<OCS_CONTA>? CONTAS {  get; set; }
    }
}
