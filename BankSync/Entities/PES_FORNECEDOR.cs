namespace BankSynce.Entities
{
    public class PES_FORNECEDOR
    {
        public int CD_FORNECEDOR { get; set; }
        public string NM_FORNECEDOR { get; set; } = string.Empty;
        public int CD_USUARIO { get; set; }
        public USER_USUARIO USUARIO { get; set; } = default!; 
    }
}
