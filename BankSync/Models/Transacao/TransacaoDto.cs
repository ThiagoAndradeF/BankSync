namespace BankSynce.Models{
    public class TransacaoDto
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public int Valor { get; set; }
        public int IdContaEntrada { get; set; }
        public int IdContaSaida {get;set; }

    }
    
}