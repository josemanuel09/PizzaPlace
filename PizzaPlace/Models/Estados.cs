using PizzaPlace.Menu;

namespace PizzaPlace.Models
{
    public class Estados
    {
        public MenuLocal Menu { get; set; } = new MenuLocal();
        public Cesta cestaD { get; } = new Cesta();
        public InterfazUsuario Interfaz { get; set; } = new InterfazUsuario();
        public decimal PrecioTotal => cestaD.Pedidos.Sum(Id => Menu.ObtenerPizzas(Id)!.Precio);
    }
}
