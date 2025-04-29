using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TipanProyecto.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "El valor a pagar debe ser mayor que 0")]
        public decimal ValorPagar { get; set; }

        // Clave foránea
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}
