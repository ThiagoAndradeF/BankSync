using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankSynce.Models;
using BankSynce.Repositories;

namespace BankSynce.Controllers;

public class TransacaoController : ControllerBase
{
    private readonly ITransacao _transacao;
    public TransacaoController(ITransacao transacao){
        _transacao = transacao;
    }
    

}
