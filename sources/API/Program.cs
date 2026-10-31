// <copyright file="Program.cs" company="Автор">
// Copyright (c) Автор 2026. Example.
// </copyright>

namespace API
{
    using API.Extensions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Scalar.AspNetCore;

    /// <summary>
    /// Класс, содержащий точку входа.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Точка входа.
        /// </summary>
        /// <param name="args"> Аргументы командной строки. </param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.

            _ = builder.Services.AddControllers();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            _ = builder.Services.AddOpenApi(options =>
            {
                // Подключаем наши классы-трансформеры
                _ = options.AddAllSchemaTransformers();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                _ = app.MapOpenApi();

                // Подключаем современный UI от Scalar
                _ = app.MapScalarApiReference();
            }

            _ = app.UseHttpsRedirection();
            _ = app.UseAuthorization();
            _ = app.MapControllers();

            app.Run();
        }
    }
}
