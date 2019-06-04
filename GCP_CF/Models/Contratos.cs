using System;
using System.ComponentModel.DataAnnotations;

namespace GCP_CF.Models
{
    public class Contratos
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Display(Name ="Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        public int TipoContrato_Id { get; set; }

        public int Persona_Id { get; set; }

        public string ObjetoContractual { get; set; }
        [Required(ErrorMessage = "{0} es Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Plazo")]
        public DateTime Plazo { get; set; }
        [Required(ErrorMessage = "{0} es Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Terminación")]
        public DateTime FechaTerminacion { get; set; }

        public int PersonaAbogado_Id { get; set; }

        public int PersonaSuperviosr_Id { get; set; }

        public int Crp { get; set; }

        public int Cdp { get; set; }

        public DateTime FechaActaInicio { get; set; }

        public int TipoEstadoContrato_Id { get; set; }

        [Display(Name = "Año")]
        public int Year { get; set; }

        public decimal ValorContrato { get; set; }

        public decimal ValorAdministrar { get; set; }

        public decimal Honorarios { get; set; }

        public int Ejecucion { get; set; }

        public decimal PorcentajeFacturado { get; set; }

        public decimal PorcentajeFacturadoHonorarios { get; set; }

        public int PersonaSupervisorTecnico_Id { get; set; }

        public int ContratoMarco_Id { get; set; }

    }
}