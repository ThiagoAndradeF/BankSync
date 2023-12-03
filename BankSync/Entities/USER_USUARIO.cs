namespace BankSynce.Entities
{
    public class USER_USUARIO
    {
        public int CD_USUARIO { get; set; }
        public string DS_EMAIL { get; set; } = String.Empty;
        public string DS_SENHA { get; set; } = String.Empty;
        public DateTime DT_CADASTRO { get; set;}
        public int CD_CLIENTE { get; set; }
        public PES_CLIENTE CLIENTE {get;set;} = default!;
        
    }
}
