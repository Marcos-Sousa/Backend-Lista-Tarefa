using Backend_Lista_Tarefa.Contexto;
using Backend_Lista_Tarefa.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend_Lista_Tarefa.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly DataContext _context;

        public TarefaRepositorio(DataContext context)
        {
            _context = context;
        }
        public void Adicionar(Tarefa tarefa)
        {
            _context.Tarefa.Add(tarefa);
            _context.SaveChanges();
        }

        public void Atualizar(Tarefa tarefa)
        {
            _context.Entry(tarefa).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task<Tarefa> BuscarPorId(Guid Id)
        {
            return await _context.Tarefa.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public void Deletar(Tarefa tarefa)
        {
            _context.Tarefa.Remove(tarefa);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Tarefa>> BuscarTodas()
        {
            return await _context.Tarefa.ToListAsync();

        }
    }
}
