using BankSynce.Entities;

namespace BankSynce.Models{
    public class TransacaoFull
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int Valor { get; set; }
        public Conta ContaEntrada {get; set;} = default!;
        public Conta ContaSaida {get; set;} = default!;
        public int IdContaSaida {get;set; }

    }
    
}