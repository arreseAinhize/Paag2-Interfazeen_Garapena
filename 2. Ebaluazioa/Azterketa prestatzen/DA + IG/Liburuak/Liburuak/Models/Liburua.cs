namespace Liburuak.Models
{
    public class Liburua
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public string autor_id { get; set; }
        public string saga { get; set; }
        public int numero_saga { get; set; }
        public int anio_publicacion { get; set; }
        public int paginas { get; set; }
        public string isbn { get; set; }
        public double valoracion_promedio { get; set; }
        public string sinopsis { get; set; }
    }
}
