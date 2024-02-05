namespace PizzaPlace.Models
{
    public class Cesta
    {
        public Clientes clientes { get; set; } = new Clientes();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool Pago { get; set; }
        public void Add(int PizzaId) => Pedidos.Add(PizzaId);
        public void EliminarEn(int PedidaId) => Pedidos.RemoveAt(PedidaId);
    }
}
