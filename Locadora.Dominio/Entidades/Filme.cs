using System;
using System.Collections.Generic;

namespace Locadora.Dominio.Entidades
{
    public class Filme :EntidadeBase
    {
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public short Ativo { get; set; }
        public int? LocacaoId { get; set; }
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Locacao Locacao { get; set; }

        //Validando se trata-se de uma edição ou adição para então setar a data de criação
        public void SetarDataCriacaoAdicao(Filme entidade)
        {
            if (entidade.Id == 0)
                entidade.DataCriacao = DateTime.Now;
        }

    }
}
