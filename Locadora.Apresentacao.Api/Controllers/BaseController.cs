using Locadora.Aplicacao.Dto.Base;
using Locadora.Aplicacao.Interfaces;
using Locadora.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<Entidade, EntidadeDto> : Controller
        where Entidade : EntidadeBase
        where EntidadeDto : DtoBase
    {
        readonly protected IBaseApp<Entidade, EntidadeDto> _app;

        public BaseController(IBaseApp<Entidade, EntidadeDto> app)
        {
           _app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var restaurantes = _app.BuscarTodos();
                return new OkObjectResult(restaurantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var restaurantes = _app.BuscarPorId(id);
                return new OkObjectResult(restaurantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _app.ExcluirPorId(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
