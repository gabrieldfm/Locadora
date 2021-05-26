using Locadora.Aplicacao.Dto;
using Locadora.Aplicacao.Dto.Filme;
using Locadora.Aplicacao.Interfaces;
using Locadora.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.Api.Controllers
{
    public class LocacaoController : BaseController<Locacao, LocacaoDto>
    {
        private readonly ILocacaoApp _app;
        public LocacaoController(ILocacaoApp app) : base(app)
        {
            _app = app;
        }

        [HttpPut]
        public IActionResult Editar([FromBody] LocacaoDto dado)
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
        public IActionResult Adicionar([FromBody] LocacaoDto dado)
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
