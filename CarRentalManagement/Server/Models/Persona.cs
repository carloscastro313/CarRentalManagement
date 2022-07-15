using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Server.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Edad { get; set; }
    }
}
