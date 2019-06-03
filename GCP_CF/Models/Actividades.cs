using System.ComponentModel.DataAnnotations;

namespace GCP_CF.Models
{
    public class Actividades
    {
        [Key]
        public int Actividad_Id { get; set; }
        public string Descripción { get; set; }
    }
}