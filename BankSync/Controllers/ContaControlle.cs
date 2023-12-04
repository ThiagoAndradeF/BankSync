using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankSynce.Models;
using BankSynce.Repositories;

namespace BankSynce.Controllers;

public class ContaController : ControllerBase
{
    private readonly IConta _conta;
    public ContaController(IConta conta){
        _conta = conta;
    }
    

}
