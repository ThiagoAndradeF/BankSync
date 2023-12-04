using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankSynce.Models;
using BankSynce.Repositories;

namespace BankSynce.Controllers;

public class ClienteController : ControllerBase
{
    private readonly ICliente _cliente;
    public ClienteController(ICliente cliente){
        _cliente = cliente;
    }
    

}
