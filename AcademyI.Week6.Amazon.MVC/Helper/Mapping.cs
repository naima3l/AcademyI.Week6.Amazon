using AcademyI.Week6.Amazon.CORE;
using AcademyI.Week6.Amazon.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.MVC.Helper
{
    public static class Mapping
    {
        public static ProdottoViewModel toProdottoViewModel(this Prodotto prodotto)
        {
            return new ProdottoViewModel
            {
                Codice = prodotto.Codice,
                Descrizione = prodotto.Descrizione,
                PrezzoFornitore = prodotto.PrezzoFornitore,
                PrezzoPubblico = prodotto.PrezzoPubblico,
                Tipologia = (Models.EnumTipologia)prodotto.Tipologia
            };
        }

        public static Prodotto toProdotto(this ProdottoViewModel prodottoViewModel)
        {
            return new Prodotto
            {
                Codice = prodottoViewModel.Codice,
                Descrizione = prodottoViewModel.Descrizione,
                PrezzoFornitore = prodottoViewModel.PrezzoFornitore,
                PrezzoPubblico = prodottoViewModel.PrezzoPubblico,
                Tipologia = (CORE.EnumTipologia)prodottoViewModel.Tipologia
            };
        }
    }
}
