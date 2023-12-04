namespace BankSynce.Entities
{
    public class Conta
    {
        public int IdConta { get; set; }
        public decimal Saldo { get; set; }
        public string NumeroConta { get; set; } = string.Empty;
        public string NumeroAgencia { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public int IdBanco { get; set; }
        public Banco Banco { get; set; } = default!;
        public int? IdCliente { get; set; }
        public Cliente? Cliente { get; set; } = default!;
        public int? IdFornecedor {get;set;}
        public Fornecedor? Fornecedor {get;set;} = default!;
        public List<Transacao> TransacaoEntrada {get;set;} = default!;
        public List<Transacao> TransacaoSaida {get;set;} = default!;
    }
}
