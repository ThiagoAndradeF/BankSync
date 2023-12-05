namespace BankSynce.Models
{
    public class ClienteFullDto
    {

        public int IdCliente { get; set;} 
        public string Nome { get; set ; } = string.Empty;
        public int IdUsuario { get;set;}
        public UsuarioDto Usuario {get;set;} = default!;
        public List<ContaDto>? Contas { get; set; }
        public List<FornecedorDto>? Fornecedores {get;set;} = default!;
        
    }
}


    

