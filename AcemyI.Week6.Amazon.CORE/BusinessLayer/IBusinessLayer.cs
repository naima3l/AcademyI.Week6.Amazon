using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.CORE.BusinessLayer
{
    public interface IBusinessLayer
    {
        public List<Prodotto> GetAll();

        public bool Create(Prodotto item);

        public bool Edit(Prodotto item);

        public bool DeleteByCode(string cod);
    }
}
