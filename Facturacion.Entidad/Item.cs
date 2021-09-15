namespace Facturacion.Entidad
{
    public class Item
    {
        public int IdItem { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Item()
        {
            IdItem = 0;
            Descripcion = string.Empty;
            Precio = 0;
        }
    }
}
