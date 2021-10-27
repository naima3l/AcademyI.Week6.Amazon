using System;

namespace AcademyI.Week6.Amazon.CORE
{
    public class Prodotto
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public EnumTipologia Tipologia { get; set; }
        public decimal PrezzoPubblico { get; set; }
        public decimal PrezzoFornitore { get; set; }

        
    }
    public enum EnumTipologia
    {
        Elettronica = 1,
        Abbigliamento = 2,
        Casalinghi = 3
    }
}
