using AcademyI.Week6.Amazon.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.CORE.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IProdottoRepository prodottiRepo;

        public MainBusinessLayer(IProdottoRepository prodottiRepository)
        {
            prodottiRepo = prodottiRepository;
        }

        public bool Create(Prodotto item)
        {
            var prodottoEsistente = prodottiRepo.GetByCode(item.Codice);
            if(prodottoEsistente!= null)
            {
                return false;
            }
            prodottiRepo.Add(item);
            return true;
        }

        public bool DeleteByCode(string cod)
        {
            var prodottoEsistente = prodottiRepo.GetByCode(cod);
            if (prodottoEsistente == null)
            {
                return false;
            }

            return prodottiRepo.Delete(prodottoEsistente);
        }

        public bool Edit(Prodotto item)
        {
            var prodottoEsistente = prodottiRepo.GetByCode(item.Codice);
            if (prodottoEsistente == null)
            {
                return false;
            }

            prodottiRepo.Update(item);
            return true;
        }

        public List<Prodotto> GetAll()
        {
            return prodottiRepo.Fetch();
        }
    }
}
