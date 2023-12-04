
using System.Security.Cryptography;

namespace BankSynce.Entities
{
    public class Fornecedor 
    { 
        public int IdFornecedor {get;set;}
        public int IdCliente { get; set; }
        public string Email {get;set; } =string.Empty;
        public string  Telefone {get;set;} = string.Empty;
        public Cliente Cliente {get;set;} = default!;
        public string Nome { get; set ; } = string.Empty;
        public List<Conta> Contas { get; set; } = default!;
        // public List<OCS_TRANSACOES> TRANSACOES {get;set;} = default!;
    }
}