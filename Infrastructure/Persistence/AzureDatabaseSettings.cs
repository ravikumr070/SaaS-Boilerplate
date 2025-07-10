using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistence;

public class AzureDatabaseSettings : IValidatableObject
{
    public string DBProvider { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
    public string ElasticPoolName { get; set; } = string.Empty;
    public string ResourceGroupName { get; set; } = string.Empty;
    public string SqlServerName { get; set; } = string.Empty;
    public string SubscriptionId { get; set; } = string.Empty;
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(DBProvider))
        {
            yield return new ValidationResult(
                $"{nameof(AzureDatabaseSettings)}.{nameof(DBProvider)} is not configured",
                new[] { nameof(DBProvider) });
        }

        if (string.IsNullOrEmpty(ConnectionString))
        {
            yield return new ValidationResult(
                $"{nameof(AzureDatabaseSettings)}.{nameof(ConnectionString)} is not configured",
                new[] { nameof(ConnectionString) });
        }
        if (string.IsNullOrEmpty(ElasticPoolName))
        {
            yield return new ValidationResult(
                $"{nameof(AzureDatabaseSettings)}.{nameof(ElasticPoolName)} is not configured",
                new[] { nameof(ElasticPoolName) });
        }
        if (string.IsNullOrEmpty(ResourceGroupName))
        {
            yield return new ValidationResult(
                $"{nameof(AzureDatabaseSettings)}.{nameof(ResourceGroupName)} is not configured",
                new[] { nameof(ResourceGroupName) });
        }
        if (string.IsNullOrEmpty(SqlServerName))
        {
            yield return new ValidationResult(
                $"{nameof(AzureDatabaseSettings)}.{nameof(SqlServerName)} is not configured",
                new[] { nameof(SqlServerName) });
        }
        if (string.IsNullOrEmpty(SubscriptionId))
        {
            yield return new ValidationResult(
                $"{nameof(AzureDatabaseSettings)}.{nameof(SubscriptionId)} is not configured",
                new[] { nameof(SubscriptionId) });
        }

    }
}