namespace BlazorTest.Models
{
    public class AppSettingsOptions
    {
        public const string AppSettings = "AppSettings";

        public string ApplicationName { get; set; } = string.Empty;

        public string Slot { get; set; } = string.Empty;
    }
}
