using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankSynce.Models;
using BankSynce.Repositories;

namespace BankSynce.Controllers;

public class FornecedorController : ControllerBase
{
    private readonly IFornecedor _fornecedor;
    public FornecedorController(IFornecedor fornecedor){
        _fornecedor = fornecedor;
    }
    

}
