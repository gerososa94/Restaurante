using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class DetallePedido
    {
        [Key]
        public int DetalleID { get; set; }
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public Pedido Pedido { get; set; }
        public decimal Precio { get; set; }

        public Producto Producto { get; set; }
    }
}
