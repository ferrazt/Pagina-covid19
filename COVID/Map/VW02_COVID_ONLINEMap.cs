using COVID.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COVID.Map
{
    public class VW02_COVID_ONLINEMap : IEntityTypeConfiguration<VW02_COVID_ONLINE>
    {
        public void Configure(EntityTypeBuilder<VW02_COVID_ONLINE> entity)
        {
            entity.HasNoKey();
        }
    }
}
