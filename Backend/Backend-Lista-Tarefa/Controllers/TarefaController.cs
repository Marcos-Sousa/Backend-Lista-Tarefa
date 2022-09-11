using Backend_Lista_Tarefa.Comandos;
using Backend_Lista_Tarefa.Comandos.Saida;
using Backend_Lista_Tarefa.Comandos.Tarefa;
using Backend_Lista_Tarefa.Manipuladores;
using Backend_Lista_Tarefa.Modelos;
using Backend_Lista_Tarefa.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Backend_Lista_Tarefa.Controllers
{
    [ApiController]
    [Route("cards")]
    public class TarefaController : ControllerBase
    {
        private readonly ComandoManipuladorTarefa _comandoManipuladorTarefa;
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaController(ComandoManipuladorTarefa comandoManipuladorTarefa, ITarefaRepositorio tarefaRepositorio)
        {
            _comandoManipuladorTarefa = comandoManipuladorTarefa;
            _tarefaRepositorio = tarefaRepositorio;
        }

        [HttpGet]
        public async Task<IEnumerable<Tarefa>> BuscarTodas()
        {
            var response = await _tarefaRepositorio.BuscarTodas();
            return response;
        }

        [HttpGet("{Id}")]
        [Authorize]

        public async Task<Tarefa> BuscarPorId(Guid Id)
        {
            var response = await _tarefaRepositorio.BuscarPorId(Id);
            return response;
        }

        [HttpPost]
        [Authorize]
        public async Task<IComandoSaida> Adcionar([FromBody] ComandoManipuladorAdicionarTarefa comando)
        {
            var responder = await _comandoManipuladorTarefa.manipulador(comando);
            return responder;
        }

        [HttpPut("{Id}")]
        [Authorize]
        public async Task<IComandoSaida> Atualizar(Guid Id, [FromBody] ComandoManipuladorAtualizarTarefa comando)
        {
            comando.Id = Id;
            var responder = await _comandoManipuladorTarefa.manipulador(comando);
            return responder;
        }

        [HttpDelete("{Id}")]
        [Authorize]
        public async Task<IActionResult> Delete(Guid Id)
        {
            var response = (ComandoSaida)await _comandoManipuladorTarefa.Deletar(Id);
            return Ok(response);
        }
    }
}
