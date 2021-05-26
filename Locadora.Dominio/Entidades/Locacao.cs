using System;
using System.Collections.Generic;

namespace Locadora.Dominio.Entidades
{
    public class Locacao : EntidadeBase
    {
        public string CpfCliente { get; set; }
        public DateTime DataLocacao { get; set; }
        public virtual List<Filme> Filmes { get; set; }
    }
}
