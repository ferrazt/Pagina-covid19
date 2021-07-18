using COVID.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COVID.Map
{
    public class VW01_COVID_UFMap : IEntityTypeConfiguration<VW01_COVID_UF>
    {
        public void Configure(EntityTypeBuilder<VW01_COVID_UF> entity)
        {
            entity.HasNoKey();
        }
    }
}
