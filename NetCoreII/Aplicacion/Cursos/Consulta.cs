using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using System.Collections.Generic;

namespace Aplicacion.Cursos
{
    public class Consulta
    {
        public class ListaCursos: IRequest<List<Curso>>{
        }

        public class Manejador: IRequestHandler<ListaCursos, List<Curso>>{
            private readonly CursosOnlineContext _context;

            public Manejador(CursosOnlineContext context)
            {
                _context = context;
            }

            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken){
                var cursos = await _context.Curso.ToListAsync();
                return cursos;
            }
        }
    }
}