namespace BankSynce.Models
{
    public class FornecedorDto
    { 
        public string Nome { get; set ; } = string.Empty;
        public int IdCliente { get; set; }
        public string? Email {get;set; } =string.Empty;
        public string?  Telefone {get;set;} = string.Empty;
    }
}