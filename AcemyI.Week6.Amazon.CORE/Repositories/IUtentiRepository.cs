using AcademyI.Week6.Amazon.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.CORE.Repositories
{
    public interface IUtentiRepository : IRepository<Utente>
    {
        Utente GetByUsername(string username);
    }
}
