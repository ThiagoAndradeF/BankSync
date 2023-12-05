namespace BankSynce.Models
{
    public class UsuarioFull
    { 
        public ClienteDto Cliente { get; set ; } = new();
         public string Email { get; set; } = String.Empty;
        public string Senha { get; set; } = String.Empty;
        public DateTime DataCadastro { get; set;}
    }
}

    
