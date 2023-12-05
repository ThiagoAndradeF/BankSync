namespace BankSynce.Models
{
    public class FornecedorComContasDto
    { 
        public string Nome { get; set ; } = string.Empty;
        public string? Email {get;set; } =string.Empty;
        public string?  Telefone {get;set;} = string.Empty;
        public List<ContaParaPessoa>? Contas {get;set;} 
    }
}