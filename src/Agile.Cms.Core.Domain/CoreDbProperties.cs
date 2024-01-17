namespace Agile.Cms.Core;

public static class CoreDbProperties
{
    public static string DbTablePrefix { get; set; } = "AgileCmsCore";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AgileCmsCore";
}
