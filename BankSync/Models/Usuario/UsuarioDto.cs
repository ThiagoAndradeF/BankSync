namespace BankSynce.Models{
    public class UsuarioDto
    {
        public string Email { get; set; } = String.Empty;
        public string Senha { get; set; } = String.Empty;
        public DateTime DataCadastro { get; set;}
    }
}