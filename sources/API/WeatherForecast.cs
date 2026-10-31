// <copyright file="WeatherForecast.cs" company="Автор">
// Copyright (c) Автор 2026. Example.
// </copyright>

namespace API
{
    using System;

    /// <summary>
    /// Прогноз погоды на один день.
    /// </summary>
    public sealed class WeatherForecast
    {
        /// <summary>
        /// Дата.
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Температура в градусах Цельсия (°C).
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Температура в градусах Фаренгейта (°F).
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Короткая заметка о погоде.
        /// </summary>
        /// <example>
        /// Ветрено.
        /// </example>
        public string? Summary { get; set; }
    }
}
