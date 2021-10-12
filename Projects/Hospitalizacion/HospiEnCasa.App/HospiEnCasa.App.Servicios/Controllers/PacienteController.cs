using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HospiEnCasa.App.Persistencia.AppRepositorios;

namespace HospiEnCasa.App.Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IRepositorioPaciente _repositorioPaciente;
        public PacienteController(IRepositorioPaciente repositorioPaciente)
        {
            this._repositorioPaciente = repositorioPaciente;
        }    
    }
}