﻿namespace PizzaPlace.Models
{
    public class Pizzas
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Despricion { get; }
        public decimal Precio { get; }
        public Picantes Picante { get; }
        public Pizzas(int Id, string Nombre, string Descricpion, decimal Precio, Picantes Picantes)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Despricion = Descricpion;
            this.Precio = Precio;
            this.Picante = Picantes;
        }
    }
}
