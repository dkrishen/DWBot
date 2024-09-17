using System.ComponentModel.DataAnnotations;

namespace DWBot.Infrastructure.Options;

public sealed class BotConfigurationOptions
{
    public const string SectionName = "BotConfiguration";

    [Required]
    public string BotToken { get; set; } = string.Empty;
}