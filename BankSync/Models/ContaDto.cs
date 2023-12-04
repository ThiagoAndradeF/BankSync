namespace BankSynce.Models{
    public class ContaDto
    {
        public decimal Saldo { get; set; }
        public string NumeroConta { get; set; } = string.Empty;
        public string NumeroAgencia { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public string NomeBanco {get;set;} = string.Empty;
        public int? IdCliente { get; set; } 
        public int? IdFornecedor {get;set;} = default!;
    }
}