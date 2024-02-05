﻿using System.Text.Json;

namespace PizzaPlace.Cliente
{
    public static class Extencionesdedepuracion
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
