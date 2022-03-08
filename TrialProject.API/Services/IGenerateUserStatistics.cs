using TrialProject.API.Models;

namespace TrialProject.API.Services;

/// <summary>
/// Interface to generate statistics.
/// </summary>
public interface IGenerateUserStatistics
{
    /// <summary>
    /// Gets the statistics.
    /// </summary>
    /// <param name="userModels">The users.</param>
    /// <returns>Statistics Model</returns>
    StatisticsModel GetStatistics(List<IUserModel> userModels);
}