using DWBot.Data.Repositories;
using DWBot.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DWBot.Data.EntitiesConfiguration;

internal sealed class StateConfiguration : IEntityTypeConfiguration<UserState>
{
    public void Configure(EntityTypeBuilder<UserState> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.UserId)
            .IsUnique();

        builder.Property(x => x.State)
            .HasConversion(
                baseState => baseState.Id,
                stateId => StateRepository.AvailableStates[stateId]
            );
    }
}
