using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.MVC.Models
{
    public class ProdottoViewModel
    {
        [Required]
        public string Codice { get; set; }
        public string Descrizione { get; set; }

        [Required]
        public EnumTipologia Tipologia { get; set; }
        public decimal PrezzoPubblico { get; set; }

        [Required]
        public decimal PrezzoFornitore { get; set; }
        
    }
    public enum EnumTipologia
    {
        Elettronica = 1,
        Abbigliamento = 2,
        Casalinghi = 3
    }
}
