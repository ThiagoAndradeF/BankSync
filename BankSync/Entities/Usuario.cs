namespace BankSynce.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; } = String.Empty;
        public string Senha { get; set; } = String.Empty;
        public DateTime DataCadastro { get; set;}
        public int IdCliente { get; set; }
        public Cliente Cliente {get;set;} = default!;
        
    }
}
