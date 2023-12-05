namespace BankSynce.Models{
    public class ContaParaPessoa
    {
        public int idConta {get;set;}
        public decimal Saldo { get; set; }
        public string NumeroConta { get; set; } = string.Empty;
        public string NumeroAgencia { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public string NomeBanco {get;set;} = string.Empty;
    }
}