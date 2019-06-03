using System.ComponentModel.DataAnnotations;

namespace GCP_CF.Models
{
    public class EstadosFases
    {
        [Key]
        public int Estado_Id { get; set; }
        public string Descripcion { get; set; }
    }
}