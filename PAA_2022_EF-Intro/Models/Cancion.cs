using System.ComponentModel.DataAnnotations.Schema;

namespace PAA_2022_EF_Intro.Models
{
    [Table("Cancion")] //Indicara la tabla y la clase POCO
    public class Cancion
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }

        // Relaciones
        public virtual Album Album { get; set; }
    }
}
