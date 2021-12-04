namespace Diphda.Infrastructure.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Diphda.Domain.Account;

    public sealed class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");

            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Username)
                .HasConversion(u => u.ToString(), user => user)
                .IsRequired()
                .HasColumnName("USERNAME")
                .HasColumnType("VARCHAR(100)");

            builder
                .Property(u => u.Password)
                .HasConversion(u => u.ToString(), user => user)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasColumnType("VARCHAR(100)");

            builder.Property(u => u.Active)
                .IsRequired()
                .HasColumnName("ACTIVE")
                .HasColumnType("BIT");
        }
    }
}