using AcademyI.Week6.Amazon.CORE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week6.Amazon.EF.Configurations
{
    public class ProdottoConfiguration : IEntityTypeConfiguration<Prodotto>
    {
        public void Configure(EntityTypeBuilder<Prodotto> modelBuilder)
        {
            modelBuilder.HasKey(p => p.Codice);
            modelBuilder.Property(p => p.Descrizione);
            modelBuilder.Property(p => p.PrezzoPubblico);
            modelBuilder.Property(p => p.PrezzoFornitore);
            modelBuilder.Property(p => p.Tipologia);
        }
    }
}
