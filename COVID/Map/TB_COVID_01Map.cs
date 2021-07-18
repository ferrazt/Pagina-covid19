using COVID.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Map
{
    public class TB_COVID_01Map : IEntityTypeConfiguration<TB_COVID_01>
    {
        public void Configure(EntityTypeBuilder<TB_COVID_01> entity)
        {
            entity.HasNoKey();
        }
    }
}
