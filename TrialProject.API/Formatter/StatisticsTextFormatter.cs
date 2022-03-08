using System.Text;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using TrialProject.API.Models;

namespace TrialProject.API.Formatter
{
    /// <summary>
    /// If the accept header is text/plain then this formatter will automatically convert the statistics to plain text.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Formatters.TextOutputFormatter" />
    public class StatisticsTextFormatter : TextOutputFormatter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsTextFormatter"/> class.
        /// </summary>
        public StatisticsTextFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/plain"));

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }
        protected override bool CanWriteType(Type? type) => typeof(StatisticsModel).IsAssignableFrom(type)
            || typeof(IEnumerable<StatisticsModel>).IsAssignableFrom(type);

        /// <summary>
        /// Writes the response body.
        /// </summary>
        /// <param name="context">The formatter context associated with the call.</param>
        /// <param name="selectedEncoding">The <see cref="T:System.Text.Encoding" /> that should be used to write the response.</param>
        /// <returns>
        /// A task which can write the response body.
        /// </returns>
        public override async Task WriteResponseBodyAsync(
                    OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var httpContext = context.HttpContext;

            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<StatisticsModel> statistics)
            {
                foreach (var statistic in statistics)
                {
                    formatStatistics(buffer, statistic);
                }
            }
            else
            {
                formatStatistics(buffer, (StatisticsModel)context.Object!);
            }

            await httpContext.Response.WriteAsync(buffer.ToString(), selectedEncoding);
        }

        /// <summary>
        /// Formats the statistics to plain text.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="statistics">The statistics.</param>
        private static void formatStatistics(StringBuilder buffer, StatisticsModel statistics)
        {
            buffer.AppendLine($"Percentage female versus male: {statistics.FemalePercentage}%.");
            buffer.AppendLine($"Percentage of first names that start with A-M versus N-Z: {statistics.FirstNameAThroughMPercentage}%.");
            buffer.AppendLine($"Percentage of last names that start with A-M versus N-Z: {statistics.LastNameAThroughMPercentage}%.");

            buffer.AppendLine("Percentage of people in each state, up to the top 10 most populous states:");
            buffer.AppendLine(GetPeopleInStateStrings(statistics.AllPeopleStatePercentage));

            buffer.AppendLine("Percentage of females in each state, up to the top 10 most populous states:");
            buffer.AppendLine(GetPeopleInStateStrings(statistics.FemaleStatePercentage));

            buffer.AppendLine("Percentage of males in each state, up to the top 10 most populous states:");
            buffer.AppendLine(GetPeopleInStateStrings(statistics.MaleStatePercentage));

            buffer.AppendLine("Percentage of people in the following age ranges:");
            buffer.AppendLine(GetAgeRangeStrings(statistics.AgeRangePercentages));


            //Internal methods because there was no need to make these static and no point in including these in the StatisticsModel class either

            string GetPeopleInStateStrings(IReadOnlyList<PeopleStatePercentageModel> states)
            {
                var builder = new StringBuilder();

                for (var i = 0; i < states.Count; i++)
                {
                    builder.AppendLine($"{i + 1}. {states[i].State} - {states[i].Percentage}%");
                }

                return builder.ToString();
            }

            string GetAgeRangeStrings(List<AgeRangeModel> ageRanges)
            {
                var builder = new StringBuilder();

                foreach (var ageRange in ageRanges)
                {
                    builder.AppendLine($"{ageRange.StartingAge} - {ageRange.EndingAge}: {ageRange.Percentage}%");
                }

                return builder.ToString();
            }

        }
    }
}
