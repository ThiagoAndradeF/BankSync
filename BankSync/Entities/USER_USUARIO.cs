namespace BankSynce.Entities
{
    public class USER_USUARIO
    {
        public int CD_USUARIO { get; set; }
        public string DS_EMAIL { get; set; } = String.Empty;
        public string DS_SENHA { get; set; } = String.Empty;
        public DateTime DT_CADASTRO { get; set; }
        public int CD_PESSOA { get; set; }
        public PES_CLIENTE PESSOA {get;set;} = default!;
        
    }
}
