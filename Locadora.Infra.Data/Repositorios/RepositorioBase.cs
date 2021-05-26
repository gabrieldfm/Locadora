using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Repositorios;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Locadora.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly Contexto.Contexto _contexto;

        public RepositorioBase(Contexto.Contexto contexto) : base()
        {
            _contexto = contexto;
        }

        public int Adicionar(TEntidade entidade)
        {
            _contexto.InitTransaction();
            var id = _contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            _contexto.SendChanges();
            return id;
        }

        public TEntidade BuscarPorId(int id)
        {
            return _contexto.Set<TEntidade>().AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<TEntidade> BuscarTodos()
        {
            return _contexto.Set<TEntidade>().AsNoTracking().ToList();
        }

        public void Editar(TEntidade entidade)
        {
            _contexto.InitTransaction();
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SendChanges();
        }

        public void ExcluirPorId(int id)
        {
            var entidade = BuscarPorId(id);
            if (entidade != null)
            {
                _contexto.InitTransaction();
                _contexto.Set<TEntidade>().Remove(entidade);
                _contexto.SendChanges();
            }
        }

        public void ExcluirVarios(List<int> ids)
        {
            foreach (var id in ids)
            {
                var entidade = BuscarPorId(id);
                if (entidade != null)
                {
                    _contexto.InitTransaction();
                    _contexto.Set<TEntidade>().Remove(entidade);
                    _contexto.SendChanges();
                } 
            }
        }
    }
}
