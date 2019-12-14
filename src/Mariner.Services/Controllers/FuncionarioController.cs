using AutoMapper;
using Mariner.Data.Contracts;
using Mariner.Data.Entities;
using Mariner.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Mariner.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult POST(FuncionarioCadastroModel model, [FromServices] IFuncionarioRepository repository, [FromServices] IMapper mapper)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcioanrio = mapper.Map<Funcionario>(model);
                    repository.Inserir(funcioanrio);

                    return Ok("Funcionario cadastrado com sucesso.");
                }
                catch (Exception erro)
                {
                    return StatusCode(500, erro.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult PUT(FuncionarioEdicaoModel model, [FromServices] IFuncionarioRepository repository, [FromServices] IMapper mapper)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcioanrio = mapper.Map<Funcionario>(model);
                    repository.Atualizar(funcioanrio);

                    return Ok("Funcionario atualizado com sucesso.");
                }
                catch (Exception erro)
                {
                    return StatusCode(500, erro.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DELETE(int id, [FromServices] IFuncionarioRepository repository)
        {
            try
            {   
                repository.Excluir(repository.ObterPorId(id));
                return Ok("Funcioanrio excluido com sucesso.");
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpGet]
        public IActionResult GET([FromServices] IFuncionarioRepository repository, [FromServices] IMapper mapper)
        {
            try
            {
                return Ok(mapper.Map<List<FuncionarioConsultaModel>>(repository.ObterTodos()));
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GET(int id, [FromServices] IFuncionarioRepository repository, [FromServices] IMapper mapper)
        {
            try
            {
                return Ok(mapper.Map<FuncionarioConsultaModel>(repository.ObterPorId(id)));
            }
            catch (Exception erro)
            {
                return StatusCode(500, erro.Message);
            }
        }
    }
}