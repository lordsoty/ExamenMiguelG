namespace VENTAS.API.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int Id_usuario { get; set; }
        public int folio { get; set; }
        public float saldo { get; set; }
        public DateTime fecha_facturacion { get; set; }
        public DateTime fecha_creacion { get; set; }



    }
}
