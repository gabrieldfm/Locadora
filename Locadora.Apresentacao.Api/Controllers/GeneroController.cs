using Locadora.Aplicacao.Dto;
using Locadora.Aplicacao.Dto.Genero;
using Locadora.Aplicacao.Interfaces;
using Locadora.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.Api.Controllers
{
    public class GeneroController : BaseController<Genero, GeneroDto>
    {
        private readonly IGeneroApp _app;

        public GeneroController(IGeneroApp app)
            : base(app)
        {
            _app = app;
        }

        [HttpPut]
        public IActionResult Editar([FromBody] GeneroDto dado)
        {
            try
            {
                _app.Editar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] GeneroDto dado)
        {
            try
            {
                return new OkObjectResult(_app.Adicionar(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
