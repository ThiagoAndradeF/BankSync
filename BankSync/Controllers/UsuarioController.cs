using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BankSynce.Models;
using BankSynce.Repositories;

namespace BankSynce.Controllers;

public class UsuarioController : ControllerBase
{
    private readonly IUsuario _usuario;
    public UsuarioController(IUsuario usuario){
        _usuario = usuario;
    }
    

}
