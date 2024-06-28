namespace Restaurante.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public int MesaID { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public Mesa Mesa { get; set; }
    }
}
