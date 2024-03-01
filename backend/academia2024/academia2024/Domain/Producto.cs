namespace academia2024.Domain
{
    public class Producto
    {
        // "Producto" refiere a "propiedad" pero usaremos
        // el primer término para evitar ambigüeades.
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Barrio { get; set; }
        public int Precio { get; set; }
        public string Estado { get; set; }
        public string UrlImagen { get; set; }


    }
}
