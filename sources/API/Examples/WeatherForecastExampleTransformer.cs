// <copyright file="WeatherForecastExampleTransformer.cs" company="Автор">
// Copyright (c) Автор 2026. Example.
// </copyright>

namespace API.Examples
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Nodes;

    /// <summary>
    /// Генератор примеров для использования <see cref="WeatherForecast"/>.
    /// </summary>
    public sealed class WeatherForecastExampleTransformer : BaseExampleTransformer<WeatherForecast>
    {
        /// <inheritdoc/>
        protected override IEnumerable<WeatherForecast> GetExamples()
        {
            yield return new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = 25,
                Summary = "Тепло и солнечно",
            };
        }

        /// <inheritdoc/>
        protected override JsonNode Serialize(WeatherForecast model)
        {
            return new JsonObject
            {
                ["date"] = model.Date.ToShortDateString(),
                ["temperatureC"] = model.TemperatureC,
                ["summary"] = model.Summary,
            };
        }
    }
}
