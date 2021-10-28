using AcademyI.Week6.Amazon.CORE.Models;
using AcademyI.Week6.Amazon.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.EF.RepositoriesEF
{
    public class RepositoryUtentiEF : IUtentiRepository
    {
        public Utente Add(Utente item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Utente item)
        {
            throw new NotImplementedException();
        }

        public List<Utente> Fetch()
        {
            throw new NotImplementedException();
        }

        public Utente GetByUsername(string username)
        {
            using (var ctx = new AmazonContext())
            {
                if (string.IsNullOrEmpty(username))
                {
                    return null;
                }
                return ctx.Utenti.FirstOrDefault(u => u.Username == username);
            }
        }

        public Utente Update(Utente item)
        {
            throw new NotImplementedException();
        }
    }
}
