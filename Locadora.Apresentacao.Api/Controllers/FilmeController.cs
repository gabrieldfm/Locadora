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
    public class FilmeController : BaseController<Filme, FilmeDto>
    {
        private readonly IFilmeApp _app;

        public FilmeController(IFilmeApp app)
            : base(app)
        {
            _app = app;
         }

        [HttpPut]
        public IActionResult Editar([FromBody] FilmeDto dado)
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
        public IActionResult Adicionar([FromBody] FilmeDto dado)
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

        [HttpDelete]
        [Route("RemoverFilmes")]
        public IActionResult RemoverFilmes([FromBody] List<int> ids)
        {
            try
            {
                _app.ExcluirVarios(ids);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
