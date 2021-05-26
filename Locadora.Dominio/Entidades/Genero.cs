using System;
using System.Collections.Generic;

namespace Locadora.Dominio.Entidades
{
    public class Genero : EntidadeBase
    {
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public short Ativo { get; set; }
        public virtual List<Filme> Filmes { get; set; }

        //Validando se trata-se de uma edição ou adição para então setar a data de criação
        public void SetarDataCriacaoAdicao(Genero entidade)
        {
            if(entidade.Id == 0)
                entidade.DataCriacao = DateTime.Now;
        }

    }
}
