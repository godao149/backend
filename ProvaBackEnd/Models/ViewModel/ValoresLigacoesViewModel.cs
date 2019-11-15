using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProvaBackEnd.Models.Entities;

namespace ProvaBackEnd.Models.ViewModel
{
    public class ValoresLigacoesViewModel
    {
        public Ligacao Ligacoes  { get; set; }
        public Valor Valores { get; set; }
    }
}