using System.Text.Json.Serialization;

namespace TrialProject.API.Models
{
    /// <summary>
    /// Enum for gender
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Female, Male, Other
    }
}
