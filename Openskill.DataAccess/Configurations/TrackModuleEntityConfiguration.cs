using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Openskill.Domain.Entities;

namespace Friendly.DataAccess.Configurations
{
    public class TrackModuleEntityConfiguration : IEntityTypeConfiguration<TrackModule>
    {
        public void Configure(EntityTypeBuilder<TrackModule> builder)
        {
            builder.HasKey(x => new { x.TrackId, x.ModuleId });

            builder.HasOne(x => x.Track)
                .WithMany(x => x.TrackModules)
                .HasForeignKey(x => x.TrackId);

            builder.HasOne(x => x.Module)
                .WithMany(x => x.TrackModules)
                .HasForeignKey(x => x.ModuleId);
        }
    }
}