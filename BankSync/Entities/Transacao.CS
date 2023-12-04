namespace BankSynce.Entities
{
    public class Transacao
    {
        public int IdTransacao { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int Valor { get; set; }

        public int IdContaEntrada { get; set; }
        public Conta  ContaEntrada {  get; set; } = default!;
        public int IdContaSaida {get;set; }
        public Conta ContaSaida {  get; set; } = default!;


        // public int ID_TRANSACAO { get; set; }
        // public int CD_CLIENTE { get; set; }
        // public PES_CLIENTE CLIENTE { get; set; } = default!;
        // public int CD_FORNECEDOR { get; set; }
        // public PES_FORNECEDOR FORNECEDOR {get;set;} = default!;
    }
}
