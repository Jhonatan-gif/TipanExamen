using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipanProyecto.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Range(0, 120)]
        public int Edad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal IngresoMensual { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public bool EsSocio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
    }
}
