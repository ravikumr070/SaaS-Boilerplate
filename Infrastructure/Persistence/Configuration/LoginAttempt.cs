using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class LoginAttemptConfig : IEntityTypeConfiguration<LoginAttempt.LoginAttempt>
{
    public void Configure(EntityTypeBuilder<LoginAttempt.LoginAttempt> builder) =>
        builder
            .ToTable("LoginAttempt", SchemaNames.Auditing);
           
}