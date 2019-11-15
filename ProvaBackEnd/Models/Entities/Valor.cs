using System.ComponentModel.DataAnnotations;

namespace ProvaBackEnd.Models.Entities
{
    public class Valor
    {
        public int Id  { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        [Display(Name = "$/min")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorMin  { get; set; }
        

        public Valor()
        {
            
        }

        public Valor(int id, string origem, string destino, double valormin)
        {
            Id = id;
            Origem = origem;
            Destino = destino;
            ValorMin = valormin;
        }
    }
}