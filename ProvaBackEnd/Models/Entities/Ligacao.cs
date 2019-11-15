using System;
using System.ComponentModel.DataAnnotations;
using ProvaBackEnd.Models.Enums;


namespace ProvaBackEnd.Models.Entities
{
    public class Ligacao
    {

        public int Id { get; set; }
        public DateTime Tempo  { get; set; }
        public FaleMaisEnum Plano { get; set; }

        public int ValorId  { get; set; }
        public Valor Valor  { get; set; }

        public Ligacao(int id, DateTime tempo, FaleMaisEnum plano)
        {
            Id = id;
            Tempo = tempo;
            Plano = plano;  
        }

        public Ligacao()
        {
                
        }
    }
}