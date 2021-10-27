using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.CORE.Repositories
{
    public interface IProdottoRepository : IRepository<Prodotto>
    {
        Prodotto GetByCode(string codice);
    }
}
