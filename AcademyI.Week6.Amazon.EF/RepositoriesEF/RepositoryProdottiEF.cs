using AcademyI.Week6.Amazon.CORE;
using AcademyI.Week6.Amazon.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.EF.RepositoriesEF
{
    public class RepositoryProdottiEF : IProdottoRepository
    {
        public Prodotto Add(Prodotto item)
        {
            using (var ctx = new AmazonContext())
            {
                ctx.Prodotti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Prodotto item)
        {
            using (var ctx = new AmazonContext())
            {
                ctx.Prodotti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Prodotto> Fetch()
        {
            using (var ctx = new AmazonContext())
            {
                return ctx.Prodotti.ToList();
            }
        }

        public Prodotto GetByCode(string codice)
        {
            using (var ctx = new AmazonContext())
            {
                return ctx.Prodotti.FirstOrDefault(p=> p.Codice == codice);
            }
        }

        public Prodotto Update(Prodotto item)
        {
            using (var ctx = new AmazonContext())
            {
                ctx.Prodotti.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
