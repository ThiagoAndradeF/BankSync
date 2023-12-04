namespace BankSynce.Entities
{
    public class Banco
    {
        public int IdBanco { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<Conta>? Contas { get; set; }

    }
}